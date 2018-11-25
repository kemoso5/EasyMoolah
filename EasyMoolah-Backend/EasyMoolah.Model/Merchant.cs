using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyMoolah.Model
{
    [Table("tbl_Merchant")]
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
        public bool FinanceOffered { get; set; }

        [Required]
        public int IndustryId { get; set; }
    }
}
