namespace Scoop
{
    partial class Propina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Gracias = new System.Windows.Forms.Label();
            this.label_Propina = new System.Windows.Forms.Label();
            this.button_SiProp = new System.Windows.Forms.Button();
            this.button_NoProp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_NoProp);
            this.panel1.Controls.Add(this.button_SiProp);
            this.panel1.Controls.Add(this.label_Propina);
            this.panel1.Controls.Add(this.label_Gracias);
            this.panel1.Location = new System.Drawing.Point(86, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 289);
            this.panel1.TabIndex = 0;
            // 
            // label_Gracias
            // 
            this.label_Gracias.AutoSize = true;
            this.label_Gracias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gracias.Location = new System.Drawing.Point(170, 24);
            this.label_Gracias.Name = "label_Gracias";
            this.label_Gracias.Size = new System.Drawing.Size(331, 32);
            this.label_Gracias.TabIndex = 0;
            this.label_Gracias.Text = "¡Gracias por tu compra!";
            // 
            // label_Propina
            // 
            this.label_Propina.AutoSize = true;
            this.label_Propina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Propina.Location = new System.Drawing.Point(218, 94);
            this.label_Propina.Name = "label_Propina";
            this.label_Propina.Size = new System.Drawing.Size(201, 22);
            this.label_Propina.TabIndex = 1;
            this.label_Propina.Text = "¿Deseas dejar propina?";
            // 
            // button_SiProp
            // 
            this.button_SiProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SiProp.Location = new System.Drawing.Point(147, 179);
            this.button_SiProp.Name = "button_SiProp";
            this.button_SiProp.Size = new System.Drawing.Size(82, 56);
            this.button_SiProp.TabIndex = 2;
            this.button_SiProp.Text = "Sí";
            this.button_SiProp.UseVisualStyleBackColor = true;
            this.button_SiProp.Click += new System.EventHandler(this.button_SiProp_Click);
            // 
            // button_NoProp
            // 
            this.button_NoProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NoProp.Location = new System.Drawing.Point(404, 179);
            this.button_NoProp.Name = "button_NoProp";
            this.button_NoProp.Size = new System.Drawing.Size(82, 56);
            this.button_NoProp.TabIndex = 3;
            this.button_NoProp.Text = "No";
            this.button_NoProp.UseVisualStyleBackColor = true;
            // 
            // Propina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 412);
            this.Controls.Add(this.panel1);
            this.Name = "Propina";
            this.Text = "Propina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Propina;
        private System.Windows.Forms.Label label_Gracias;
        private System.Windows.Forms.Button button_SiProp;
        private System.Windows.Forms.Button button_NoProp;
    }
}