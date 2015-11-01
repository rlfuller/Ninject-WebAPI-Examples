using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllDrivetrainRepo:ReadAllRepo<Drivetrain>
    {
        public ReadAllDrivetrainRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllDrivetrainRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}