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
    public class DAL_Lead: DBConnect
    {
        public void SelectLead(ref DTO_Lead dTO_Lead)
        {
            try
            {
                conn.Open();
                string cmdText = "select * from Lead where MaLead = 'LEA001'";
                SqlDataAdapter da = new SqlDataAdapter(cmdText, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                da.Dispose();
                dTO_Lead.HoTenLead = dt.Rows[0][1].ToString();
                dTO_Lead.GioiTinhLead = dt.Rows[0][2].ToString();
                dTO_Lead.NgaySinhLead = (DateTime)dt.Rows[0][3];
                dTO_Lead.SoDienThoaiLead = dt.Rows[0][4].ToString();
                dTO_Lead.EmailLead = dt.Rows[0][5].ToString();
                dTO_Lead.MaNgheNghiep = dt.Rows[0][6].ToString();
                dTO_Lead.TenNgheNghiep = dt.Rows[0][7].ToString();
                dTO_Lead.MaNVPhuTrachLead = dt.Rows[0][8].ToString();
                dTO_Lead.TenNVPhuTrachLead = dt.Rows[0][9].ToString();
                dTO_Lead.TrangThaiLead = dt.Rows[0][10].ToString();
                dTO_Lead.LyDoTrangThaiLead = dt.Rows[0][11].ToString();
                dTO_Lead.NguonLead = dt.Rows[0][12].ToString();
                dTO_Lead.GhiChuLead = dt.Rows[0][13].ToString();
                dTO_Lead.LeadTuKhachHangCu = dt.Rows[0][14].ToString();
                dTO_Lead.TaoVaoLuc = (DateTime)dt.Rows[0][15];
                dTO_Lead.TaoBoi = dt.Rows[0][16].ToString();
                dTO_Lead.ChinhSuaLanCuoiVaoLuc = (DateTime)dt.Rows[0][17];
                dTO_Lead.ChinhSuaLanCuoiBoi = dt.Rows[0][18].ToString();
            }
            catch (Exception ex)
            {
               /* return null; */
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
