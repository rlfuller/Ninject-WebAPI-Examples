using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllVehicleOnSprocBusiness:ReadAllBusiness<VehicleVM>
    {
        public ReadAllVehicleOnSprocBusiness(ReadAllRepo<VehicleVM> inRepo, Response<List<VehicleVM>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}