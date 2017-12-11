using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class LoaiKhach
    {
        public int maLoaiKhach { get; set; }
        public string tenLoaiKhach { get; set; }
        public LoaiKhach(int maLoaiKhach, string tenLoaiKhach)
        {
            this.maLoaiKhach = maLoaiKhach;
            this.tenLoaiKhach = tenLoaiKhach;
        }
        public LoaiKhach(LoaiKhach Loaikhach)
        {
            if (Loaikhach != null)
            {
                this.maLoaiKhach = Loaikhach.maLoaiKhach;
                this.tenLoaiKhach = Loaikhach.tenLoaiKhach;
            }
        }
    }
}
