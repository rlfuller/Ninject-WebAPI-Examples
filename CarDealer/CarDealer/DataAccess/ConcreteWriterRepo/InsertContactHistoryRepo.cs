using System.Data;
using System.Data.SqlClient;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class InsertContactHistoryRepo : ProcessOneRepo<LeadUpdateVM>
    {
        public InsertContactHistoryRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<LeadUpdateVM> Process(Request<LeadUpdateVM> inRequest)
        {
            Response<LeadUpdateVM> result = new Response<LeadUpdateVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@empID", inRequest.Data.EmpID.ToString());
               // p.Add("@contactDate", inRequest.Data.ContactDate.ToString());
                p.Add("@contactDetails", inRequest.Data.ContactDetails);
                p.Add("@leadID", inRequest.Data.LeadID.ToString());
               
                cn.Execute("dbo.InsertContactHistory", p, commandType: CommandType.StoredProcedure);
            }
            result.Data = inRequest.Data;
            return result;
        }
    }
}