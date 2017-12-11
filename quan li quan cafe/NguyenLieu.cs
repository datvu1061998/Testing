using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class NguyenLieu
    {
        public uint maNguyenLieu { get; set; }
        public string tenNguyenLieu { get; set; }
        public LoaiNguyenLieu LOAINGUYENLIEU { get; set; }
        public NguyenLieu(uint maNguyenLieu, string tenNguyenLieu, LoaiNguyenLieu LOAINGUYENLIEU)
        {
            this.maNguyenLieu = maNguyenLieu;
            this.tenNguyenLieu = tenNguyenLieu;
            this.LOAINGUYENLIEU = LOAINGUYENLIEU;
        }
        public NguyenLieu(NguyenLieu NGUYENLIEU)
        {
            this.maNguyenLieu = NGUYENLIEU.maNguyenLieu;
            this.tenNguyenLieu = NGUYENLIEU.tenNguyenLieu;
            this.LOAINGUYENLIEU = NGUYENLIEU.LOAINGUYENLIEU;
        }
    }
}
