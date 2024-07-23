using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ISPCRM.Models
{
    [Table("i_s_p_customer")]
    public class Customer
    {
       
        public int S_No { get; set; }
        public string cname { get; set; }
        public string caddress { get; set; }
        public string cemail { get; set; }
        public string cphone { get; set; }
        public string cplan { get; set; }
        public string cduration { get; set; }
        public int ccost { get; set; }
        public string cdate { get; set; }
        public string cuser { get; set; }
        public string cpwd { get; set; }
        public string ccpwd { get; set; }
    }
}
