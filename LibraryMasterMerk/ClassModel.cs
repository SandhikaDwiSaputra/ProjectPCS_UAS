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

        public static List<MasterModel> getByModelDesc(String code)
        {
            List<MasterModel> modelList = new List<MasterModel>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement =
                "SELECT MODEL_ID, DESCRIPTION " +
                "FROM m_model " +
                "where DESCRIPTION like '%" + code.ToLower() + "%'";
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

        //
        public static List<MasterModel> getByModelID(int id)
        {
            List<MasterModel> modelList = new List<MasterModel>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement =
                "SELECT MODEL_ID, DESCRIPTION " +
                "FROM m_model " +
                "where MODEL_ID = " + id;
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

        //update
        public static bool updateModel(int id, string desc)
        {
            List<MasterModel> modelList = new List<MasterModel>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string updateStatement =
                "UPDATE m_model SET DESCRIPTION = '" + desc + "' WHERE MODEL_ID =" + id;
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        //Delete
        public static bool deleteModel(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string deleteStatement =
                "DELETE FROM m_model WHERE MODEL_ID=" + id;
            SqlCommand updateCommand = new SqlCommand(deleteStatement, connection);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<MasterModel> Tambah(String desc)
        {
            List<MasterModel> modelList = new List<MasterModel>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement = "INSERT INTO m_model VALUES('" + desc + "')";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(selectStatement, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
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
