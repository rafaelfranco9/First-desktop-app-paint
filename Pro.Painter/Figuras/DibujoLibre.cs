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
    public class DibujoLibre : Figuras
    {
        public const String Nombre = "Dibujo Libre";
        private List<Point> puntos = new List<Point>();
        private Point PosicionFinal;

        public DibujoLibre(int x, int y,int anchoTrazo = 10)
        {
            this.nombre = "Dibujo Libre";
            this.Ancho = 0;
            this.Alto = 0;
            this.Posicion.X = x;
            this.Posicion.Y = y;
            this.ColorRelleno = Color.Black;
            this.ColorTrazo = Color.Black;
            this.AnchoTrazo = anchoTrazo;
            this.SetNuevoPunto(new Point(x, y));
        }

        public override void Dibujarse(Graphics g, int X, int Y)
        {
            Brush myBrush = new SolidBrush(this.ColorTrazo);
            for(int i = 0; i < this.puntos.Count && this.puntos.Count >= 2; i++)
            {
                if (i < this.puntos.Count - 1) { 
                    g.DrawLine(new Pen(myBrush, this.AnchoTrazo),this.puntos[i], this.puntos[i+1]);
                    g.FillEllipse(new Pen(myBrush, this.AnchoTrazo).Brush, this.puntos[i].X - (this.AnchoTrazo / 2), this.puntos[i].Y - (this.AnchoTrazo / 2), this.AnchoTrazo, this.AnchoTrazo);
                }
            }

        }
        public void Trazar(Graphics g, int X, int Y)
        {
            this.PosicionFinal = new Point(X, Y);
            Brush myBrush = new SolidBrush(this.ColorTrazo);
            g.DrawLine(new Pen(myBrush, this.AnchoTrazo), this.Posicion, PosicionFinal);
            g.FillEllipse(new Pen(myBrush, this.AnchoTrazo).Brush, X - (this.AnchoTrazo / 2), Y - (this.AnchoTrazo / 2), this.AnchoTrazo, this.AnchoTrazo);
            this.Posicion = this.PosicionFinal;
        }

        public void Moverse(double x, double y)
        {



        }


        //---GETTERS AND SETTERS---//
        public override String GetNombre()
        {
            return this.nombre;
        }
        public void SetNuevoPunto(Point p)
        {
            this.puntos.Add(p);
        }
        public List<Point> GetPuntos()
        {
            return this.puntos;
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
        public void SetPosicionFinal(Point p)
        {
            this.PosicionFinal = p;
        }
        public Point GetPosicionFinal()
        {
            return this.PosicionFinal;
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
            return Properties.Resources.pencilSelected;
        }


        //Static Methods//
        public static void Seleccionado(Control Icono, Control IconoEdicion, Label TituloFigura)
        {
            Icono.BackgroundImage = Properties.Resources.pencilSelected;
            IconoEdicion.BackgroundImage = Properties.Resources.pencilSelected;
            TituloFigura.Text = DibujoLibre.Nombre;

        }
        public static void Deseleccionado(Control Icono)
        {
            Icono.BackgroundImage = Properties.Resources.pencil;
        }
    }
}
