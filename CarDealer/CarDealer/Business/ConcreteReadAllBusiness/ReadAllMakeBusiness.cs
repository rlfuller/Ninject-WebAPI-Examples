using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllMakeBusiness:ReadAllBusiness<Make>
    {
        public ReadAllMakeBusiness(ReadAllRepo<Make> inRepo, Response<List<Make>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}