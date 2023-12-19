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
    public class DAL_YeuCauTuVan : DBConnect
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

        public bool InsertYCTVNew(DTO_YeuCauTuVan tt_yctv)
        {

            try
            { 
                conn.Open();
                SqlCommand cmdYCTV = new SqlCommand("Insert into YeuCauTuVan (TenLeadYeuCau,NgaySinhLeadYeuCau,EmailLeadYeuCau,SDTLeadYeuCau,GhiChuYCTV,TrangThaiYCTV,TaoVaoLuc,TaoBoiLead) " +
                    "values " +
                    "(@TenLeadYeuCau, @NgaySinhLeadYeuCau, @EmailLeadYeuCau, @SDTLeadYeuCau, @GhiChuYCTV, @TrangThaiYCTV, @TaoVaoLuc, @TaoBoiLead)", conn);

                cmdYCTV.Parameters.Add("@TenLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TenLeadYeuCau"].Value = tt_yctv.TenLeadYeuCau;

                cmdYCTV.Parameters.Add("@NgaySinhLeadYeuCau", SqlDbType.DateTime);
                cmdYCTV.Parameters["@NgaySinhLeadYeuCau"].Value = tt_yctv.NgaySinhLeadYeuCau;

                cmdYCTV.Parameters.Add("@EmailLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@EmailLeadYeuCau"].Value = tt_yctv.EmailLeadYeuCau;

                cmdYCTV.Parameters.Add("@SDTLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@SDTLeadYeuCau"].Value = tt_yctv.SDTLeadYeuCau;

                cmdYCTV.Parameters.Add("@GhiChuYCTV", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@GhiChuYCTV"].Value = tt_yctv.GhiChuYCTV;

                cmdYCTV.Parameters.Add("@TrangThaiYCTV", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TrangThaiYCTV"].Value = tt_yctv.TrangThaiYCTV;

                cmdYCTV.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmdYCTV.Parameters["@TaoVaoLuc"].Value = tt_yctv.TaoVaoLuc;

                cmdYCTV.Parameters.Add("@TaoBoiLead", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TaoBoiLead"].Value = tt_yctv.TaoBoiLead;

                //SqlCommand cmdChiTietKhoaHoc = new SqlCommand("Insert Into ChiTietKhoaHocThuocYeuCauTuVan values (@MaTuVan, @MaKhoaHoc, @TenKhoaHoc, @GiangVien,@GiaTien");

                //cmdYCTV.Parameters.Add("@MaTuVan", SqlDbType.NVarChar);
                //cmdYCTV.Parameters["@MaTuVan"].Value = tt_yctv.MaTuVan;

                //cmdYCTV.Parameters.Add("@MaKhoaHoc", SqlDbType.NVarChar);
                //cmdYCTV.Parameters["@MaKhoaHoc"].Value = tt_yctv.MaKhoaHoc;

                //cmdYCTV.Parameters.Add("@TenKhoaHoc", SqlDbType.NVarChar);
                //cmdYCTV.Parameters["@TenKhoaHoc"].Value = tt_yctv.TenKhoaHoc;

                //cmdYCTV.Parameters.Add("@GiangVien", SqlDbType.NVarChar);
                //cmdYCTV.Parameters["@GiangVien"].Value = tt_yctv.GiangVien;

                //cmdYCTV.Parameters.Add("@GiaTien", SqlDbType.NVarChar);
                //cmdYCTV.Parameters["@GiaTien"].Value = tt_yctv.GiaTien;

                if (cmdYCTV.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;

                
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool InsertYCTVOld(DTO_YeuCauTuVan tt_yctv)
        {
            try
            {
                conn.Open();
                SqlCommand cmdYCTV = new SqlCommand("Insert into YeuCauTuVan (TenLeadYeuCau,NgaySinhLeadYeuCau,EmailLeadYeuCau,SDTLeadYeuCau,GhiChuYCTV,TrangThaiYCTV,TaoVaoLuc,TaoBoiLead) " +
                    "values " +
                    "(@TenLeadYeuCau, @NgaySinhLeadYeuCau, @EmailLeadYeuCau, @SDTLeadYeuCau, @GhiChuYCTV, @TrangThaiYCTV, @TaoVaoLuc, @TaoBoiLead)", conn);

                cmdYCTV.Parameters.Add("@TenLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TenLeadYeuCau"].Value = tt_yctv.TenLeadYeuCau;

                cmdYCTV.Parameters.Add("@NgaySinhLeadYeuCau", SqlDbType.DateTime);
                cmdYCTV.Parameters["@NgaySinhLeadYeuCau"].Value = tt_yctv.NgaySinhLeadYeuCau;

                cmdYCTV.Parameters.Add("@EmailLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@EmailLeadYeuCau"].Value = tt_yctv.EmailLeadYeuCau;

                cmdYCTV.Parameters.Add("@SDTLeadYeuCau", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@SDTLeadYeuCau"].Value = tt_yctv.SDTLeadYeuCau;

                cmdYCTV.Parameters.Add("@GhiChuYCTV", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@GhiChuYCTV"].Value = tt_yctv.GhiChuYCTV;

                cmdYCTV.Parameters.Add("@TrangThaiYCTV", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TrangThaiYCTV"].Value = tt_yctv.TrangThaiYCTV;

                cmdYCTV.Parameters.Add("@TaoVaoLuc", SqlDbType.DateTime);
                cmdYCTV.Parameters["@TaoVaoLuc"].Value = tt_yctv.TaoVaoLuc;

                cmdYCTV.Parameters.Add("@TaoBoiLead", SqlDbType.NVarChar);
                cmdYCTV.Parameters["@TaoBoiLead"].Value = tt_yctv.TaoBoiLead;

                if (cmdYCTV.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
