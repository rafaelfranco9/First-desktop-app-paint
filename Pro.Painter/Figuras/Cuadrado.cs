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
    public class Cuadrado : Figuras, IMovible
    {

        public const String Nombre = "Cuadrado";

        public Cuadrado(int x, int y)
        {
            this.nombre = "Cuadrado";
            this.Ancho = 50;
            this.Alto = 50;
            this.ColorRelleno = Color.Black;
            this.ColorTrazo = Color.Black;
            this.Posicion.X = x;
            this.Posicion.Y = y;
        }

        public override void Dibujarse(Graphics g, int X, int Y)
        {
            this.Posicion.X = X;
            this.Posicion.Y = Y;
            Brush myBrush = new SolidBrush(this.ColorRelleno);
            g.FillRectangle(myBrush, X, Y, this.Ancho,this.Alto);
            
        }

        public void Moverse(double x, double y)
        {

        }


        //---GETTERS AND SETTERS---//
        public override String GetNombre()
        {
            return this.nombre;
        }
        public override float GetAlto()
        {
            return this.Alto;
        }
        public override void SetAlto(float a)
        {
            this.Alto = a;
        }
        public override float GetAncho()
        {
            return this.Ancho;
        }
        public override void SetAncho(float a)
        {
            this.Ancho = a;
        }
        public override Point GetPosicion()
        {
            return this.Posicion;
        }
        public override void SetPosicion(Point p)
        {
            this.Posicion = p;
        }
        public override Color GetColorRelleno()
        {
            return this.ColorRelleno;
        }
        public override void SetColorRelleno(Color c)
        {
            this.ColorRelleno = c;
        }
        public override Color GetColorTrazo()
        {
            return this.ColorTrazo;
        }
        public override void SetColorTrazo(Color c)
        {
            this.ColorTrazo = c;
        }
        public override Bitmap getIconSeleted()
        {
            return Properties.Resources.squareSelected;
        }


        //Static Methods//
        public static void Seleccionado(Control Icono, Control IconoEdicion, Label TituloFigura)
        {
            Icono.BackgroundImage = Properties.Resources.squareSelected;
            IconoEdicion.BackgroundImage = Properties.Resources.squareSelected;
            TituloFigura.Text = Cuadrado.Nombre;

        }
        public static void Deseleccionado(Control Icono)
        {
            Icono.BackgroundImage = Properties.Resources.square;
        }
    }
}
