using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class NhomThucUong
    {
        public uint maNhomThucUong { get; set; }
        public string tenNhomThucUong { get; set; }
        public NhomThucUong(uint maNhomThucUong, string tenNhomThucUong)
        {
            this.maNhomThucUong = maNhomThucUong;
            this.tenNhomThucUong = tenNhomThucUong;
        }
        public NhomThucUong(NhomThucUong NHOMTHUCUONG)
        {
            this.maNhomThucUong = NHOMTHUCUONG.maNhomThucUong;
            this.tenNhomThucUong = NHOMTHUCUONG.tenNhomThucUong;
        }


    }
}
