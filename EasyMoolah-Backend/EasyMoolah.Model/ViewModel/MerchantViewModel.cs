using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace EasyMoolah.Model.ViewModel
{
    public class MerchantViewModel: BaseModel
    {
        [Required]
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [Required]
        [JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        [Required]
        [JsonProperty(PropertyName = "EstablishedYear")]
        public int EstablishedYear { get; set; }

        [Required]
        [JsonProperty(PropertyName = "URL")]
        public string URL { get; set; }

        [Required]
        [JsonProperty(PropertyName = "ContactNumber")]
        public string ContactNumber { get; set; }

        [Required]
        [JsonProperty(PropertyName = "AnnualRevenueSales")]
        public float AnnualRevenueSales { get; set; }

        [Required]
        [JsonProperty(PropertyName = "AverageTicket")]
        public float AverageTicket { get; set; }

        [Required]
        [JsonProperty(PropertyName = "FinanceOffered")]
        public bool FinanceOffered { get; set; }

        [Required]
        [JsonProperty(PropertyName = "IndustryId")]
        public int IndustryId { get; set; }
    }
}
