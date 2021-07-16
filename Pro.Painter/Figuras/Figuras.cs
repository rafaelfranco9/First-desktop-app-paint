using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pro.Painter.Figuras
{
    [Serializable]
    public abstract class Figuras
    {
        
        public Point Posicion;
        public float Ancho;
        public float Alto;
        public int AnchoTrazo;
        public Color ColorTrazo;
        public Color ColorRelleno;
        public bool Seleccionar;
        public String nombre;


        public abstract String GetNombre();
        public abstract void Dibujarse(Graphics g,int X,int Y);
        public abstract void SetAncho(float a);
        public abstract float GetAncho();
        public abstract void SetAlto(float a);
        public abstract float GetAlto();
        public abstract void SetPosicion(Point p);
        public abstract Point GetPosicion();
        public abstract void SetColorRelleno(Color c);
        public abstract Color GetColorRelleno();
        public abstract void SetColorTrazo(Color c);
        public abstract Color GetColorTrazo();
        public abstract Bitmap getIconSeleted();

        //public abstract void SetAnchoTrazo(int c);
        //public abstract int GetAnchoTrazo();


    }

}
