using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMasterMerk
{
    public static class ClassModel
    {
        public static List<MasterModel> get()
        {
            List<MasterModel> modelList = new List<MasterModel>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement =
                "SELECT MODEL_ID, DESCRIPTION " +
                "FROM m_model ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    MasterModel mastermodel = new MasterModel();
                    mastermodel.Id = (int)reader[0];
                    mastermodel.Model_desc = reader[1].ToString();
                    modelList.Add(mastermodel);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return modelList;
        }
    }
}
