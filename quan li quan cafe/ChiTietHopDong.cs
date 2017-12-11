using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class ChiTietHopDong
    {
        public HoaDon HOADON { get; set; }
        public ThucUong THUCUONG { get; set; }
        public ChiTietHopDong(HoaDon HOADON, ThucUong THUCUONG)
        {
            this.HOADON = HOADON;
            this.THUCUONG = THUCUONG;
        }
        public ChiTietHopDong(ChiTietHopDong CHI_TIET_HOP_DONG)
        {
            this.HOADON = CHI_TIET_HOP_DONG.HOADON;
            this.THUCUONG = CHI_TIET_HOP_DONG.THUCUONG;
        }
    
    }
}
