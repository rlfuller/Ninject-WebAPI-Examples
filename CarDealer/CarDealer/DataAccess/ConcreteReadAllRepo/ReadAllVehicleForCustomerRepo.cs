using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllVehicleForCustomerRepo:ReadAllRepo<VehicleVM>
    {
        public ReadAllVehicleForCustomerRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllVehicleForCustomerRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}