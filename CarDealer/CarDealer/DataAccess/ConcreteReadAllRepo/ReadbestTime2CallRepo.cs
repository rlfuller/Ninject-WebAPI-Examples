using Models;

namespace DataAccess.DapperReaders
{
    public class ReadBestTime2CallRepo:ReadAllRepo<BestTimeToCall>
    {
        public ReadBestTime2CallRepo(string inConnString) : base(inConnString)
        {
        }

        public ReadBestTime2CallRepo(string inConnString, string inSproc) : base(inConnString, inSproc)
        {
        }
    }
}