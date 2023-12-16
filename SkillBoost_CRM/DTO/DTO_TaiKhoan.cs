using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TaiKhoan
    {
        private string _maTK;
        private string _emailTK;
        private string _matKhauTK;
        private string _maHashTK;
        private string _maSaltTK;
        private string _trangThaiTK;
        private string _maNV;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaTK { get => _maTK; set => _maTK = value; }
        public string EmailTK { get => _emailTK; set => _emailTK = value; }
        public string MatKhauTK { get => _matKhauTK; set => _matKhauTK = value; }
        public string MaHashTK { get => _maHashTK; set => _maHashTK = value; }
        public string MaSaltTK { get => _maSaltTK; set => _maSaltTK = value; }
        public string TrangThaiTK { get => _trangThaiTK; set => _trangThaiTK = value; }
        public string MaNV { get => _maNV; set => _maNV = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }

        public DTO_TaiKhoan()
        {

        }
        public DTO_TaiKhoan(string maTK, string emailTK, string matKhauTK, string maHashTK, string maSaltTK, string trangThaiTK, string maNV, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
        {
            MaTK = maTK;
            EmailTK = emailTK;
            MatKhauTK = matKhauTK;
            MaHashTK = maHashTK;
            MaSaltTK = maSaltTK;
            TrangThaiTK = trangThaiTK;
            MaNV = maNV;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }
    }
}
