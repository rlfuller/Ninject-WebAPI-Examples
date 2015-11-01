using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllChassisRepo:ReadAllRepo<Chassis>
    {
        public ReadAllChassisRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllChassisRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}