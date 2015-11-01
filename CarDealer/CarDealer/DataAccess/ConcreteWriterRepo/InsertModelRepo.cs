using System.Data.SqlClient;
using Models;

namespace DataAccess.DapperReaders
{
    public class InsertModelRepo:ProcessOneRepo<ModelVM>
    {
        public InsertModelRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<ModelVM> Process(Request<ModelVM> inRequest)
        {
            var result = new Response<ModelVM>();

            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();

                using (SqlCommand command = new SqlCommand(@"insert into Model
                                                                   (
                                                                    
                                                                    ModelName,
                                                                    MakeID,
                                                                    ChassisID,
                                                                    DrivetrainID,                                                               
                                                                    Trim                                                                    
                                                                          )
                                                            values      
                                                                   (
                                                                     
                                                                    @mName, 
                                                                    @mkID,
                                                                    @chID,
                                                                    @dtID,                                                               
                                                                    @tr                                                                   
                                                                           )
                                                            select @ModelID = SCOPE_IDENTITY()", sqlConn))
                {
                    command.Parameters.AddWithValue("mName", inRequest.Data.ModelName.ToLower());
                    command.Parameters.AddWithValue("mkID", inRequest.Data.MakeID);
                    command.Parameters.AddWithValue("chID", inRequest.Data.ChassisID);
                    command.Parameters.AddWithValue("dtID", inRequest.Data.DrivetrainID);
                    command.Parameters.AddWithValue("tr", inRequest.Data.Trim);


                    // create out parameter object and add value to it
                    SqlParameter outParameter = new SqlParameter();
                    outParameter.ParameterName = "@ModelID";
                    outParameter.SqlDbType = System.Data.SqlDbType.Int;
                    outParameter.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(outParameter);

                    command.ExecuteNonQuery();

                    // retrieve and package out param value... (must unbox as it comes back as type object...)
                    result.Data.ModelID = (int)outParameter.Value;
                }
            }

            return result;
        }
    }
}