namespace SIMATIC
{
    partial class NuevaContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaContra));
            this.btnRestaurarContra = new System.Windows.Forms.Button();
            this.tbConfContraRIS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbContraRIS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRestaurarContra
            // 
            this.btnRestaurarContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnRestaurarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarContra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarContra.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurarContra.Image")));
            this.btnRestaurarContra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurarContra.Location = new System.Drawing.Point(99, 153);
            this.btnRestaurarContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRestaurarContra.Name = "btnRestaurarContra";
            this.btnRestaurarContra.Size = new System.Drawing.Size(187, 51);
            this.btnRestaurarContra.TabIndex = 3;
            this.btnRestaurarContra.Text = "       Restaurar";
            this.btnRestaurarContra.UseVisualStyleBackColor = true;
            this.btnRestaurarContra.Click += new System.EventHandler(this.btnRestaurarContra_Click);
            // 
            // tbConfContraRIS
            // 
            this.tbConfContraRIS.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbConfContraRIS.Location = new System.Drawing.Point(258, 107);
            this.tbConfContraRIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbConfContraRIS.Name = "tbConfContraRIS";
            this.tbConfContraRIS.Size = new System.Drawing.Size(152, 26);
            this.tbConfContraRIS.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 44);
            this.label6.TabIndex = 50;
            this.label6.Text = "Confirmar\r\ncontraseña:";
            // 
            // tbContraRIS
            // 
            this.tbContraRIS.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbContraRIS.Location = new System.Drawing.Point(258, 54);
            this.tbContraRIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbContraRIS.Name = "tbContraRIS";
            this.tbContraRIS.Size = new System.Drawing.Size(152, 26);
            this.tbContraRIS.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Contraseña:";
            // 
            // NuevaContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 254);
            this.Controls.Add(this.btnRestaurarContra);
            this.Controls.Add(this.tbConfContraRIS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbContraRIS);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NuevaContra";
            this.Text = "NuevaContra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurarContra;
        private System.Windows.Forms.TextBox tbConfContraRIS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbContraRIS;
        private System.Windows.Forms.Label label4;
    }
}