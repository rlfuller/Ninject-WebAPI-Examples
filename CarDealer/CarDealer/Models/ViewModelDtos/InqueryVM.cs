using System;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models
{
    public class InqueryVM
    {
        // persistence:


        public int SalesRequestID { get; set; }
        public int AdID { get; set;}
        public int SrsID { get; set; }
        public int LeadID { get; set; }
        // public DateTime DateCreated { get; set;}

        [Required(ErrorMessage = "Please select purchase timeframe")]
        public int PurchTimeframeID { get; set; }

        [Required(ErrorMessage = "Please select best time to call")]
        public int BestTimeToCallID { get; set; }

        [Required(ErrorMessage = "Please select prefered contact method")]
        public int HowToContactID { get; set; }
        //public int SalesRequestID { get; set; }
        //public string LeadName { get; set; }
        //public int? AdID { get; set; }
        // name
        // phone
        // email
        // best time to call
        // purchase time frame drop down
        // details ()

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [RegularExpression(@"^\S+@\S+$", ErrorMessage = "The email format isn't valid")]
        public string Email { get; set; }

        public TimeFrameToPurchase PurchTimeFrameDto { get; set; }
        public HowToContact HowToContactDto { get; set;}
        public BestTimeToCall BestTimeToCallDto { get; set; }
        public VehicleVM VehicleDto { get; set; }
        public int VehID { get; set; }

    


        // timeframe to purchase

        //[Required(ErrorMessage = "Please enter your favorite game")]
        public string LeadQuestion { get; set; }

        public InqueryVM()
        {
            HowToContactDto = new HowToContact();
            BestTimeToCallDto = new BestTimeToCall();
            PurchTimeFrameDto = new TimeFrameToPurchase();
            VehicleDto = new VehicleVM();
        }
    }
}



