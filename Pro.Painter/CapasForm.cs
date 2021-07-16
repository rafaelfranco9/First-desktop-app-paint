using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro.Painter
{
    public partial class CapasForm : Form
    {

        private List<Figuras.Figuras> figuras;

        public CapasForm(List<Figuras.Figuras> listaFiguras)
        {
            InitializeComponent();
            this.figuras = listaFiguras;
            
            
        }
        private void CapasForm_Load(object sender, EventArgs e)
        {
            CrearCapas(figuras);

        }

        private void CrearCapas(List<Figuras.Figuras> listaFiguras)
        {
            foreach(Figuras.Figuras figura in listaFiguras) {

                listItemCapas capas = new listItemCapas(this.figuras,figura);
                flowLayout.Controls.Add(capas);
                
            }

        }

        private void CapasForm_Shown(object sender, EventArgs e)
        {

            Refresh();
            foreach (listItemCapas c in this.flowLayout.Controls)
            {
                c.dibujar();
            }

        }

        private void FlowLayout_Scroll(object sender, ScrollEventArgs e)
        {
            //foreach (listItemCapas c in this.flowLayout.Controls)
            //{
            //    c.dibujar();
            //}
        }

        private void CapasForm_ResizeEnd(object sender, EventArgs e)
        {
            foreach (listItemCapas c in this.flowLayout.Controls)
            {
                c.dibujar();
            }
        }

        private void FlowLayout_Paint(object sender, PaintEventArgs e)
        {
            foreach (listItemCapas c in this.flowLayout.Controls)
            {
                c.dibujar();
            }

        }
    }
}
    