using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class PhaChe
    {
        public NguyenLieu NGUYENLIEU { get; set; }
        public ThucUong THUCUONG { get; set; }
        public PhaChe(NguyenLieu NGUYENLIEU, ThucUong THUCUONG)
        {
            this.NGUYENLIEU = NGUYENLIEU;
            this.THUCUONG = THUCUONG;
        }
        public PhaChe(PhaChe PHACHE)
        {
            this.NGUYENLIEU = PHACHE.NGUYENLIEU;
            this.THUCUONG = PHACHE.THUCUONG;
        }
    }
}
