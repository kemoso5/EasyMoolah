using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EasyMoolah.Contracts.Domain;
using EasyMoolah.Contracts.Repository;
using EasyMoolah.Model;
using EasyMoolah.Model.Exceptions.Merchant;
using EasyMoolah.Model.ViewModel;

namespace EasyMoolah.Domain
{
    public class Merchant : BaseDomain, IMerchant
    {
        private IMerchantRepository _merchantRepository;

        public Merchant(IMerchantRepository merchantRepository)
        {
            _merchantRepository = merchantRepository;
        }

        public async Task<MerchantViewModel> GetMerchant(Request request, int id)
        {
            try
            {
                var merchantViewModel = _merchantRepository.GetMerchant(id);

                return merchantViewModel;
            }
            catch (Exception ex)
            {
                throw new MerchantDomainException(
                    "There was a problem retrieving the merchant. Check the inner exception for details.", ex);
            }
        }

        public async Task<int> AddMerchant(Request request, MerchantViewModel merchantViewModel)
        {
            try
            {
                await SetAddItemDetails(request, merchantViewModel);

                var id = _merchantRepository.AddNote(merchantViewModel);
                return id;
            }
            catch (Exception ex)
            {
                throw new MerchantDomainException(
                    "There was a problem adding the merchant. Check the inner exception for details.", ex);
            }
        }

        public async Task EditMerchant(Request request, MerchantViewModel merchantViewModel)
        {
            try
            {
                await SetEditItemDetails(request, merchantViewModel);

                _merchantRepository.EditMerchant(merchantViewModel);
            }
            catch (Exception ex)
            {
                throw new MerchantDomainException(
                    "There was a problem editing the note. Check the inner exception for details.", ex);
            }
        }
    }
}
