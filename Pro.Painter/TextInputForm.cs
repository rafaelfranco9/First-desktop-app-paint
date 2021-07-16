using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro.Painter.Figuras
{
    public partial class TextInputForm : Form
    {

        private Font fontSelected;
        private String text;

        public TextInputForm()
        {
            InitializeComponent();
            fontSelected = new Font("Arial", 20, FontStyle.Regular);
        }


        private void TextInputForm_Load(object sender, EventArgs e)
        {

        }

        private void BotonOK_Click(object sender, EventArgs e)
        {

            if(richTextBox.Text != "")
            {
                text = richTextBox.Text;
            }
        }

        public Font getFontSelected()
        {
            return this.fontSelected;
        }
        public String getText()
        {
            return this.text;
        }

        private void BotonTipoLetra_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                fontSelected = fontDialog.Font;
            }
        }
    }
}
