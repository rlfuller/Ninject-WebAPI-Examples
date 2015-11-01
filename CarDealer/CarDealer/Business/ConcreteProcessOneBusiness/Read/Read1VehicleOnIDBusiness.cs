using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class Read1VehicleOnIDBusiness:ProcessOneBusiness<VehicleVM>
    {
        public Read1VehicleOnIDBusiness(ProcessOneRepo<VehicleVM> inRepo, Response<VehicleVM> inNewResponse) : base(inRepo, inNewResponse)
        {
        }

        public override Response<VehicleVM> Process(Request<VehicleVM> inRequest)
        {
            _response = _repo.Process(inRequest);

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