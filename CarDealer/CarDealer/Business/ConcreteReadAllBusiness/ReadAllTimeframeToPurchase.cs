using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllTimeframeToPurchase:ReadAllBusiness<TimeFrameToPurchase>
    {
        public ReadAllTimeframeToPurchase(ReadAllRepo<TimeFrameToPurchase> inRepo, Response<List<TimeFrameToPurchase>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}