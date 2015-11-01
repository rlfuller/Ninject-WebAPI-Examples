using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllChassisBusiness:ReadAllBusiness<Chassis>
    {
        public ReadAllChassisBusiness(ReadAllRepo<Chassis> inRepo, Response<List<Chassis>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}