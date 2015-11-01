using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllTimeframe2PurchRepo:ReadAllRepo<TimeFrameToPurchase>
    {
        public ReadAllTimeframe2PurchRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllTimeframe2PurchRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}