using System.Data.SqlClient;
using Models;

namespace DataAccess.DapperReaders
{
    public class InsertSalesRequestRepo : ProcessOneRepo<SalesRequest>
    {
        public InsertSalesRequestRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<SalesRequest> Process(Request<SalesRequest> inRequest)
        {
            var result = new Response<SalesRequest>();

            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();

                using (SqlCommand command = new SqlCommand(@"insert into SalesRequest
                                                                   (                                                                   
                                                                    AdID,
                                                                    VehID                                                                                                                                        
                                                                          )
                                                            values      
                                                                   (                                                                    
                                                                    @aID,
                                                                    @vID                                                                     
                                                                           )
                                                            select @SalesRequestID = SCOPE_IDENTITY()", sqlConn))
                {
                    command.Parameters.AddWithValue("aID", inRequest.Data.AdID);
                    command.Parameters.AddWithValue("vID", inRequest.Data.VehID);

                    // create out parameter object and add value to it
                    SqlParameter outParameter = new SqlParameter();
                    outParameter.ParameterName = "@SalesRequestID ";
                    outParameter.SqlDbType = System.Data.SqlDbType.Int;
                    outParameter.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(outParameter);

                    command.ExecuteNonQuery();

                    // retrieve and package out param value... (must unbox as it comes back as type object...)
                    result.Data.SalesRequestID = (int)outParameter.Value;
                }
            }

            return result;
        }
    }
}