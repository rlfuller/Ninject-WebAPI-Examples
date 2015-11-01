using System;


namespace Models
{
    public class LeadSummaryVM
    {
        public int SalesRequestID { get; set; }
        public string LeadName { get; set; }
        public int LeadID { get; set; }
        public int VehID { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsDeleted { get; set; }
        public string PurchaseTimeframe { get; set; }
        public int PurchTimeframeID {get; set;}
        public string SrsType { get; set; }
        public int SrsID { get; set; }
        public DateTime? ContactDate { get; set; }

        public string DateCreateSmartProp => DateCreated.ToShortDateString();


        public string Availability
        {
            get
            {
                if (IsDeleted) return "No";
                return "Yes";
            }
        }
    }
}