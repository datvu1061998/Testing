using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class ChiTietHopDongMuaVe
    {
        public string Ngay { get; set; }
        public HoaDonMuaVe so_HD_MuaVe { get; set; }
        public ThucUong THUCUONG { get; set; }
        public ChiTietHopDongMuaVe(HoaDonMuaVe so_HD_MuaVe, ThucUong THUCUONG, string Ngay)
        {
            this.so_HD_MuaVe = so_HD_MuaVe;
            this.THUCUONG = THUCUONG;
            this.Ngay = Ngay;
        }
        public ChiTietHopDongMuaVe(ChiTietHopDongMuaVe CHI_TIET_HD_MUA_VE)
        {
            this.so_HD_MuaVe = CHI_TIET_HD_MUA_VE.so_HD_MuaVe;
            this.THUCUONG = CHI_TIET_HD_MUA_VE.THUCUONG;
            this.Ngay = CHI_TIET_HD_MUA_VE.Ngay;
        }
    }
}
