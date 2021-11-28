using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HK1_2020_2021_1.Models
{
    public class NV_BT
    {
        private string maNhanVien;
        private string maThietBi;
        private string maCanHo;
        private int lanThu;
        private DateTime ngayBaoTri;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string MaCanHo { get => maCanHo; set => maCanHo = value; }
        public int LanThu { get => lanThu; set => lanThu = value; }
        public DateTime NgayBaoTri { get => ngayBaoTri; set => ngayBaoTri = value; }
    }
}
