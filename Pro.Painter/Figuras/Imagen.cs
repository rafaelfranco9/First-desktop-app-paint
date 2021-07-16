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
    public class Imagen : Figuras, IMovible
    {

        public const String Nombre = "Imagen";
        private Bitmap imagen;

        public Imagen(int x, int y,String path)
        {

            this.nombre = "Imagen";
            imagen = new Bitmap(path);
            this.Ancho = 300;
            this.Alto = 300;
            this.ColorRelleno = Color.Black;
            this.ColorTrazo = Color.Black;
            this.Posicion.X = x;
            this.Posicion.Y = y;
        }

        public override void Dibujarse(Graphics g, int X, int Y)
        {
            g.DrawImage(this.imagen, X, Y, this.Ancho, this.Alto);

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
            return Properties.Resources.imageSelected;
        }


        //Static Methods//
        public static void Seleccionado(Control Icono, Control IconoEdicion, Label TituloFigura)
        {
            Icono.BackgroundImage = Properties.Resources.imageSelected;
            IconoEdicion.BackgroundImage = Properties.Resources.imageSelected;
            TituloFigura.Text = Imagen.Nombre;

        }
        public static void Deseleccionado(Control Icono)
        {
            Icono.BackgroundImage = Properties.Resources.image;
        }
    }
}
