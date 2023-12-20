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
    public class DAL_YCTVKhachHang:DBConnect
    {
        public bool InsertYCTVKhachHang(DTO_YCTVKhachHang kh)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Insert into YeuCauTuVan(TenLeadYeuCau,NgaySinhLeadYeuCau , SDTLeadYeuCau, EmailLeadYeuCau, GhiChuYCTV) " +
                                                    "values (@TenLeadYeuCau,@NgaySinhLeadYeuCau , @SDTLeadYeuCau,@EmailLeadYeuCau, @GhiChuYCTV)", conn);

                cmd.Parameters.Add("@TenLeadYeuCau", SqlDbType.NVarChar);
                cmd.Parameters["@TenLeadYeuCau"].Value = kh.TenLeadYeuCau;
                cmd.Parameters.Add("@NgaySinhLeadYeuCau", SqlDbType.DateTime);
                cmd.Parameters["@NgaySinhLeadYeuCau"].Value = kh.NgaySinhLeadYeuCau;
                cmd.Parameters.Add("@SDTLeadYeuCau", SqlDbType.NVarChar);
                cmd.Parameters["@SDTLeadYeuCau"].Value = kh.SdtLeadYeuCau;
                cmd.Parameters.Add("@EmailLeadYeuCau", SqlDbType.NVarChar);
                cmd.Parameters["@EmailLeadYeuCau"].Value = kh.EmailLeadYeuCau;
                cmd.Parameters.Add("@GhiChuYCTV", SqlDbType.NVarChar);
                cmd.Parameters["@GhiChuYCTV"].Value = kh.GhiChuYCTV;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    cmd.Dispose();
                    return true;
                }
                cmd.Dispose();
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
