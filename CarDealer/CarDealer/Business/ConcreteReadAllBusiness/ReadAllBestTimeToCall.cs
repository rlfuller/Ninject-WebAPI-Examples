using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllBestTimeToCall:ReadAllBusiness<BestTimeToCall>
    {
        public ReadAllBestTimeToCall(ReadAllRepo<BestTimeToCall> inRepo, Response<List<BestTimeToCall>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}