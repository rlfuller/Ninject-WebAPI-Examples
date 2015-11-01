namespace Models
{
    public class Lead
    {
        public int LeadID { get; set; }
        public string LeadName { get; set; }
        public string LeadPhone { get; set; }
        public string LeadEmail { get; set; }
        public int BestTimeToCallID { get; set; }
        public int PurchTimeframeID { get; set; }
        public string LeadQuestion { get; set; }
        public int HowToContactID { get; set; }
    }
}

