using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class UpdateModelBusiness:ProcessOneBusiness<ModelVM>
    {
        public UpdateModelBusiness(ProcessOneRepo<ModelVM> inRepo, Response<ModelVM> inNewResponse) : base(inRepo, inNewResponse)
        {
        }

        public override Response<ModelVM> Process(Request<ModelVM> inRequest)
        {
            _response = _repo.Process(inRequest);
          
            return _response;
        }
    }

 


}