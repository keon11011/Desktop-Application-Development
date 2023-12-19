using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        //private string connString = "Data Source=DESKTOP-K5P9KUP;Initial Catalog=SkillBoost;Integrated Security=True";
        // tnha's Connection string
        private string connString = @"Data Source=DICHONG;Initial Catalog=SkillBoost;Integrated Security=True;Encrypt=False";
        protected SqlConnection conn;
        public DBConnect()
        {
            conn = new SqlConnection(connString);
        }
        ~DBConnect()
        {
            if (conn != null)
            {
                conn.Dispose();
            }
            else
            {
                conn = null;
            }
        }
    }
}