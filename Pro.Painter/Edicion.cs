using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pro.Painter
{
    public class Edicion
    {

        private Figuras.Figuras FiguraSeleccionada;
        private TextBox ejeX;
        private TextBox ejeY;
        private TextBox alto;
        private TextBox ancho;
        private Button colorTrazo;
        private Button colorRelleno;
        private TextBox anchoTrazo;

        public Edicion(TextBox ejeX, TextBox ejeY, TextBox alto, TextBox ancho,Button colorTrazo,Button colorRelleno,TextBox anchoTrazo)
        {
            this.ejeX = ejeX;
            this.ejeY = ejeY;
            this.alto = alto;
            this.ancho = ancho;
            this.colorTrazo = colorTrazo;
            this.colorRelleno = colorRelleno;
            this.anchoTrazo = anchoTrazo;
        }

        public void setCaracteristicas(Figuras.Figuras f)
        {
            this.FiguraSeleccionada = f;
            this.ejeX.Text = f.Posicion.X.ToString();
            this.ejeY.Text = f.Posicion.Y.ToString();
            this.alto.Text = f.Alto.ToString();
            this.ancho.Text = f.Ancho.ToString();
            this.colorTrazo.BackColor = f.ColorTrazo;
            this.colorRelleno.BackColor = f.ColorRelleno;
            this.anchoTrazo.Text = f.AnchoTrazo.ToString();

        }

        public void setEjeX(String x)
        {
            int ejeX = Convert.ToInt32(x);
            FiguraSeleccionada.Posicion.X = ejeX;
        }
        public String getEjeX()
        {
            return FiguraSeleccionada.Posicion.X.ToString();
        }

        public void setEjeY(String y)
        {
            int ejeY = Convert.ToInt32(y);
            FiguraSeleccionada.Posicion.Y = ejeY;
        }
        public String getEjeY()
        {
            return FiguraSeleccionada.Posicion.Y.ToString();
        }
        public void setAncho(String a)
        {
            int ancho = Convert.ToInt32(a);
            FiguraSeleccionada.Ancho = ancho;
        }
        public String getAncho()
        {
            return FiguraSeleccionada.Ancho.ToString();
        }
        public void setAlto(String a)
        {
            int alto = Convert.ToInt32(a);
            FiguraSeleccionada.Alto = alto;
        }
        public String getAlto()
        {
            return FiguraSeleccionada.Alto.ToString();
        }
        public Figuras.Figuras getFiguraSeleccionada()
        {
            return FiguraSeleccionada;
        }
        public String getAnchoTrazo()
        {
            return FiguraSeleccionada.AnchoTrazo.ToString();
        }
        public void setAnchoTrazo(String s)
        {
            int anchoTrazo = Convert.ToInt32(s);
            FiguraSeleccionada.AnchoTrazo = anchoTrazo;
        }

    }
}
