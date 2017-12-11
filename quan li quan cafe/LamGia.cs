using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class LamGia
    {
        public BangGia BANGGIA { get; set; }
        public ThucUong THUCUONG { get; set; }

        public LamGia(BangGia BANGGIA, ThucUong THUCUONG)
        {
            this.BANGGIA = BANGGIA;
            this.THUCUONG = THUCUONG;
        }
        public LamGia(LamGia LAMGIA)
        {
            this.BANGGIA = LAMGIA.BANGGIA;
            this.THUCUONG = LAMGIA.THUCUONG;
        }
    }
}
