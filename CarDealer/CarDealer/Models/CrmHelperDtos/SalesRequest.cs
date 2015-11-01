namespace Models
{
    public class SalesRequest
    {
        // persistense        
        public int? AdID { get; set; }
        public int? VehID { get; set; }
        // scope identity
        public int SalesRequestID { get; set; }
        // rest of table
        public int SrsID { get; set; }
        public int DateCreated { get; set; }
    }
}