using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class InsertModelBusiness:ProcessOneBusiness<ModelVM>
    {
        public InsertModelBusiness(ProcessOneRepo<ModelVM> inRepo, Response<ModelVM> inNewResponse) : base(inRepo, inNewResponse)
        {
        }

        public override Response<ModelVM> Process(Request<ModelVM> inRequest)
        {
            _response = _repo.Process(inRequest);

            if (_response.Data.ModelID == 0)
            {
                _response.Success = false;
                _response.Message = "Record was not added...";

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