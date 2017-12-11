using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class HopDongCungCap
    {
        public NhaCungCap NHACUNGCAP { get; set; }
        public uint ma_HD_CungCap { get; set; }
        public HopDongCungCap(NhaCungCap NHACUNGCAP, uint ma_HD_CungCap)
        {
            this.NHACUNGCAP = NHACUNGCAP;
            this.ma_HD_CungCap = ma_HD_CungCap;
        }
        public HopDongCungCap(HopDongCungCap HOP_DONG_CUNG_CAP)
        {
            this.NHACUNGCAP = HOP_DONG_CUNG_CAP.NHACUNGCAP;
            this.ma_HD_CungCap = HOP_DONG_CUNG_CAP.ma_HD_CungCap;
        }
    }
}
