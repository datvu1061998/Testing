using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class Ban
    {
        public int maBan { get; set; }
        public string tenBan { get; set; }
        public ViTri VITRI { get; set; }
        public Ban(int maBan,string tenBan, ViTri VITRI)
        {
            this.maBan = maBan;
            this.VITRI = VITRI;
            this.tenBan = tenBan;
        }
        public Ban(Ban BAN)
        {
            this.maBan = BAN.maBan;
            this.VITRI = BAN.VITRI;
            this.tenBan = BAN.tenBan;
        }
    }
}
