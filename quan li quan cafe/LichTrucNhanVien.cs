using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class LichTrucNhanVien
    {
        public NhanVien NHANVIEN { get; set; }
        public string Ngay { get; set; }
        public uint Ca { get; set; }
        public ViTri VITRI { get; set; }
        public LichTrucNhanVien(NhanVien NHANVIEN, string Ngay, uint Ca, ViTri VITRI)
        {
            this.NHANVIEN = NHANVIEN;
            this.Ngay = Ngay; ;
            this.Ca = Ca;
            this.VITRI = VITRI;
        }
        public LichTrucNhanVien(LichTrucNhanVien LICHTRUCNHANVIEN)
        {
            this.NHANVIEN = LICHTRUCNHANVIEN.NHANVIEN;
            this.Ngay = LICHTRUCNHANVIEN.Ngay;
            this.Ca = LICHTRUCNHANVIEN.Ca;
            this.VITRI = LICHTRUCNHANVIEN.VITRI;
        }
    }
}
