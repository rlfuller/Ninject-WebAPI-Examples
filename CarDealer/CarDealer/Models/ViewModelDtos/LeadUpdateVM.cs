using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Models
{
    public class LeadUpdateVM
    {
        public int SalesRequestID { get; set; }
        public int LeadID { get; set; }
        public DateTime DateCreated { get; set; }
        public string LeadName { get; set; }
        public string LeadPhone { get; set; }
        public string LeadEmail { get; set; }
        public string BestTime { get; set; }
        public string ContactMethod { get; set; }
        public string PurchaseTimeframe { get; set; }
        public string LeadQuestion { get; set; }
        public int VehID { get; set; }
        public bool IsDeleted { get; set; }
        public int PurchTimeframeID { get; set; }
        public string SrSType { get; set; }
        public int SrsID { get; set; }

        [DataType(DataType.Date)]
        public DateTime ContactDate { get; set; }

        public VehicleVM VehicleDto { get; set; }
        public SalesRequestStatus SrSDto { get; set; }

        [Required(ErrorMessage = "Please enter your ID!")]
        public int EmpID { get; set; }
      
        [Required(ErrorMessage = "Enter your comments!")]
        public string ContactDetails { get; set; }


        public string Availability
        {
            get
            {
                if (IsDeleted) return "No";
                return "Yes";
            }
        }

        public LeadUpdateVM()
        {
            VehicleDto = new VehicleVM();
            SrSDto = new SalesRequestStatus();
        }

    }
}