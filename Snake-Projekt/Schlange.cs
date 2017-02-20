using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace Snake_Projekt
{
    class Schlange
    {
        public Graphics g;
         public Schlange()
        {
          
        }
        public void Zeichnen(int counter,PictureBox _pb,)
        {
            g = _pb.CreateGraphics();
            g.FillRectangle(Brushes.Black, x, y, 10, 10);
        }
    }
}
