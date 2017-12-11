using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class BangGia
    {
        public string Ngay { get; set; }
        public ThucUong THUCUONG { get; set; }
        public uint Gia { get; set; }
        public BangGia(string Ngay, ThucUong THUCUONG, uint Gia)
        {
            
            this.THUCUONG = THUCUONG;
            this.Ngay = Ngay;
            this.Gia = Gia;
        }
        public BangGia(BangGia BANGGIA)
        {
            this.THUCUONG = BANGGIA.THUCUONG;
            this.Ngay = BANGGIA.Ngay;
            this.Gia = BANGGIA.Gia;
        }
    }
}
