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
    public class Texto : Figuras,IMovible
    {
        public const String Nombre = "Texto";
        private String texto = "";
        private Font letra;

        public Texto(String text,Font f,int x, int y)
        {
            this.nombre = "Texto";
            this.texto = text;
            this.letra = f;
            this.Ancho = 0;
            this.Alto = 0;
            this.ColorRelleno = Color.Black;
            this.ColorTrazo = Color.Black;
            this.Posicion.X = x;
            this.Posicion.Y = y;
        }

        public override void Dibujarse(Graphics g, int X, int Y)
        {
            Brush myBrush = new SolidBrush(this.ColorRelleno);
            g.DrawString(this.texto, this.letra,myBrush,X,Y);

        }

        public void Moverse(double x, double y)
        {



        }



        //---GETTERS AND SETTERS---//
        public override String GetNombre()
        {
            return this.nombre;
        }
        public void SetTexto(String s)
        {
            this.texto = s;
        }
        public String GetTexto()
        {
            return this.texto;
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
            return Properties.Resources.textSelected;
        }

        //Static Methods//
        public static void Seleccionado(Control Icono, Control IconoEdicion, Label TituloFigura)
        {
            Icono.BackgroundImage = Properties.Resources.textSelected;
            IconoEdicion.BackgroundImage = Properties.Resources.textSelected;
            TituloFigura.Text = Texto.Nombre;

        }
        public static void Deseleccionado(Control Icono)
        {
            Icono.BackgroundImage = Properties.Resources.text;
        }
    }
}
