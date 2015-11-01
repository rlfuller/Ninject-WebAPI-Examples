using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllModelBusiness:ReadAllBusiness<ModelVM>
    {
        public ReadAllModelBusiness(ReadAllRepo<ModelVM> inRepo, Response<List<ModelVM>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}