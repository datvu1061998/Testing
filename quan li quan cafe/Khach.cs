using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class Khach
    {
        public int maKhach { get; set; }
        public LoaiKhach LOAIKHACH { get; set; }
        public Khach(int maKhach, LoaiKhach LOAIKHACH)
        {
            this.maKhach = maKhach;
            this.LOAIKHACH = LOAIKHACH;
        }
        public Khach(Khach khach)
        {
            if (khach != null)
            {
                this.maKhach = khach.maKhach;
                this.LOAIKHACH = khach.LOAIKHACH;
            }
        }
    }
}
