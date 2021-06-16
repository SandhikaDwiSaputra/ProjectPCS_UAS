using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TransData
{
    public class TransDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source =localhost\\SQLExpress; Initial Catalog = Project_UAS; " +
                "User ID = sa; Password = 28Desember";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
