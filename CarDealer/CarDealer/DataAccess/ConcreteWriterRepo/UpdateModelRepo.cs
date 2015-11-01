using System.Data;
using System.Data.SqlClient;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class UpdateModelRepo:ProcessOneRepo<ModelVM>
    {
        public UpdateModelRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<ModelVM> Process(Request<ModelVM> inRequest)
        {
            Response<ModelVM> result = new Response<ModelVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@mID", inRequest.Data.ModelID.ToString());
                p.Add("@mName", inRequest.Data.ModelName);
                p.Add("@mkID", inRequest.Data.MakeID.ToString());
                p.Add("@chID", inRequest.Data.ChassisID.ToString());
                p.Add("@dtID", inRequest.Data.DrivetrainID.ToString());
                p.Add("@trim", inRequest.Data.Trim);

                cn.Execute("dbo.UpdateModel", p, commandType: CommandType.StoredProcedure);
            }
            result.Data = inRequest.Data;
            return result;
        }
    }
}