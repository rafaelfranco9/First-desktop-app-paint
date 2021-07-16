using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pro.Painter
{
    public class PaintBox
    {
        private Graphics PaintArea;

        public PaintBox()
        {
        }

        public void Refresh(List<Figuras.Figuras> listaFiguras,PictureBox g)
        {
            PaintArea = g.CreateGraphics();
            PaintArea.Clear(Color.White);
            foreach(Figuras.Figuras figura in listaFiguras)
            {
                figura.Dibujarse(this.PaintArea, figura.Posicion.X, figura.Posicion.Y);
            }
            PaintArea.Dispose();
            

        }

        public Graphics getPaintArea(PictureBox g)
        {
            this.PaintArea = g.CreateGraphics();
            return PaintArea;
        }
        public void DisposePaintArea()
        {
            this.PaintArea.Dispose();
        }

    }
}
