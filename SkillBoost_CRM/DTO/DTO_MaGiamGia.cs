using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MaGiamGia
    {
        private string _maGiamGia;
        private string _moTaMaGiamGia;
        private string _phamViApDung;
        private int _phanTramGiamGia;
        private string _trangThaiMaGiamGia;
        private string _maQuyDinhGiamGia;
        private DateTime _taoVaoLuc;
        private string _taoBoi;

        public string maGiamGia { get => _maGiamGia; set => _maGiamGia = value; }
        public string MoTaGiamGia { get => _moTaMaGiamGia; set => _moTaMaGiamGia = value; }
        public string PhamViApDung { get => _phamViApDung; set => _phamViApDung = value; }
        public int PhanTramGiamGia { get => _phanTramGiamGia; set => _phanTramGiamGia = value; }
        public string TrangThaiMaGiamGia { get => _trangThaiMaGiamGia; set => _trangThaiMaGiamGia = value; }
        public string MaQuyDinhGiamGia { get => _maQuyDinhGiamGia; set => _maQuyDinhGiamGia = value; }
        public DateTime TaoVaoLuc { get => _taoVaoLuc; set => _taoVaoLuc = value; }
        public string TaoBoi { get => _taoBoi; set => _taoBoi = value; }

        public DTO_MaGiamGia()
        {

        }
        public DTO_MaGiamGia(string maGiamGia_init, string moTaMaGiamGia, string phamViApDung, int phanTramGiamGia, string trangThaiMaGiamGia, string maQuyDinhGiamGia, DateTime taoVaoLuc, string taoBoi)
        {
            maGiamGia = maGiamGia_init;
            MoTaGiamGia = moTaMaGiamGia;
            PhamViApDung = phamViApDung;
            PhanTramGiamGia = phanTramGiamGia;
            TrangThaiMaGiamGia = trangThaiMaGiamGia;
            MaQuyDinhGiamGia = maQuyDinhGiamGia;
            TaoVaoLuc = taoVaoLuc;
            TaoBoi = taoBoi;
        }
    }
}
