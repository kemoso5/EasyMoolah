using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoolah.Model.Merchant
{
    public class MerchantAdress: BaseModel
    {
        [Required]
        public int MerchantKey { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Suburb { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }
    }
}
