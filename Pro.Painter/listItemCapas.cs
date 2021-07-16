using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro.Painter
{
    public partial class listItemCapas : UserControl
    {

        private String Nombre;
        private Bitmap icono;
        private Figuras.Figuras figura;
        private List<Figuras.Figuras> figuras;

        public listItemCapas(List<Figuras.Figuras> listaFiguras,Figuras.Figuras f)
        {
            InitializeComponent();
            this.figura = f;
            this.tituloFigura.Text = f.nombre;
            this.iconoFigura.Image = f.getIconSeleted();
            this.figuras = listaFiguras;
        }
        
        public Figuras.Figuras getFigura()
        {
            return this.figura;

        }

        public void dibujar()
        {
            Graphics g = this.capa.CreateGraphics();
            this.figura.Dibujarse(g,this.figura.Posicion.X, this.figura.Posicion.Y);
            g.Dispose();

        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            this.ParentForm.Hide();
            PainterForm f = (PainterForm)this.ParentForm.Owner;
            f.setEdicion(this.figura);
            
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("Esta seguro que quiere borrar la figura?","Eliminar Figura",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(r == DialogResult.Yes) { 
           
                for(int i=0; i < this.figuras.Count; i++)
                {
                    if (figuras[i].Equals(this.figura)) { 
                        figuras.RemoveAt(i);
                        break;
                    }

                }
            }

            this.ParentForm.Hide();
            PainterForm f = (PainterForm)this.ParentForm.Owner;
            f.refreshPaintArea();
        }
    }
}
