using Models;

namespace DataAccess.DapperReaders
{
    public class ReadVehicleOnMakeIDRepo:ReadOnIDRepo<VehicleVM>
    {
        public ReadVehicleOnMakeIDRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadVehicleOnMakeIDRepo(string inConnString, string inSproc, string inSprocParam) : base(inConnString, inSproc, inSprocParam)
        {
        }
    }
}