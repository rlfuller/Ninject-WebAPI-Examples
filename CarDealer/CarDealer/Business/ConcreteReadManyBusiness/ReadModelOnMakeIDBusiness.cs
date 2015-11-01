using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadModelOnMakeIDBusiness:ReadManyOnIDBusiness<ModelVM>
    {
        public ReadModelOnMakeIDBusiness(ReadOnIDRepo<ModelVM> inRepo, Response<List<ModelVM>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}