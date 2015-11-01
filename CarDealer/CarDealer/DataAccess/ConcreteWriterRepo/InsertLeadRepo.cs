using System.Data.SqlClient;
using Models;

namespace DataAccess.DapperReaders
{
    public class InsertLeadRepo : ProcessOneRepo<Lead>
    {
        public InsertLeadRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<Lead> Process(Request<Lead> inRequest)
        {
            var result = new Response<Lead>();

            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();

                using (SqlCommand command = new SqlCommand(@"insert into Lead
                                                                   (
                                                                    
                                                                   
                                                                    LeadName,
                                                                    LeadPhone,
                                                                    LeadEmail,  
                                                                    BestTimeToCallID,
                                                                    PurchTimeframeID,
                                                                    LeadQuestion,                                                             
                                                                    HowToContactID                                                                    
                                                                          )
                                                            values      
                                                                   (                                                                    
                                                                    @leadName,
                                                                    @leadPhone,
                                                                    @leadEmail,
                                                                    @leadbestTimeToCallID,
                                                                    @leadPurchTimeFrameID,
                                                                    @leadQuestion,
                                                                    @leadHowToContactID                                                                                                                                                                                                     
                                                                           )
                                                            select @LeadID = SCOPE_IDENTITY()", sqlConn))
                {
                    command.Parameters.AddWithValue("leadName", inRequest.Data.LeadName.ToLower());
                    command.Parameters.AddWithValue("leadPhone", inRequest.Data.LeadPhone);
                    command.Parameters.AddWithValue("leadEmail", inRequest.Data.LeadEmail.ToLower());
                    command.Parameters.AddWithValue("leadbestTimeToCallID", inRequest.Data.BestTimeToCallID);
                    command.Parameters.AddWithValue("leadPurchTimeFrameID", inRequest.Data.PurchTimeframeID);
                    command.Parameters.AddWithValue("leadQuestion", inRequest.Data.LeadQuestion);
                    command.Parameters.AddWithValue("leadHowToContactID", inRequest.Data.HowToContactID);


                    // create out parameter object and add value to it
                    SqlParameter outParameter = new SqlParameter();
                    outParameter.ParameterName = "@LeadID";
                    outParameter.SqlDbType = System.Data.SqlDbType.Int;
                    outParameter.Direction = System.Data.ParameterDirection.Output;
                    command.Parameters.Add(outParameter);

                    command.ExecuteNonQuery();

                    // retrieve and package out param value... (must unbox as it comes back as type object...)
                    result.Data.LeadID = (int)outParameter.Value;
                }
            }

            return result;
        }
    }

    public class InsertLeadSalesRequestRepo : ProcessOneRepo<LeadSalesRequest>
    {
        public InsertLeadSalesRequestRepo(string inConnString) : base(inConnString)
        {
        }

        public override Response<LeadSalesRequest> Process(Request<LeadSalesRequest> inRequest)
        {
            var result = new Response<LeadSalesRequest>();

            using (SqlConnection sqlConn = new SqlConnection(_connString))
            {
                sqlConn.Open();

                using (SqlCommand command = new SqlCommand(@"insert into LeadSalesRequest
                                                                   (                                                                                                                                       
                                                                    SalesRequestID,
                                                                    LeadID                                                                                                                                        
                                                                          )
                                                            values      
                                                                   (                                                                    
                                                                    @SrID,
                                                                    @lID                                                                                                                                                                                                                                                                  
                                                                           )", sqlConn))
                {
                    command.Parameters.AddWithValue("SrID", inRequest.Data.SalesRequestID);
                    command.Parameters.AddWithValue("lID", inRequest.Data.LeadID);
                
                    command.ExecuteNonQuery();

                }
            }

            return result;
        }
    }


}