using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadLeadSummaryBusiness:ReadAllBusiness<LeadSummaryVM>
    {
        public ReadLeadSummaryBusiness(ReadAllRepo<LeadSummaryVM> inRepo, Response<List<LeadSummaryVM>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}