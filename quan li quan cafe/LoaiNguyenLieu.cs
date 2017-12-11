using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class LoaiNguyenLieu
    {
        public uint maLoaiNL { get; set; }
        public string tenLoaiNL { get; set; }
        public LoaiNguyenLieu(uint maLoaiNL, string tenLoaiNL)
        {
            this.maLoaiNL = maLoaiNL;
            this.tenLoaiNL = tenLoaiNL;
        }
        public LoaiNguyenLieu(LoaiNguyenLieu LOAINGUYENLIEU)
        {
            this.maLoaiNL = LOAINGUYENLIEU.maLoaiNL;
            this.tenLoaiNL = LOAINGUYENLIEU.tenLoaiNL;
        }
    }
}
