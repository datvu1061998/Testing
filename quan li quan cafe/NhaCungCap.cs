using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class NhaCungCap
    {
        public uint maNhaCungCap { get; set; }
        public string tenNhaCungCap { get; set; }
        public NhaCungCap(uint maNhaCungCap, string tenNhaCungCap)
        {
            this.maNhaCungCap = maNhaCungCap;
            this.tenNhaCungCap = tenNhaCungCap;
        }
        public NhaCungCap(NhaCungCap NHACUNGCAP)
        {
            this.maNhaCungCap = NHACUNGCAP.maNhaCungCap;
            this.tenNhaCungCap = NHACUNGCAP.tenNhaCungCap;
        }

    }
}
