using System.Threading.Tasks;
using EasyMoolah.Model.ViewModel;
using EasyMoolah.Model;

namespace EasyMoolah.Contracts.Domain
{
    public interface IMerchant
    {
        Task<MerchantViewModel> GetMerchant(Request request, int id);
        Task<int> AddMerchant(Request request, MerchantViewModel merchantViewModel);
        Task EditMerchant(Request request, MerchantViewModel merchantViewModel);
    }
}