namespace Scoop
{
    partial class tarjeta
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
            this.credito = new System.Windows.Forms.RadioButton();
            this.debito = new System.Windows.Forms.RadioButton();
            this.numcuentabox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pagarbutton = new System.Windows.Forms.Button();
            this.nipbox = new System.Windows.Forms.TextBox();
            this.nip = new System.Windows.Forms.Label();
            this.cuenta = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // credito
            // 
            this.credito.AutoSize = true;
            this.credito.Location = new System.Drawing.Point(125, 42);
            this.credito.Name = "credito";
            this.credito.Size = new System.Drawing.Size(71, 20);
            this.credito.TabIndex = 0;
            this.credito.TabStop = true;
            this.credito.Text = "Crédito";
            this.credito.UseVisualStyleBackColor = true;
            this.credito.CheckedChanged += new System.EventHandler(this.credito_CheckedChanged);
            // 
            // debito
            // 
            this.debito.AutoSize = true;
            this.debito.Location = new System.Drawing.Point(342, 42);
            this.debito.Name = "debito";
            this.debito.Size = new System.Drawing.Size(68, 20);
            this.debito.TabIndex = 1;
            this.debito.TabStop = true;
            this.debito.Text = "Débito";
            this.debito.UseVisualStyleBackColor = true;
            this.debito.CheckedChanged += new System.EventHandler(this.debito_CheckedChanged);
            // 
            // numcuentabox
            // 
            this.numcuentabox.Location = new System.Drawing.Point(202, 100);
            this.numcuentabox.Name = "numcuentabox";
            this.numcuentabox.Size = new System.Drawing.Size(170, 22);
            this.numcuentabox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pagarbutton);
            this.panel1.Controls.Add(this.nipbox);
            this.panel1.Controls.Add(this.nip);
            this.panel1.Controls.Add(this.cuenta);
            this.panel1.Controls.Add(this.numcuentabox);
            this.panel1.Controls.Add(this.debito);
            this.panel1.Controls.Add(this.credito);
            this.panel1.Location = new System.Drawing.Point(31, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 252);
            this.panel1.TabIndex = 3;
            // 
            // pagarbutton
            // 
            this.pagarbutton.Location = new System.Drawing.Point(212, 202);
            this.pagarbutton.Name = "pagarbutton";
            this.pagarbutton.Size = new System.Drawing.Size(146, 35);
            this.pagarbutton.TabIndex = 6;
            this.pagarbutton.Text = "Pagar";
            this.pagarbutton.UseVisualStyleBackColor = true;
            this.pagarbutton.Click += new System.EventHandler(this.pagarbutton_Click);
            // 
            // nipbox
            // 
            this.nipbox.Location = new System.Drawing.Point(202, 140);
            this.nipbox.Name = "nipbox";
            this.nipbox.Size = new System.Drawing.Size(170, 22);
            this.nipbox.TabIndex = 5;
            // 
            // nip
            // 
            this.nip.AutoSize = true;
            this.nip.Location = new System.Drawing.Point(153, 143);
            this.nip.Name = "nip";
            this.nip.Size = new System.Drawing.Size(28, 16);
            this.nip.TabIndex = 4;
            this.nip.Text = "Nip";
            this.nip.Click += new System.EventHandler(this.nip_Click);
            // 
            // cuenta
            // 
            this.cuenta.AutoSize = true;
            this.cuenta.Location = new System.Drawing.Point(115, 103);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(81, 16);
            this.cuenta.TabIndex = 3;
            this.cuenta.Text = "Núm. cuenta";
            this.cuenta.Click += new System.EventHandler(this.cuenta_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = global::Scoop.Properties.Resources.WhatsApp_Image_2024_12_07_at_11_20_10;
            this.pictureBox13.Location = new System.Drawing.Point(94, -3);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(445, 108);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 4;
            this.pictureBox13.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.panel1);
            this.Name = "tarjeta";
            this.Text = "tarjeta";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton credito;
        private System.Windows.Forms.RadioButton debito;
        private System.Windows.Forms.TextBox numcuentabox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nipbox;
        private System.Windows.Forms.Label nip;
        private System.Windows.Forms.Label cuenta;
        private System.Windows.Forms.Button pagarbutton;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Button button1;
    }
}