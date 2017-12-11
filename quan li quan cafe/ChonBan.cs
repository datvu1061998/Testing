using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class ChonBan
    {
        public Khach KHACH { get; set; }
        public string Ngay { get; set; }
        public string Gio { get; set; }
        public Ban BAN { get; set; }
        public ChonBan(Khach KHACH, string Ngay, string Gio, Ban BAN)
        {
            this.KHACH = KHACH;
            this.Gio = Gio;
            this.Ngay = Ngay;
            this.BAN = BAN;
        }
        public ChonBan(ChonBan CHONBAN)
        {
            this.KHACH = CHONBAN.KHACH;
            this.Gio = CHONBAN.Gio;
            this.Ngay = CHONBAN.Ngay;
            this.BAN = CHONBAN.BAN;
        }
    }
}
