using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class Read1VehicleOnIDRepo:ProcessOneRepo<VehicleVM>
    {
        public Read1VehicleOnIDRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<VehicleVM> Process(Request<VehicleVM> inRequest)
        {
            Response<VehicleVM> result = new Response<VehicleVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@vehID", inRequest.Data.VehID.ToString());
                result.Data = (cn.Query<VehicleVM>("LoadOneVehicleOnID", p, commandType: CommandType.StoredProcedure).ToList()).ElementAt(0);
            }
            return result;
        }
    }
}