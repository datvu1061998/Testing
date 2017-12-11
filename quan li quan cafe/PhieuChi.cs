using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class PhieuChi
    {
        public uint soPhieuChi { get; set; }
        public HopDongCungCap HOP_DONG_CUNG_CAP { get; set; }
        public PhieuChi(uint soPhieuChi, HopDongCungCap HOP_DONG_CUNG_CAP)
        {
            this.soPhieuChi = soPhieuChi;
            this.HOP_DONG_CUNG_CAP = HOP_DONG_CUNG_CAP;
        }
        public PhieuChi(PhieuChi PHIEUCHI)
        {
            this.soPhieuChi = PHIEUCHI.soPhieuChi;
            this.HOP_DONG_CUNG_CAP = PHIEUCHI.HOP_DONG_CUNG_CAP;
        }
    }
}
