using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadVehicleOnMakeIDBusiness:ReadManyOnIDBusiness<VehicleVM>
    {
        public ReadVehicleOnMakeIDBusiness(ReadOnIDRepo<VehicleVM> inRepo, Response<List<VehicleVM>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}