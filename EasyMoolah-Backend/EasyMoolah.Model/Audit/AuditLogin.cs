using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMoolah.Model.Audit
{
    public class AuditLogin
    {
        [Key]
        public int Key { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserPassword { get; set; }

        [Required]
        public int Attempt { get; set; }

        [Required]
        public bool Reset { get; set; }

        [Required]
        public string IPAddress { get; set; }

        [Required]
        public DateTime LoginDate { get; set; }
    }
}
