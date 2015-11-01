using Models;

namespace DataAccess.DapperReaders
{
    public class ReadLeadSummaryRepo:ReadAllRepo<LeadSummaryVM>
    {
        public ReadLeadSummaryRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadLeadSummaryRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}