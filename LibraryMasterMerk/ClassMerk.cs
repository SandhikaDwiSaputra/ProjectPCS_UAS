using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMasterMerk
{
    public static class ClassMerk
    {
        public static List<MasterMerk> get()
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement =
                "SELECT ID, MERK_DESC " +
                "FROM m_merk ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    MasterMerk mastermerk = new MasterMerk();
                    mastermerk.Id = (int)reader["ID"];
                    
                    mastermerk.Merk_desc = reader["MERK_DESC"].ToString();
                    merkList.Add(mastermerk);
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
            return merkList;
        }

        public static List<MasterMerk> getByMerkCode(String code)
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement =
                "SELECT ID, MERK_DESC " +
                "FROM m_merk " +
                "where merk_code like'%" + code + "%'";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    MasterMerk mastermerk = new MasterMerk();
                    mastermerk.Id = (int)reader["ID"];
                    
                    mastermerk.Merk_desc = reader["MERK_DESC"].ToString();
                    merkList.Add(mastermerk);
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
            return merkList;
        }

        public static List<MasterMerk> getByMerkDesc(String desc)
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement =
                "SELECT ID,   MERK_DESC " +
                "FROM m_merk " +
                "where merk_desc like'%" + desc + "%'";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    MasterMerk mastermerk = new MasterMerk();
                    mastermerk.Id = (int)reader["ID"];
                    
                    mastermerk.Merk_desc = reader["MERK_DESC"].ToString();
                    merkList.Add(mastermerk);
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
            return merkList;
        }

        //
        public static List<MasterMerk> getByMerkID(int id)
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement =
                "SELECT ID,   MERK_DESC " +
                "FROM m_merk " +
                "where ID =" + id;
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
                    MasterMerk mastermerk = new MasterMerk();
                    mastermerk.Id = (int)reader["ID"];

                    mastermerk.Merk_desc = reader["MERK_DESC"].ToString();
                    merkList.Add(mastermerk);
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
            return merkList;
        }

        //update
        public static bool updateMerk(int id, string desc)
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string updateStatement =
                "UPDATE m_merk SET MERK_DESC = '"+ desc + "' WHERE ID =" + id;
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
        public static bool deleteMerk(int id)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string deleteStatement =
                "DELETE FROM m_merk WHERE ID=" + id;
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

        public static List<MasterMerk> Tambah(String desc)
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=Project_UAS;Integrated Security=True");
            string selectStatement = "INSERT INTO m_merk VALUES('"+desc+"')";
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


            return merkList;

        }
    }
}
