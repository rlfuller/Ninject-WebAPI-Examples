using System.Data;
using System.Data.SqlClient;
using Dapper;
using Models;

namespace DataAccess.DapperReaders
{
    public class UpdateVehicleRepo : ProcessOneRepo<VehicleVM>
    {
        public UpdateVehicleRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<VehicleVM> Process(Request<VehicleVM> inRequest)
        {
            Response<VehicleVM> result = new Response<VehicleVM>();

            using (SqlConnection cn = new SqlConnection(_connString))
            {
                var p = new DynamicParameters();
                p.Add("@vID", inRequest.Data.VehID);
                p.Add("@vnNo", inRequest.Data.VinNo);
                p.Add("@mdlYear", inRequest.Data.ModelYear.ToString());
                p.Add("@isItNew", inRequest.Data.IsNew.ToString());
                p.Add("@imgUrl", inRequest.Data.ImageUrl);
                p.Add("@mi", inRequest.Data.Mileage.ToString());
                p.Add("@price", inRequest.Data.SellingPrice.ToString());
                p.Add("@isDel", inRequest.Data.IsDeleted.ToString());
                p.Add("@modelID", inRequest.Data.ModelID.ToString());
                p.Add("@isAvail", inRequest.Data.IsAvailable.ToString());
              
                cn.Execute("dbo.UpdateVehicle", p, commandType: CommandType.StoredProcedure);
            }
            return result;
        }
    }
}