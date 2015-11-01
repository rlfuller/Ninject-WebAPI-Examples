using System.Data;
using System.Data.SqlClient;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class InsertVehicleRepo : ProcessOneRepo<VehicleVM>
    {
        public InsertVehicleRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<VehicleVM> Process(Request<VehicleVM> inRequest)
        {
            Response<VehicleVM> result = new Response<VehicleVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@VinNo", inRequest.Data.VinNo);
                p.Add("@ModelYear", inRequest.Data.ModelYear.ToString());
                p.Add("@IsNew", inRequest.Data.IsNew.ToString());
                p.Add("@ImageUrl", inRequest.Data.ImageUrl);
                p.Add("@Mileage", inRequest.Data.Mileage.ToString());
                p.Add("@SellingPrice", inRequest.Data.SellingPrice.ToString());
                p.Add("@ModelID", inRequest.Data.ModelID.ToString());
                p.Add("@IsAvailable", inRequest.Data.IsAvailable.ToString());
                p.Add("@VehID", DbType.Int32,direction:ParameterDirection.Output);

                cn.Execute("dbo.InsertVehicle", p, commandType: CommandType.StoredProcedure);

                result.Data.VehID = p.Get<int>("VehID");
            }         
            return result;
        }
    }
}