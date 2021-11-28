using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HK1_2020_2021_1.Models
{
    public class NhanVienModel
    {
        private string maNhanVien;
        private string tenNhanVien;
        private string soDienThoai;
        private int gioiTinh;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string TenNhanVien { get => tenNhanVien; set => tenNhanVien = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public int GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
