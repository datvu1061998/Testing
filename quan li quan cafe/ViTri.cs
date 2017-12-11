using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quang_Ly_He_Thong_Cua_Hang_TheCoffeeHouse
{
    public class ViTri
    {
        public int maViTri { get; set; }
        public ViTri(int maViTri)
        {
            this.maViTri = maViTri;
        }
        public ViTri(ViTri vitri)
        {
            this.maViTri = vitri.maViTri;
        }
    }
}
