using AutoMapper;
using EasyMoolah.Model;
using EasyMoolah.Model.Exceptions;
using EasyMoolah.Model.Exceptions.Merchant;
using EasyMoolah.Model.ViewModel;
using System;
using System.Collections.Generic;

namespace EasyMoolah.Repository
{
    public class MerchantRepository : BaseRepository
    {
        public MerchantRepository(EasyMoolahContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {

        }

        /// <summary>
        /// Get a single Merchant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public MerchantViewModel GetMerchant(int id)
        {
            try
            {
                var merchant = Find(id);
                var merchantViewModel = Map<MerchantViewModel>(merchant);
                return merchantViewModel;
            }
            catch (Exception ex)
            {
                throw new MerchantRepositoryException(
                                   "There was a problem retrieving the merchant. Check the inner exception for details.", ex);
            }
        }

        /// <summary>
        /// Add a single Merchant
        /// </summary>
        /// <param name="merchantViewModel"></param>
        /// <returns></returns>
        public int AddMerchant(MerchantViewModel merchantViewModel)
        {
            try
            {
                var merchant = Map<Merchant>(merchantViewModel);
                SetAddItemDetails(merchant);

                DbContext.Merchants.Add(merchant);
                DbContext.SaveChanges();

                return merchant.Id;
            }
            catch (Exception ex)
            {
                throw new MerchantRepositoryException(
                    "There was a problem adding the merchant. Check the inner exception for details.", ex);
            }
        }

        /// <summary>
        /// Edit a single Merchant
        /// </summary>
        /// <param name="merchantViewModel"></param>
        public void EditMerchant(MerchantViewModel merchantViewModel)
        {
            try
            {
                var merchant = Find(merchantViewModel.Id);
                SetEditItemDetails(merchant); //Not sure about this, confirm?
                DbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new MerchantRepositoryException(
                  "There was a problem editting the merchant. Check the inner exception for details.", ex);
            }
        }

        private Merchant Find(int id)
        {
            var merchant = DbContext.Merchants.Find(id);
            if (merchant == null) throw new EntityNotFoundException($"Could not find a merchant with the id {id}");
            return merchant;
        }
    }
}
