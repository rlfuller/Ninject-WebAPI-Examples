using DataAccess;
using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class LeadUpdateBusiness : ProcessOneBusiness<LeadUpdateVM>
    {
        public override Response<LeadUpdateVM> Process(Request<LeadUpdateVM> inRequest)
        {
            var insrtContHist = new InsertContactHistoryRepo(ConnStringGetter.GetConnString);
            insrtContHist.Process(inRequest);

            var updSalesReq = new UpdateSalesRequestRepo(ConnStringGetter.GetConnString);
            updSalesReq.Process(inRequest);

            // send a blank back - nothing to return here - try catch @ controller
            return new Response<LeadUpdateVM>();

        }
    }
}