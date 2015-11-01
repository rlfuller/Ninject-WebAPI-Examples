using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class ReadLeadOnIDRepo:ProcessOneRepo<LeadUpdateVM>
    {
        public ReadLeadOnIDRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<LeadUpdateVM> Process(Request<LeadUpdateVM> inRequest)
        {
            Response<LeadUpdateVM> result = new Response<LeadUpdateVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@lID", inRequest.Data.LeadID.ToString());
                result.Data = (cn.Query<LeadUpdateVM>("LoadLeadOnID", p, commandType: CommandType.StoredProcedure).ToList()).ElementAt(0);
            }
            return result;
        }
    }
}