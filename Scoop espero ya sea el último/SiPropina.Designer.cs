namespace Scoop
{
    partial class SiPropina
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Diezpor = new System.Windows.Forms.Button();
            this.button_Quincepor = new System.Windows.Forms.Button();
            this.button_Veintepor = new System.Windows.Forms.Button();
            this.button_Pagarprop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Pagarprop);
            this.panel1.Controls.Add(this.button_Veintepor);
            this.panel1.Controls.Add(this.button_Quincepor);
            this.panel1.Controls.Add(this.button_Diezpor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(93, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 307);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona el porcentaje que quieras dejar";
            // 
            // button_Diezpor
            // 
            this.button_Diezpor.Location = new System.Drawing.Point(37, 108);
            this.button_Diezpor.Name = "button_Diezpor";
            this.button_Diezpor.Size = new System.Drawing.Size(124, 49);
            this.button_Diezpor.TabIndex = 1;
            this.button_Diezpor.Text = "10%";
            this.button_Diezpor.UseVisualStyleBackColor = true;
            this.button_Diezpor.Click += new System.EventHandler(this.button_Diezpor_Click);
            // 
            // button_Quincepor
            // 
            this.button_Quincepor.Location = new System.Drawing.Point(217, 108);
            this.button_Quincepor.Name = "button_Quincepor";
            this.button_Quincepor.Size = new System.Drawing.Size(124, 49);
            this.button_Quincepor.TabIndex = 2;
            this.button_Quincepor.Text = "15%";
            this.button_Quincepor.UseVisualStyleBackColor = true;
            // 
            // button_Veintepor
            // 
            this.button_Veintepor.Location = new System.Drawing.Point(396, 108);
            this.button_Veintepor.Name = "button_Veintepor";
            this.button_Veintepor.Size = new System.Drawing.Size(124, 49);
            this.button_Veintepor.TabIndex = 3;
            this.button_Veintepor.Text = "20%";
            this.button_Veintepor.UseVisualStyleBackColor = true;
            // 
            // button_Pagarprop
            // 
            this.button_Pagarprop.Location = new System.Drawing.Point(204, 224);
            this.button_Pagarprop.Name = "button_Pagarprop";
            this.button_Pagarprop.Size = new System.Drawing.Size(182, 54);
            this.button_Pagarprop.TabIndex = 4;
            this.button_Pagarprop.Text = "Confirmar";
            this.button_Pagarprop.UseVisualStyleBackColor = true;
            this.button_Pagarprop.Click += new System.EventHandler(this.button_Pagarprop_Click);
            // 
            // SiPropina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SiPropina";
            this.Text = "SiPropina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Diezpor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Veintepor;
        private System.Windows.Forms.Button button_Quincepor;
        private System.Windows.Forms.Button button_Pagarprop;
    }
}