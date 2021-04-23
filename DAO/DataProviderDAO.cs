using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class DataProviderDAO
    {
        // Mantor.
        //public static string StrConnect = @"Data Source=DESKTOP-BKVBUBB\SQLEXPRESS;Initial Catalog=ManageAppleStore;Integrated Security=True";

         //Huy
        public static string StrConnect = @"Data Source=LAPTOP-FUAJRQ65;Initial Catalog=ManageAppleStore;Integrated Security=True";

        public static SqlConnection OpenConnect()
        {
            SqlConnection Conn = new SqlConnection(StrConnect);
            Conn.Open();
            return Conn;
        }
       
        public static SqlDataReader SelectData(string StrSelect, SqlConnection Conn)
        {
            SqlCommand CMD = new SqlCommand(StrSelect, Conn);
            SqlDataReader SDR = CMD.ExecuteReader();
            return SDR;
        }

        public static SqlDataReader SelectData(string StrSelect,SqlParameter[] SqlParameter, SqlConnection Conn)
        {
            SqlCommand CMD = new SqlCommand(StrSelect, Conn);
            CMD.Parameters.AddRange(SqlParameter);
            SqlDataReader SDR = CMD.ExecuteReader();
            return SDR;
        }
        public static bool InUpDel(string Str, SqlConnection Conn)
        {
            SqlCommand CMD = new SqlCommand(Str, Conn);
            int Result = CMD.ExecuteNonQuery();
            return (Result != 0);
        }

        public static bool exeCMD(string strTruyVan, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, conn);
            int iKq = cmd.ExecuteNonQuery();
            return (iKq != 0);
        }
        public static bool exeCMD(string strTruyVan,SqlParameter[] SqlParameter,SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(strTruyVan, conn);
            cmd.Parameters.AddRange(SqlParameter);
            int iKq = cmd.ExecuteNonQuery();
            return (iKq != 0);
        }
    }
}
