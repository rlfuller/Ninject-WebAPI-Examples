using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadModelByIDRepo:ProcessOneRepo<ModelVM>
    {
        public ReadModelByIDRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<ModelVM> Process(Request<ModelVM> inRequest)
        {
            Response<ModelVM> result = new Response<ModelVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@mID", inRequest.Data.ModelID.ToString());
                result.Data = (cn.Query<ModelVM>("dbo.LoadModelByID", p, commandType: CommandType.StoredProcedure).ToList()).ElementAt(0);
            }
            return result;
        }
    }
}