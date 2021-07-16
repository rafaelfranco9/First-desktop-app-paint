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



namespace Pro.Painter
{
    public partial class HomeForm : Form
    {
        //DDL
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

        public HomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Icon = Properties.Resources.Logo1;
            RoundCorners(this.newProyectButton,40,40);
            RoundCorners(this.openProyectButton,40,40);
            

        }


        //Buttons Events
        private void NewProyectButton_Click(object sender, EventArgs e)
        {

            PainterForm Painter = new PainterForm();
            Painter.Owner = this;
            Painter.Show();
            this.Hide(); //De esta manera va a seguir quedando en memoria y yo no quiero eso!! preguntar
            

        }
        private void OpenProyectButton_Click(object sender, EventArgs e)
        {

            PainterForm Painter = new PainterForm();
            Painter.Owner = this;
            Painter.Show();
            this.Hide();
            Painter.AbrirToolStripMenuItem_Click(this,new EventArgs());

        }

        //Buttons Animation
        private void OpenProyectButton_MouseEnter(object sender, EventArgs e)
        {
            HoverAnimationIn(this.openProyectButton, 20);
        }

        private void OpenProyectButton_MouseLeave(object sender, EventArgs e)
        {
            HoverAnimationOut(this.openProyectButton, 20);

        }
        private void NewProyectButton_MouseEnter(object sender, EventArgs e)
        {
            HoverAnimationIn(this.newProyectButton, 20);
        }

        private void NewProyectButton_MouseLeave(object sender, EventArgs e)
        {
            HoverAnimationOut(this.newProyectButton, 20);
        }




        //My Functions
        private void RoundCorners(Control obj, int corner1, int corner2)
        {
            obj.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, obj.Width, obj.Height, corner1, corner2));
        }

        private void HoverAnimationIn(Control c,int aumentar)
        {

            c.Location = new Point(c.Location.X - (aumentar / 2), c.Location.Y - (aumentar / 2));
            c.Size = new Size(c.Size.Width + aumentar, c.Size.Height + aumentar);
            RoundCorners(c, 40, 40);
            c.BackColor = Color.FromArgb(38, 225, 220);
            c.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void HoverAnimationOut(Control c, int aumentar)
        {
            c.Size = new Size(587, 446);
            RoundCorners(c, 40, 40);
            c.BackColor = Color.FromArgb(238,247,255);
            c.Location = new Point(c.Location.X + (aumentar / 2), c.Location.Y + (aumentar / 2));
            c.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }


    }
}
