using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        private string connString = "Data Source=VIS-LAPTOP;Initial Catalog=SkillBoost;Integrated Security=True;Encrypt=False";
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