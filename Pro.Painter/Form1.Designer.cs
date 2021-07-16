namespace Pro.Painter
{
    partial class HomeForm
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.newProyectButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openProyectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(880, 64);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(617, 110);
            this.title.TabIndex = 0;
            this.title.Text = "PRO-PAINTER";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newProyectButton
            // 
            this.newProyectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newProyectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.newProyectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newProyectButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newProyectButton.ForeColor = System.Drawing.Color.Black;
            this.newProyectButton.Location = new System.Drawing.Point(472, 329);
            this.newProyectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newProyectButton.Name = "newProyectButton";
            this.newProyectButton.Size = new System.Drawing.Size(590, 446);
            this.newProyectButton.TabIndex = 1;
            this.newProyectButton.Text = "Nuevo Proyecto";
            this.newProyectButton.UseVisualStyleBackColor = false;
            this.newProyectButton.Click += new System.EventHandler(this.NewProyectButton_Click);
            this.newProyectButton.MouseEnter += new System.EventHandler(this.NewProyectButton_MouseEnter);
            this.newProyectButton.MouseLeave += new System.EventHandler(this.NewProyectButton_MouseLeave);
            // 
            // openProyectButton
            // 
            this.openProyectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.openProyectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.openProyectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProyectButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openProyectButton.ForeColor = System.Drawing.Color.Black;
            this.openProyectButton.Location = new System.Drawing.Point(1315, 329);
            this.openProyectButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openProyectButton.Name = "openProyectButton";
            this.openProyectButton.Size = new System.Drawing.Size(590, 446);
            this.openProyectButton.TabIndex = 2;
            this.openProyectButton.Text = "Abrir Proyecto";
            this.openProyectButton.UseVisualStyleBackColor = false;
            this.openProyectButton.Click += new System.EventHandler(this.OpenProyectButton_Click);
            this.openProyectButton.MouseEnter += new System.EventHandler(this.OpenProyectButton_MouseEnter);
            this.openProyectButton.MouseLeave += new System.EventHandler(this.OpenProyectButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 8.099999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(988, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developed by Rafael Franco";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(2376, 1030);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openProyectButton);
            this.Controls.Add(this.newProyectButton);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1614, 1012);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button newProyectButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button openProyectButton;
        private System.Windows.Forms.Label label1;
    }
}

