using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllMakeRepo:ReadAllRepo<Make>
    {
        public ReadAllMakeRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllMakeRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}