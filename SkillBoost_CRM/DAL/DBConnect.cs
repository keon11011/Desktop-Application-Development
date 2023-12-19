using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        private string connString = "Data Source=PEPO-PC;Initial Catalog=SkillBoost;Integrated Security=True";
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