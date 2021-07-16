namespace Pro.Painter.Figuras
{
    partial class TextInputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextInputForm));
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.botonTipoLetra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.botonOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(48, 82);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(503, 215);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // botonTipoLetra
            // 
            this.botonTipoLetra.BackColor = System.Drawing.Color.Gray;
            this.botonTipoLetra.Location = new System.Drawing.Point(604, 147);
            this.botonTipoLetra.Name = "botonTipoLetra";
            this.botonTipoLetra.Size = new System.Drawing.Size(260, 64);
            this.botonTipoLetra.TabIndex = 1;
            this.botonTipoLetra.Text = "Tipo de Letra";
            this.botonTipoLetra.UseVisualStyleBackColor = false;
            this.botonTipoLetra.Click += new System.EventHandler(this.BotonTipoLetra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba aqui el texto que quiere agregar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(606, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Configure la letra";
            // 
            // botonOK
            // 
            this.botonOK.BackColor = System.Drawing.Color.Silver;
            this.botonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.botonOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.botonOK.Location = new System.Drawing.Point(734, 249);
            this.botonOK.Name = "botonOK";
            this.botonOK.Size = new System.Drawing.Size(130, 48);
            this.botonOK.TabIndex = 4;
            this.botonOK.Text = "OK";
            this.botonOK.UseVisualStyleBackColor = false;
            this.botonOK.Click += new System.EventHandler(this.BotonOK_Click);
            // 
            // TextInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(919, 351);
            this.Controls.Add(this.botonOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonTipoLetra);
            this.Controls.Add(this.richTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TextInputForm";
            this.Text = "Font";
            this.Load += new System.EventHandler(this.TextInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.Button botonTipoLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonOK;
    }
}