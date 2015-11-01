using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllVehicleOnSprocRepo:ReadAllRepo<VehicleVM>
    {
        public ReadAllVehicleOnSprocRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllVehicleOnSprocRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }

  

}