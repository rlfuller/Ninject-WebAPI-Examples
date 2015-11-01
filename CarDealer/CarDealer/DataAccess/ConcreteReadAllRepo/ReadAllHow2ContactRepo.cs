using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllHow2ContactRepo:ReadAllRepo<HowToContact>
    {
        public ReadAllHow2ContactRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllHow2ContactRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}