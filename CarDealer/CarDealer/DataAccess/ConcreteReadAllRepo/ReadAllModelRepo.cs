using Models;

namespace DataAccess.DapperReaders
{
    public class ReadAllModelRepo:ReadAllRepo<ModelVM>
    {
        public ReadAllModelRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllModelRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }

    public class ReadAllSrSRepo : ReadAllRepo<SalesRequestStatus>
    {
        public ReadAllSrSRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadAllSrSRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }

}