using System.Collections.Generic;
using Models;

namespace DataAccess.DapperReaders
{
    public abstract class ProcessOneRepo<T> where T : new()
    {
        protected string _connString;

        protected ProcessOneRepo(string inConnString)
        {
            _connString = inConnString;
        }

        public abstract Response<T> Process(Request<T> inRequest);
    }
}


