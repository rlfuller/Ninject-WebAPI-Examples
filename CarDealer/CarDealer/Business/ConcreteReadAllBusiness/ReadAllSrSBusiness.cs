using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllSrSBusiness : ReadAllBusiness<SalesRequestStatus>
    {
        public ReadAllSrSBusiness(ReadAllRepo<SalesRequestStatus> inRepo, Response<List<SalesRequestStatus>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }

        public override Response<List<SalesRequestStatus>> ReadAll()
        {
            return base.ReadAll();
        }
    }
}