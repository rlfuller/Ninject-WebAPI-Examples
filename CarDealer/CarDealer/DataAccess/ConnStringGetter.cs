using System;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ConnStringGetter
    {

        private static string _connectionString;

        public static string GetConnString
        {
            get
            {
                if (string.IsNullOrEmpty(_connectionString))
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
                }

                return _connectionString;
            }
        }
    }
}
