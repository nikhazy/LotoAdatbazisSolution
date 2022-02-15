using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LotoAdatbazis
{
    class JelTerkeprol
    {
        public Rectangle Area;
        public int FirstY { get; set; }
        public List<int> Yvalues = new List<int>();
        public List<int> Xvalues = new List<int>();
        public List<Point> Points = new List<Point>();
        public void CreateArea()
        {
            Area = new Rectangle(new Point(Xvalues.Min(), Yvalues.Min()), new Size(Xvalues.Max() - Xvalues.Min(), Yvalues.Max() - Yvalues.Min()));
        }
    }
}
