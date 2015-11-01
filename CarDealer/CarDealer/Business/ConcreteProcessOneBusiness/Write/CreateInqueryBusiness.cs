using DataAccess;
using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class CreateInqueryBusiness : ProcessOneBusiness<InqueryVM>
    {

        public override Response<InqueryVM> Process(Request<InqueryVM> inRequest)
        {
            // generate new SrSID



            // 1.  persisit to dbo.SalesRequest
            var salesReqRepo = new InsertSalesRequestRepo(ConnStringGetter.GetConnString);
            var request1 = new Request<SalesRequest>();
            request1.Data.AdID = inRequest.Data.VehicleDto.AdID;
            request1.Data.VehID = inRequest.Data.VehicleDto.VehID;
            // new sales request ID is in here
            var response1 = salesReqRepo.Process(request1);

            // 2. Presist to dbo.Lead
            var leadRepo = new InsertLeadRepo(ConnStringGetter.GetConnString);
            var request2 = new Request<Lead>();
            request2.Data.LeadName = inRequest.Data.Name;
            request2.Data.LeadPhone = inRequest.Data.Phone;
            request2.Data.LeadEmail = inRequest.Data.Email;
            request2.Data.BestTimeToCallID = inRequest.Data.BestTimeToCallID;
            request2.Data.PurchTimeframeID = inRequest.Data.PurchTimeframeID;
            request2.Data.LeadQuestion = inRequest.Data.LeadQuestion;
            request2.Data.HowToContactID = inRequest.Data.HowToContactID;
            // new lead ID is here
            var response2 = leadRepo.Process(request2);

            // 3. persist to LeadSalesRequest
            var leadSalesReqRepo = new InsertLeadSalesRequestRepo(ConnStringGetter.GetConnString);
            var request3 = new Request<LeadSalesRequest>();
            request3.Data.SalesRequestID = response1.Data.SalesRequestID;
            request3.Data.LeadID = response2.Data.LeadID;
            // blank dto here...
            var response3 = leadSalesReqRepo.Process(request3);

            // return result
            var result = new Response<InqueryVM>();
            result.Data.LeadID = response2.Data.LeadID;
            result.Data.SalesRequestID = response1.Data.SalesRequestID;

            if (response2.Data.LeadID == 0 || response1.Data.SalesRequestID == 0)
            {
                result.Success = false;
                result.Message = "Inquery not submitted...";
            }

            result.Success = true;
            result.Message = "Inquery added successfuly";
            result.Data.LeadID = response2.Data.LeadID;
            result.Data.SalesRequestID = response1.Data.SalesRequestID;
            return result;
        }
    }
}