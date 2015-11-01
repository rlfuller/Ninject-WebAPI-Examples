using Models;

namespace DataAccess.DapperReaders
{
    public class ReadModelOnMakeIDRepo:ReadOnIDRepo<ModelVM>
    {
        public ReadModelOnMakeIDRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadModelOnMakeIDRepo(string inConnString, string inSproc, string inSprocParam) : base(inConnString, inSproc, inSprocParam)
        {
        }
    }
}