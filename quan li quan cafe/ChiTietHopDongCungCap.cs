using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class ChiTietHopDongCungCap
    {
        public HopDongCungCap HOP_DONG_CUNG_CAP { get; set; }
        public NguyenLieu NGUYENLIEU { get; set; }
        public ChiTietHopDongCungCap(HopDongCungCap HOP_DONG_CUNG_CAP, NguyenLieu NGUYENLIEU)
        {
            this.NGUYENLIEU = NGUYENLIEU;
            this.HOP_DONG_CUNG_CAP = HOP_DONG_CUNG_CAP;
        }
        public ChiTietHopDongCungCap(ChiTietHopDongCungCap CHI_TIET_HD_CUNG_CAP)
        {
            this.NGUYENLIEU = CHI_TIET_HD_CUNG_CAP.NGUYENLIEU;
            this.HOP_DONG_CUNG_CAP = CHI_TIET_HD_CUNG_CAP.HOP_DONG_CUNG_CAP;
        }
    }
}
