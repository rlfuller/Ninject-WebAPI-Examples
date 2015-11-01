using DataAccess.DapperReaders;
using Models;

namespace Business
{
    public class UpdateVehicleBusiness : ProcessOneBusiness<VehicleVM>
    {
        protected UpdateVehicleBusiness()
        {
        }

        public UpdateVehicleBusiness(ProcessOneRepo<VehicleVM> inRepo, Response<VehicleVM> inNewResponse) : base(inRepo, inNewResponse)
        {
        }

        public override Response<VehicleVM> Process(Request<VehicleVM> inRequest)
        {
            _response = _repo.Process(inRequest);

            return _response;
        }
    }
}