using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_YeuCauTuVan: DBConnect
    {
        public DataTable SelectYCTV()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Select YeuCauTuVan.MaTuVan as 'Mã Tư Vấn',YeuCauTuVan.TenLeadYeuCau as 'Tên Lead', YeuCauTuVan.TaoVaoLuc as 'Thời gian ghi nhận yêu cầu', YeuCauTuVan.TrangThaiYCTV as 'Trạng thái' from YeuCauTuVan"
                                                , conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                dt.Columns.Add("Tên Khóa Học");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SqlCommand cmd1 = new SqlCommand("SELECT * FROM ChiTietKhoaHocThuocYeuCauTuVan WHERE MaTuVan = \'" + dt.Rows[i][0] + "\'", conn);

                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                    da1.Fill(dt2);
                    da1.Dispose();
                    string s = dt2.Rows[0][2].ToString();
                    for (int j = 1; j < dt2.Rows.Count; j++)
                    {
                        s = s + ", " + dt2.Rows[j][2].ToString();

                    }
                    dt.Rows[i][4] = s;
                }

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable TimYCTV(string s)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select YeuCauTuVan.TenLeadYeuCau as 'Tên Lead', YeuCauTuVan.TaoVaoLuc as 'Thời gian ghi nhận yêu cầu', YeuCauTuVan.TrangThaiYCTV as 'Trạng thái' "
                                                + "from YeuCauTuVan where TenLeadYeuCau like N'%" + s + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable LocYCTV(string s)
        {

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select YeuCauTuVan.TenLeadYeuCau as 'Tên Lead', YeuCauTuVan.TaoVaoLuc as 'Thời gian ghi nhận yêu cầu', YeuCauTuVan.TrangThaiYCTV as 'Trạng thái' "
                                                + "from YeuCauTuVan where TrangThaiYCTV like N'%" + s + "%'", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();

                return dt;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool InsertYCTV()

    }
}
