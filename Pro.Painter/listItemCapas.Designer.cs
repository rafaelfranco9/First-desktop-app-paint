namespace Pro.Painter
{
    partial class listItemCapas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.tituloFigura = new System.Windows.Forms.Label();
            this.iconoFigura = new System.Windows.Forms.PictureBox();
            this.capa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoFigura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tituloFigura);
            this.panel1.Controls.Add(this.iconoFigura);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 1000);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.botonEditar);
            this.panel2.Controls.Add(this.botonEliminar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 928);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 72);
            this.panel2.TabIndex = 4;
            // 
            // botonEditar
            // 
            this.botonEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonEditar.Dock = System.Windows.Forms.DockStyle.Left;
            this.botonEditar.ForeColor = System.Drawing.Color.White;
            this.botonEditar.Location = new System.Drawing.Point(0, 0);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(260, 72);
            this.botonEditar.TabIndex = 2;
            this.botonEditar.TabStop = false;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = false;
            this.botonEditar.Click += new System.EventHandler(this.BotonEditar_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.botonEliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.botonEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.botonEliminar.ForeColor = System.Drawing.Color.White;
            this.botonEliminar.Location = new System.Drawing.Point(256, 0);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(253, 72);
            this.botonEliminar.TabIndex = 3;
            this.botonEliminar.TabStop = false;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = false;
            this.botonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // tituloFigura
            // 
            this.tituloFigura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloFigura.Location = new System.Drawing.Point(73, 623);
            this.tituloFigura.Name = "tituloFigura";
            this.tituloFigura.Size = new System.Drawing.Size(357, 60);
            this.tituloFigura.TabIndex = 1;
            this.tituloFigura.Text = "Circulo";
            this.tituloFigura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconoFigura
            // 
            this.iconoFigura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconoFigura.Image = global::Pro.Painter.Properties.Resources.circleSelected;
            this.iconoFigura.Location = new System.Drawing.Point(83, 292);
            this.iconoFigura.Name = "iconoFigura";
            this.iconoFigura.Size = new System.Drawing.Size(351, 277);
            this.iconoFigura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconoFigura.TabIndex = 0;
            this.iconoFigura.TabStop = false;
            // 
            // capa
            // 
            this.capa.BackColor = System.Drawing.Color.White;
            this.capa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capa.Location = new System.Drawing.Point(509, 0);
            this.capa.Name = "capa";
            this.capa.Size = new System.Drawing.Size(1891, 1000);
            this.capa.TabIndex = 1;
            this.capa.TabStop = false;
            // 
            // listItemCapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(162)))));
            this.Controls.Add(this.capa);
            this.Controls.Add(this.panel1);
            this.Name = "listItemCapas";
            this.Size = new System.Drawing.Size(2400, 1000);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconoFigura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox iconoFigura;
        private System.Windows.Forms.Label tituloFigura;
        private System.Windows.Forms.PictureBox capa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonEliminar;
    }
}
