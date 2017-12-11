using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class HoaDonMuaVe
    {
        public uint soHoaDonMuaVe { get; set; }
        public Khach KHACH { get; set; }
        public uint SoTien { get; set; }
        public HoaDonMuaVe(uint soHoaDonMuaVe, Khach KHACH, uint SoTien)
        {
            this.soHoaDonMuaVe = soHoaDonMuaVe;
            this.KHACH = KHACH;
            this.SoTien = SoTien;
        }
        public HoaDonMuaVe(HoaDonMuaVe HOADONMUAVE)
        {
            this.soHoaDonMuaVe = HOADONMUAVE.soHoaDonMuaVe;
            this.KHACH = HOADONMUAVE.KHACH;
            this.SoTien = HOADONMUAVE.SoTien;
        }
    }
}
