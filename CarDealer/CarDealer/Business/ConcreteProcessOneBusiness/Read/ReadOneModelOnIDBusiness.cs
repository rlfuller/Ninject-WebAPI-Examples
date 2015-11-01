using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class ReadOneModelOnIDBusiness:ProcessOneBusiness<ModelVM>
    {
        public ReadOneModelOnIDBusiness(ProcessOneRepo<ModelVM> inRepo, Response<ModelVM> inNewResponse) : base(inRepo, inNewResponse)
        {
        }

        public override Response<ModelVM> Process (Request<ModelVM> inRequest)
        {
            _response =  _repo.Process(inRequest);

            // query not successful (cant happen here due to drop down,
            // but could happen searching on an unkown...
            if (_response.Data == null)
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