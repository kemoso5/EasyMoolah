using System;
using System.Collections.Generic;
using System.Text;
using EasyMoolah.Model.ViewModel;

namespace EasyMoolah.Contracts.Repository
{
    public interface IMerchantRepository
    {
        MerchantViewModel GetMerchant(int id);
        int AddNote(MerchantViewModel merchantViewModel);
        void EditMerchant(MerchantViewModel merchantViewModel);
    }
}
