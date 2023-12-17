using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_NgheNghiep
    {
        private string _maNgheNghiep;
        private string _tenNgheNghiep;
        private string _trangThaiNgheNghiep;
        private DateTime _taoVaoLuc;
        private string _taoBoi;
        private DateTime _chinhSuaLanCuoiVaoLuc;
        private string _chinhSuaLanCuoiBoi;

        public string MaNgheNghiep { get => _maNgheNghiep; set => _maNgheNghiep = value; }
        public string TenNgheNghiep { get => _tenNgheNghiep; set => _tenNgheNghiep = value; }
        public string TrangThaiNgheNghiep { get => _trangThaiNgheNghiep; set => _trangThaiNgheNghiep = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }
        public DateTime ChinhSuaLanCuoiVaoLuc { get => _chinhSuaLanCuoiVaoLuc; set => _chinhSuaLanCuoiVaoLuc = value; }
        public string ChinhSuaLanCuoiBoi { get => _chinhSuaLanCuoiBoi; set => _chinhSuaLanCuoiBoi = value; }

        public DTO_NgheNghiep()
        {

        }
        public DTO_NgheNghiep(string maNgheNghiep, string tenNgheNghiep, string trangThaiNgheNghiep, DateTime taoVaoLuc, string taoBoi, DateTime chinhSuaLanCuoiVaoLuc, string chinhSuaLanCuoiBoi)
        {
            MaNgheNghiep = maNgheNghiep;
            TenNgheNghiep = tenNgheNghiep;
            TrangThaiNgheNghiep = trangThaiNgheNghiep;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
            ChinhSuaLanCuoiVaoLuc = chinhSuaLanCuoiVaoLuc;
            ChinhSuaLanCuoiBoi = chinhSuaLanCuoiBoi;
        }
    }
}
