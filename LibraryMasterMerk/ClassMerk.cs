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
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
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
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
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
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
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
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
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
        public static bool updateMerk(MasterMerk oldMerk, MasterMerk newMerk)
        {
            List<MasterMerk> merkList = new List<MasterMerk>();
            SqlConnection connection = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=UAS;Integrated Security=True");
            string updateStatement =
                "UPDATE m_merk SET" +
                "MERK_DESC = @newDesc" +
                "WHERE ID = @oldID";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@newDesc", newMerk.Merk_desc);
            updateCommand.Parameters.AddWithValue("@oldID", oldMerk.Id);
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
    }
}
