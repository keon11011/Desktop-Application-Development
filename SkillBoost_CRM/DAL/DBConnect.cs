using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        private string connString = "Data Source=DESKTOP-K5P9KUP;Initial Catalog=QLBH;Integrated Security=True";
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