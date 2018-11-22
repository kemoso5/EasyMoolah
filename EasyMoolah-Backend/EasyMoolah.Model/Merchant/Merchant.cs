using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoolah.Model.Merchant
{
    public class Merchant: BaseModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int EstablishedYear { get; set; }

        [Required]
        public string URL { get; set; }

        [Required]
        public string ContactNumber { get; set; }

        [Required]
        public float AnnualRevenueSales { get; set; }

        [Required]
        public float AverageTicket { get; set; }

        [Required]
        public Boolean FinanceOffered { get; set; }

        [Required]
        public int IndustryKey { get; set; }
    }
}
