using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        private string connString = @"Data Source=LAPTOP-L41I5A8P\SQLEXPRESS;Initial Catalog=SkillBoost;Integrated Security=True";
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