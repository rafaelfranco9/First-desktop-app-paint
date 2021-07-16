using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro.Painter.Figuras
{
    [Serializable]
    public class Linea : Figuras, IMovible
    {
        public const String Nombre = "Linea";

        public Linea(int x, int y)
        {
            this.nombre = "Linea";
            this.Ancho = 50;
            this.Alto = 0;
            this.ColorRelleno = Color.Black;
            this.ColorTrazo = Color.Black;
            this.Posicion.X = x;
            this.Posicion.Y = y;
            this.AnchoTrazo = 10;
        }

        public override void Dibujarse(Graphics g, int X, int Y)
        {
            this.Posicion.X = X;
            this.Posicion.Y = Y;
            Brush myBrush = new SolidBrush(this.ColorTrazo);
            g.DrawLine(new Pen(myBrush, this.AnchoTrazo), X, Y, X + this.Ancho, Y + this.Alto);
            

        }

        public void Moverse(double x, double y)
        {



        }


        //---GETTERS AND SETTERS---//
        public override String GetNombre()
        {
            return this.nombre;
        }
        public override void SetAncho(float a)
        {
            this.Ancho = a;
        }
        public override float GetAncho()
        {
            return this.Ancho;
        }
        public override void SetAlto(float a)
        {
            this.Alto = a;
        }
        public override float GetAlto()
        {
            return this.Alto;
        }
        public override void SetPosicion(Point p)
        {
            this.Posicion = p;
        }
        public override Point GetPosicion()
        {
            return this.Posicion;
        }
        public override void SetColorRelleno(Color c)
        {
            this.ColorRelleno = c;
        }
        public override Color GetColorRelleno()
        {
            return this.ColorRelleno;
        }
        public override void SetColorTrazo(Color c)
        {
            this.ColorTrazo = c;
        }
        public override Color GetColorTrazo()
        {
            return this.ColorTrazo;
        }
        public int GetAnchoTrazo()
        {
            return this.AnchoTrazo;
        }
        public void SetAnchoTrazo(int s)
        {
            this.AnchoTrazo = s;
        }
        public override Bitmap getIconSeleted()
        {
            return Properties.Resources.lineSelected;
        }


        //Static Methods//
        public static void Seleccionado(Control Icono, Control IconoEdicion, Label TituloFigura)
        {
            Icono.BackgroundImage = Properties.Resources.lineSelected;
            IconoEdicion.BackgroundImage = Properties.Resources.lineSelected;
            TituloFigura.Text = Linea.Nombre;

        }
        public static void Deseleccionado(Control Icono)
        {
            Icono.BackgroundImage = Properties.Resources.line;
        }
    }
}
