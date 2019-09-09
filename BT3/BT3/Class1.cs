using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class KhachHang
    {
        private String hoTen;
        private long giaDuThuyen;
        private String doUong;
        private String soLuongDoUong;

        public KhachHang(){}

        public KhachHang(string hoTen, long giaDuThuyen, string doUong, string soLuongDoUong)
        {
            this.hoTen = hoTen;
            this.giaDuThuyen = giaDuThuyen;
            this.doUong = doUong;
            this.soLuongDoUong = soLuongDoUong;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public long GiaDuThuyen { get => giaDuThuyen; set => giaDuThuyen = value; }
        public string DoUong { get => doUong; set => doUong = value; }
        public string SoLuongDoUong { get => soLuongDoUong; set => soLuongDoUong = value; }

        public long tinhTienDoUong()
        {
            return 0;
        }

        public long tongTien()
        {
            return tinhTienDoUong() + giaDuThuyen;
        }

    }
}
