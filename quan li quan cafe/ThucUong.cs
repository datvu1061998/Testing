using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class ThucUong
    {
        public uint maThucUong { get; set; }
        //public uint Gia { get; set; }
        public string tenThucUong { get; set; }
        public NhomThucUong NHOMTHUCUONG { get; set; }
        public ThucUong(uint maThucUong, string tenThucUong, NhomThucUong NHOMTHUCUONG)
        {
            this.maThucUong = maThucUong;
            this.tenThucUong = tenThucUong;
            //this.Gia = Gia;
            this.NHOMTHUCUONG = NHOMTHUCUONG;
        }
        public ThucUong(ThucUong THUCUONG)
        {
            this.maThucUong = THUCUONG.maThucUong;
            this.tenThucUong = THUCUONG.tenThucUong;
            //this.Gia = THUCUONG.Gia;
            this.NHOMTHUCUONG = THUCUONG.NHOMTHUCUONG;
        }
        
    }
}
