using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class HoaDon
    {
        public int soHoaDon { get; set; }
        public LichTrucNhanVien LICH_TRUC_NHAN_VIEN { get; set; }
        public ChonBan CHONBAN { get; set; }
        public uint SoTien { get; set; }
        public HoaDon(int soHoaDon, ChonBan CHONBAN, LichTrucNhanVien LICH_TRUC_NHAN_VIEN, uint SoTien)
        {
            this.soHoaDon = soHoaDon;
            this.LICH_TRUC_NHAN_VIEN = LICH_TRUC_NHAN_VIEN;
            this.CHONBAN = CHONBAN;
            this.SoTien = SoTien;
        }
        public HoaDon(HoaDon HOADON)
        {
            this.soHoaDon = HOADON.soHoaDon;
            this.LICH_TRUC_NHAN_VIEN = HOADON.LICH_TRUC_NHAN_VIEN;
            this.CHONBAN = HOADON.CHONBAN;
            this.SoTien = HOADON.SoTien;
        }
    }
}
