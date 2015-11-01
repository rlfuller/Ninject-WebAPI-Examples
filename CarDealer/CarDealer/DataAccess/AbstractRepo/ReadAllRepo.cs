using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public abstract class ReadAllRepo<T> where T : new()
    {
        protected string _connString;
        protected string _sqlSproc;

        protected ReadAllRepo(string inConnString)
        {
            _connString = inConnString;
        }

        protected ReadAllRepo(string inConnString, string inSproc)
        {
            _connString = inConnString;
            _sqlSproc = inSproc;
        }

        public virtual Response<List<T>> ReadAll()
        {
            Response<List<T>> result = new Response<List<T>>();
            List<T> resultData = new List<T>();

            using (SqlConnection connection = new SqlConnection(_connString))
            {
                resultData = connection.Query<T>(_sqlSproc, commandType: CommandType.StoredProcedure).ToList();
            }
            result.Data = resultData;
            return result;
        }
    }
}