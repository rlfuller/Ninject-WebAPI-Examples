using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadContHistOnIDBusiness : ReadManyOnIDBusiness<ContactHistVM>
    {
        public ReadContHistOnIDBusiness(ReadOnIDRepo<ContactHistVM> inRepo, Response<List<ContactHistVM>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}