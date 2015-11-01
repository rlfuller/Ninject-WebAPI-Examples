using System.Data;
using System.Data.SqlClient;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class UpdateSalesRequestRepo : ProcessOneRepo<LeadUpdateVM>
    {
        public UpdateSalesRequestRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<LeadUpdateVM> Process(Request<LeadUpdateVM> inRequest)
        {
            Response<LeadUpdateVM> result = new Response<LeadUpdateVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@salesRequestID", inRequest.Data.SalesRequestID.ToString());
                p.Add("@srsID", inRequest.Data.SrsID.ToString());
                
                cn.Execute("dbo.UpdateSalesRequest", p, commandType: CommandType.StoredProcedure);
            }
            result.Data = inRequest.Data;
            return result;
        }
    }
}