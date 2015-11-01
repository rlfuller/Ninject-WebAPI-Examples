using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadContactHistOnIDRepo : ReadOnIDRepo<ContactHistVM>
    {
        public ReadContactHistOnIDRepo(string inConnString, string inSproc, string inSprocParam) : base(inConnString, inSproc, inSprocParam)
        {
        }

        public override Response<List<ContactHistVM>> ReadManyByID(int inID)
        {
            return base.ReadManyByID(inID);
        }
    }
}