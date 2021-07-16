using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Pro.Painter.Figuras;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pro.Painter
{
    public partial class PainterForm : Form
    {

        private List<Figuras.Figuras> ListaFiguras = new List<Figuras.Figuras>();
        private Edicion Edicion;
        private PaintBox PaintArea;
        private String pathGuardado = "";
        private Boolean editing = false;


        public PainterForm()
        {
            InitializeComponent();
        }


        //DDL for Round Borders
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse

        );

        private void PainterForm_Load(object sender, EventArgs e)
        {

            RoundCorners(this.PanelFiguras, 40, 40);
            RoundCorners(this.SubPanelFiguras, 40, 0);
            RoundCorners(this.PanelEdicion, 40, 40);
            RoundCorners(this.SubPanelEdicion, 40, 0);
            RoundCorners(this.botonCapas, 40, 40);
            RoundCorners(this.statusStrip1, 0, 40);
            RoundCorners(this.PaintBox, 40, 40);

            PaintArea = new PaintBox();
            Edicion = new Edicion(this.InputEjeX, this.InputEjeY, this.InputAlto, this.InputAncho, this.botonColorTrazo, this.botonColorRelleno,this.inputTrazo);

        }

        private void RoundCorners(Control obj, int corner1, int corner2)
        {
            obj.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, obj.Width, obj.Height, corner1, corner2));
        }


        private void BotonCirculo_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            Circulo.Seleccionado(this.botonCirculo, this.figuraSelecionada, this.TituloFiguraSeleccionada);

        }

        private void BotonCuadrado_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            Cuadrado.Seleccionado(this.botonCuadrado, this.figuraSelecionada, this.TituloFiguraSeleccionada);
        }

        private void BotonTriangulo_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            Triangulo.Seleccionado(this.botonTriangulo, this.figuraSelecionada, this.TituloFiguraSeleccionada);

        }

        private void BotonLinea_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            Linea.Seleccionado(this.botonLinea, this.figuraSelecionada, this.TituloFiguraSeleccionada);

        }

        private void BotonDibujarLibre_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            DibujoLibre.Seleccionado(this.botonDibujarLibre, this.figuraSelecionada, this.TituloFiguraSeleccionada);
            this.inputTrazo.Text = "10";
        }
        private void BotonTexto_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            Texto.Seleccionado(this.botonTexto, this.figuraSelecionada, this.TituloFiguraSeleccionada);
            TextInputForm fontForm = new TextInputForm();

            if (fontForm.ShowDialog() == DialogResult.OK) {

                Texto text = new Texto(fontForm.getText(), fontForm.getFontSelected(), 500, 500);
                ListaFiguras.Add(text);
                Edicion.setCaracteristicas(text);
                PaintArea.Refresh(ListaFiguras, this.PaintBox);
            }
                
        }

        private void BotonImagen_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            Imagen.Seleccionado(this.botonImagen, this.figuraSelecionada, this.TituloFiguraSeleccionada);

            if (this.OpenFileImage.ShowDialog() == DialogResult.OK)
            {
                Imagen img = new Imagen(500,500,OpenFileImage.FileName);
                ListaFiguras.Add(img);
                Edicion.setCaracteristicas(img);
                PaintArea.Refresh(ListaFiguras, this.PaintBox);

            }

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            DeseleccionarBotones();
            this.IconSelector.BackgroundImage = Properties.Resources.selectionSelected;
            this.figuraSelecionada.BackgroundImage = Properties.Resources.selectionSelected;
            this.TituloFiguraSeleccionada.Text = "Selector";
            editing = true;

        }

        private void DeseleccionarBotones()
        {
            Circulo.Deseleccionado(this.botonCirculo);
            Cuadrado.Deseleccionado(this.botonCuadrado);
            Triangulo.Deseleccionado(this.botonTriangulo);
            Linea.Deseleccionado(this.botonLinea);
            DibujoLibre.Deseleccionado(this.botonDibujarLibre);
            Texto.Deseleccionado(this.botonTexto);
            Imagen.Deseleccionado(this.botonImagen);
            this.IconSelector.BackgroundImage = Properties.Resources.selection;
            toolStripStatusLabel1.Text = "Status: ";
            editing = false;
        }


        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {

            if(!editing) { 


                switch (this.TituloFiguraSeleccionada.Text)
                {
                    case Circulo.Nombre:
                        Circulo circulo = new Circulo(e.X, e.Y);
                        ListaFiguras.Add(circulo);
                        Edicion.setCaracteristicas(circulo);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case Cuadrado.Nombre:
                        Cuadrado cuadrado = new Cuadrado(e.X, e.Y);
                        ListaFiguras.Add(cuadrado);
                        Edicion.setCaracteristicas(cuadrado);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case Triangulo.Nombre:
                        Triangulo triangulo = new Triangulo(e.X, e.Y);
                        ListaFiguras.Add(triangulo);
                        Edicion.setCaracteristicas(triangulo);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case Linea.Nombre:
                        Linea linea = new Linea(e.X, e.Y);
                        ListaFiguras.Add(linea);
                        Edicion.setCaracteristicas(linea);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case DibujoLibre.Nombre:
                        int anchoTrazo = Convert.ToInt32(this.inputTrazo.Text);
                        DibujoLibre dibujo = new DibujoLibre(e.X, e.Y, anchoTrazo);
                        ListaFiguras.Add(dibujo);
                        Edicion.setCaracteristicas(dibujo);
                        break;

                    case Texto.Nombre:
                        break;

                    case Imagen.Nombre:
                        break;

                }

            }
            else
            {
                SelectObject(e.X, e.Y);
            }

        }



        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !editing)
            {
                switch (this.TituloFiguraSeleccionada.Text)
                {
                    case Circulo.Nombre:
                        Circulo circulo = (Circulo)Edicion.getFiguraSeleccionada();
                        circulo.SetAncho(e.X - circulo.GetPosicion().X);
                        circulo.SetAlto(e.Y - circulo.GetPosicion().Y);
                        Edicion.setCaracteristicas(circulo);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case Cuadrado.Nombre:
                        Cuadrado cuadrado = (Cuadrado)Edicion.getFiguraSeleccionada();
                        cuadrado.SetAncho(e.X - cuadrado.GetPosicion().X);
                        cuadrado.SetAlto(e.Y - cuadrado.GetPosicion().Y);
                        Edicion.setCaracteristicas(cuadrado);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case Triangulo.Nombre:
                        Triangulo triangulo = (Triangulo)Edicion.getFiguraSeleccionada();
                        triangulo.SetAncho(e.X - triangulo.GetPosicion().X);
                        triangulo.SetAlto(e.Y - triangulo.GetPosicion().Y);
                        Edicion.setCaracteristicas(triangulo);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case Linea.Nombre:
                        Linea linea = (Linea)Edicion.getFiguraSeleccionada();
                        linea.SetAncho(e.X - linea.GetPosicion().X);
                        linea.SetAlto(e.Y - linea.GetPosicion().Y);
                        Edicion.setCaracteristicas(linea);
                        PaintArea.Refresh(ListaFiguras,this.PaintBox);
                        break;

                    case DibujoLibre.Nombre:
                        DibujoLibre dibujo = (DibujoLibre)Edicion.getFiguraSeleccionada();
                        dibujo.SetNuevoPunto(new Point(e.X, e.Y));
                        Edicion.setCaracteristicas(dibujo);
                        dibujo.Trazar(PaintArea.getPaintArea(this.PaintBox), e.X, e.Y);
                        PaintArea.DisposePaintArea();
                        break;
                }

            }
            else if(e.Button == MouseButtons.Left)
            {
                switch (this.TituloFiguraSeleccionada.Text)
                {
                    case Circulo.Nombre:
                        Circulo circulo = (Circulo)Edicion.getFiguraSeleccionada();
                        circulo.SetPosicion(new Point(e.X, e.Y));
                        Edicion.setCaracteristicas(circulo);
                        PaintArea.Refresh(ListaFiguras, this.PaintBox);
                        break;

                    case Cuadrado.Nombre:
                        Cuadrado cuadrado = (Cuadrado)Edicion.getFiguraSeleccionada();
                        cuadrado.SetPosicion(new Point(e.X, e.Y));
                        Edicion.setCaracteristicas(cuadrado);
                        PaintArea.Refresh(ListaFiguras, this.PaintBox);
                        break;

                    case Triangulo.Nombre:
                        Triangulo triangulo = (Triangulo)Edicion.getFiguraSeleccionada();
                        triangulo.SetPosicion(new Point(e.X, e.Y));
                        Edicion.setCaracteristicas(triangulo);
                        PaintArea.Refresh(ListaFiguras, this.PaintBox);
                        break;

                    case Linea.Nombre:
                        Linea linea = (Linea)Edicion.getFiguraSeleccionada();
                        linea.SetPosicion(new Point(e.X, e.Y));
                        Edicion.setCaracteristicas(linea);
                        PaintArea.Refresh(ListaFiguras, this.PaintBox);
                        break;

                    case Texto.Nombre:
                        Texto texto = (Texto)Edicion.getFiguraSeleccionada();
                        texto.SetPosicion(new Point(e.X, e.Y));
                        Edicion.setCaracteristicas(texto);
                        PaintArea.Refresh(ListaFiguras, this.PaintBox);
                        break;

                    case Imagen.Nombre:
                        Imagen img = (Imagen)Edicion.getFiguraSeleccionada();
                        img.SetPosicion(new Point(e.X, e.Y));
                        Edicion.setCaracteristicas(img);
                        PaintArea.Refresh(ListaFiguras, this.PaintBox);
                        break;

                }

            }


        }


        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
        }

        public void setEdicion(Figuras.Figuras f)
        {
            this.Edicion.setCaracteristicas(f);
            this.TituloFiguraSeleccionada.Text = f.GetNombre();
            this.figuraSelecionada.BackgroundImage = f.getIconSeleted();
        }

        public void refreshPaintArea()
        {
            PaintArea.Refresh(ListaFiguras, this.PaintBox);
        }
        
        private void SelectObject(int x,int y)
        {
            int diffX = 0;
            int diffY = 0;
            int menorDistancia = 0;
            int diffTotal = 0;
            Figuras.Figuras figura = null;
            int i = 1;

            foreach (Figuras.Figuras f in this.ListaFiguras)
            {
                diffX = Math.Abs(x - f.Posicion.X);
                diffY = Math.Abs(y - f.Posicion.Y);
                diffTotal = diffX + diffY;

                if(diffTotal < menorDistancia || i == 1)
                {
                    figura = f;
                    menorDistancia = diffTotal;
                }

                i++;
            }

           
            if(figura != null) {
                this.setEdicion(figura);
            }


        }


        //-------Input Text Box-------//
        private void InputEjeX_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && Edicion.getFiguraSeleccionada() != null)
            {

                if (isNumber(this.InputEjeX.Text) && this.InputEjeX.Text.Trim().Length > 0 && Convert.ToInt32(this.InputEjeX.Text) <= PaintBox.Width)
                {
                    Edicion.setEjeX(this.InputEjeX.Text);
                    PaintArea.Refresh(ListaFiguras,this.PaintBox);
                    
                }
                else
                {
                    this.InputEjeX.Text = Edicion.getEjeX();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.InputEjeX.Text = "";
            }
        }

        private void InputEjeY_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && Edicion.getFiguraSeleccionada() != null)
            {

                if (isNumber(this.InputEjeY.Text) && this.InputEjeY.Text.Trim().Length > 0 && Convert.ToInt32(this.InputEjeY.Text) <= PaintBox.Height)
                {
                    Edicion.setEjeY(this.InputEjeY.Text);
                    PaintArea.Refresh(ListaFiguras,this.PaintBox);
                }
                else
                {
                    this.InputEjeY.Text = Edicion.getEjeY();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.InputEjeY.Text = "";
            }
        }

        private void InputAlto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && Edicion.getFiguraSeleccionada() != null)
            {

                if (isNumber(this.InputAlto.Text) && this.InputAlto.Text.Trim().Length > 0 && Convert.ToInt32(this.InputAlto.Text) <= PaintBox.Height)
                {
                    Edicion.setAlto(this.InputAlto.Text);
                    PaintArea.Refresh(ListaFiguras,this.PaintBox);
                }
                else
                {
                    this.InputAlto.Text = Edicion.getAlto();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.InputAlto.Text = "";
            }

        }

        private void InputAncho_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && Edicion.getFiguraSeleccionada() != null)
            {

                if (isNumber(this.InputAncho.Text) && this.InputAncho.Text.Trim().Length > 0 && Convert.ToInt32(this.InputAncho.Text) <= PaintBox.Width)
                {
                    Edicion.setAncho(this.InputAncho.Text);
                    PaintArea.Refresh(ListaFiguras,this.PaintBox);
                }
                else
                {
                    this.InputAncho.Text = Edicion.getAncho();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.InputAncho.Text = "";
            }
        }

        private void InputTrazo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && Edicion.getFiguraSeleccionada() != null)
            {

                if (isNumber(this.inputTrazo.Text) && this.inputTrazo.Text.Trim().Length > 0 && Convert.ToInt32(this.inputTrazo.Text) <= PaintBox.Width)
                {
                    Edicion.setAnchoTrazo(this.inputTrazo.Text);
                    PaintArea.Refresh(ListaFiguras, this.PaintBox);
                }
                else
                {
                    this.inputTrazo.Text = Edicion.getAnchoTrazo();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                this.inputTrazo.Text = "";
            }

        }




        //--Helper Functions--//
        private bool isNumber(String s)
        {
            foreach (Char letra in s)
            {
                if (!(letra >= '0' && letra <= '9' || letra == '-'))
                {
                    return false;
                }
            }

            return true;
        }

        private void PainterForm_Deactivate(object sender, EventArgs e)
        {
            
        }



        private void BotonColorTrazo_Click(object sender, EventArgs e)
        {
            if (Edicion.getFiguraSeleccionada() != null)
            {
                ColorDialog colorD = new ColorDialog();
                if (colorD.ShowDialog() == DialogResult.OK)
                {
                    this.botonColorTrazo.BackColor = colorD.Color;
                    Edicion.getFiguraSeleccionada().SetColorTrazo(colorD.Color);
                    PaintArea.Refresh(ListaFiguras,this.PaintBox);
                }
            }
        }

        private void BotonColorRelleno_Click(object sender, EventArgs e)
        {
            if (Edicion.getFiguraSeleccionada() != null)
            {
                ColorDialog colorD = new ColorDialog();
                if (colorD.ShowDialog() == DialogResult.OK)
                {
                    this.botonColorRelleno.BackColor = colorD.Color;
                    Edicion.getFiguraSeleccionada().SetColorRelleno(colorD.Color);
                    PaintArea.Refresh(ListaFiguras,this.PaintBox);

                }
            }
        }

        private void BotonCapas_Click(object sender, EventArgs e)
        {
            if(this.ListaFiguras.Count > 0) { 
                CapasForm c = new CapasForm(this.ListaFiguras);
                c.Owner = this;
                c.Show();
            }
            else
            {
                MessageBox.Show("No existe ninguna capa.","Mensaje al usuario",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void PainterForm_ResizeEnd(object sender, EventArgs e)
        {
            PaintArea.Refresh(ListaFiguras, this.PaintBox);
        }

        public void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if(dr == DialogResult.OK) { 

                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                this.ListaFiguras = (List<Figuras.Figuras>)formatter.Deserialize(stream);
                stream.Close();
                toolStripStatusLabel1.Text = "Status: Archivo abierto exitosamente!";
                this.refreshPaintArea();
            }

        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(this.ListaFiguras.Count > 0) { 


                if (this.pathGuardado == "")
                {
                    DialogResult dr = saveFileDialog1.ShowDialog();

                    if (dr == DialogResult.OK)
                    {

                        IFormatter formatter = new BinaryFormatter();
                        Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                        this.pathGuardado = saveFileDialog1.FileName;
                        formatter.Serialize(stream, this.ListaFiguras);
                        stream.Close();
                        toolStripStatusLabel1.Text = "Status: Archivo guardado con exito!";

                    }
                    else
                    {
                        toolStripStatusLabel1.Text = "Status: Archivo no guardado";
                    }

                }
                else
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(this.pathGuardado, FileMode.Create, FileAccess.Write);
                    formatter.Serialize(stream, this.ListaFiguras);
                    stream.Close();
                    toolStripStatusLabel1.Text = "Status: Archivo guardado con exito!";

                }

            }
            else
            {
                toolStripStatusLabel1.Text = "Status: No hay nada pintado, no se puede guardar.";

            }
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.ListaFiguras.Count > 0)
            {
                DialogResult dr = saveFileDialog1.ShowDialog();

                if (dr == DialogResult.OK)
                {

                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                    this.pathGuardado = saveFileDialog1.FileName;
                    formatter.Serialize(stream, this.ListaFiguras);
                    stream.Close();
                    toolStripStatusLabel1.Text = "Status: Archivo guardado con exito!";

                }
                else
                {
                    toolStripStatusLabel1.Text = "Status: Archivo no guardado";
                }
            }
            else
            { 
                toolStripStatusLabel1.Text = "Status: No hay nada pintado, no se puede guardar.";
            }


    }

        private void PainterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
