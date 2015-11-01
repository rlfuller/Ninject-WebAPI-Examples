using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllHow2Contact:ReadAllBusiness<HowToContact>
    {
        public ReadAllHow2Contact(ReadAllRepo<HowToContact> inRepo, Response<List<HowToContact>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}