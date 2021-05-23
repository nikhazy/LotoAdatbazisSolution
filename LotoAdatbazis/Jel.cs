using iTextSharp.awt.geom;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoAdatbazis
{
    class Jel
    {
        public int X { get; set; }
        public int Y { get; set; }
        public System.Drawing.Rectangle BefoglaloMezo { get; set; }
        public bool Elsodleges { get; set; } //Elsődleges piros, másodlagos sárga
        public Jel(int x, int width, int y, int height, bool elsodleges)
        {
            X = x;
            Y = y;
            BefoglaloMezo = new System.Drawing.Rectangle(x,y,width,height);
            Elsodleges = elsodleges;
        }
    }
}
