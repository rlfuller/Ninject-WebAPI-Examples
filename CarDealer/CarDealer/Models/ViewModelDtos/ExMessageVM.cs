using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ExMessageVM
    {
        public string ExMessage { get; set; }
    }


    public class ContactHistVM
    {
        public int EmpID { get; set; }
        public DateTime ContactDate { get; set; }
        public string ContactDetails { get; set; }        
    }
}
