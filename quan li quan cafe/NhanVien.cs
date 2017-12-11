using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class NhanVien
    {
        public string tenNhanVien { get; set; }
        public int maNhanVien { get; set; }
        public bool QuanLy { get; set; }
        public NhanVien(string tenNhanVien, int maNhanVien)
        {
            this.tenNhanVien = tenNhanVien;
            this.maNhanVien = maNhanVien;
            this.QuanLy = false;
        }
        public NhanVien(string tenNhanVien, int maNhanVien, bool QuanLy)
        {
            this.tenNhanVien = tenNhanVien;
            this.maNhanVien = maNhanVien;
            this.QuanLy = QuanLy;
        }
        public NhanVien(NhanVien NHANVIEN)
        {
            this.tenNhanVien = NHANVIEN.tenNhanVien;
            this.maNhanVien = NHANVIEN.maNhanVien;
            this.QuanLy = NHANVIEN.QuanLy;
        }
        
    }
}
