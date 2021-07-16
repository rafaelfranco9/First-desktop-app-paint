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
    public class Circulo : Figuras, IMovible
    {

        public const String Nombre = "Circulo";

        public Circulo(int x, int y)
        {
            this.nombre = "Circulo";
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
            g.FillEllipse(myBrush, X, Y, this.Ancho, this.Alto);

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
        public override Bitmap getIconSeleted()
        {
            return Properties.Resources.circleSelected;
        }


        //Static Methods//
        public static void Seleccionado(Control Icono, Control IconoEdicion,Label TituloFigura)
        {
            Icono.BackgroundImage = Properties.Resources.circleSelected;
            IconoEdicion.BackgroundImage = Properties.Resources.circleSelected;
            TituloFigura.Text = Circulo.Nombre;
            
        }
        public static void Deseleccionado(Control Icono)
        {
            Icono.BackgroundImage = Properties.Resources.circle;
        }


    }
}
