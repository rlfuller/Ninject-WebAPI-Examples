using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllVehicleForCustomerBusiness:ReadAllBusiness<VehicleVM>
    {
        public ReadAllVehicleForCustomerBusiness(ReadAllRepo<VehicleVM> inRepo, Response<List<VehicleVM>> inNewResponse) : base(inRepo, inNewResponse)
        {
        }
    }
}