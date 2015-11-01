using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public abstract class ReadOnIDRepo<T> where T : new()
    {
        protected string _connString;
        protected string _sqlSproc;
        protected string _sprocParam;

        protected ReadOnIDRepo(string inConnString)
        {
            _connString = inConnString;
        }

        protected ReadOnIDRepo(string inConnString, string inSproc, string inSprocParam)
        {
            _connString = inConnString;
            _sqlSproc = inSproc;
            _sprocParam = inSprocParam;
        }
        
        public virtual Response<List<T>> ReadManyByID (int inID)
        {         
            Response<List<T>> result = new Response<List<T>>();
            List<T> resultData = new List<T>();

            using (SqlConnection connection = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add(_sprocParam, inID.ToString());
                resultData = connection.Query<T>(_sqlSproc,p, commandType: CommandType.StoredProcedure).ToList();
            }
            result.Data = resultData;
            return result;
        }
    }
}