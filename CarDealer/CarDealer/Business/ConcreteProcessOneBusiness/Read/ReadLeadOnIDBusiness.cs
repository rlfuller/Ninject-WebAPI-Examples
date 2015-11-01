using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class ReadLeadOnIDBusiness:ProcessOneBusiness<LeadUpdateVM>
    {
        public ReadLeadOnIDBusiness(ProcessOneRepo<LeadUpdateVM> inRepo, Response<LeadUpdateVM> inNewResponse): base(inRepo, inNewResponse)
        {
           
        }


        public override Response<LeadUpdateVM> Process(Request<LeadUpdateVM> inRequest)
        {
            _response = _repo.Process(inRequest);

            // query not successful (cant happen here due to drop down,
            // but could happen searching on an unkown...
            if (_response.Data.SalesRequestID==0)
            {
                _response.Success = false;
                _response.Message = "No such record...";
            }
            else
            {
                _response.Success = true;
                _response.Message = "Read successful";
            }

            return _response;
        }
    }
}