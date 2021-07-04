namespace SIMATIC
{
    partial class Factura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaFactura = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BtnCreditoFiscal = new System.Windows.Forms.RadioButton();
            this.btnConsumidorFinal = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.giro = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.TextBox();
            this.nit = new System.Windows.Forms.TextBox();
            this.nrc = new System.Windows.Forms.TextBox();
            this.NombreCliente = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.aumentable = new System.Windows.Forms.TextBox();
            this.UnidadesRestantes = new System.Windows.Forms.TextBox();
            this.CantidadVendida = new System.Windows.Forms.NumericUpDown();
            this.Disponible = new System.Windows.Forms.TextBox();
            this.PrecioUnitario = new System.Windows.Forms.TextBox();
            this.CodProd = new System.Windows.Forms.TextBox();
            this.NombreProd = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.AgregarProducto = new System.Windows.Forms.Button();
            this.btnCerrarProducto = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadVendida)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fechaFactura);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.BtnCreditoFiscal);
            this.groupBox1.Controls.Add(this.btnConsumidorFinal);
            this.groupBox1.Location = new System.Drawing.Point(37, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(409, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Factura";
            // 
            // fechaFactura
            // 
            this.fechaFactura.AutoSize = true;
            this.fechaFactura.Location = new System.Drawing.Point(49, 57);
            this.fechaFactura.Name = "fechaFactura";
            this.fechaFactura.Size = new System.Drawing.Size(55, 17);
            this.fechaFactura.TabIndex = 6;
            this.fechaFactura.Text = "Fecha :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 53);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // BtnCreditoFiscal
            // 
            this.BtnCreditoFiscal.AutoSize = true;
            this.BtnCreditoFiscal.Location = new System.Drawing.Point(248, 28);
            this.BtnCreditoFiscal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCreditoFiscal.Name = "BtnCreditoFiscal";
            this.BtnCreditoFiscal.Size = new System.Drawing.Size(114, 21);
            this.BtnCreditoFiscal.TabIndex = 2;
            this.BtnCreditoFiscal.TabStop = true;
            this.BtnCreditoFiscal.Text = "Credito Fiscal";
            this.BtnCreditoFiscal.UseVisualStyleBackColor = true;
            // 
            // btnConsumidorFinal
            // 
            this.btnConsumidorFinal.AutoSize = true;
            this.btnConsumidorFinal.Location = new System.Drawing.Point(40, 28);
            this.btnConsumidorFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsumidorFinal.Name = "btnConsumidorFinal";
            this.btnConsumidorFinal.Size = new System.Drawing.Size(134, 21);
            this.btnConsumidorFinal.TabIndex = 0;
            this.btnConsumidorFinal.TabStop = true;
            this.btnConsumidorFinal.Text = "Consumidor final";
            this.btnConsumidorFinal.UseVisualStyleBackColor = true;
            this.btnConsumidorFinal.CheckedChanged += new System.EventHandler(this.btnConsumidorFinal_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.giro);
            this.groupBox2.Controls.Add(this.direccion);
            this.groupBox2.Controls.Add(this.nit);
            this.groupBox2.Controls.Add(this.nrc);
            this.groupBox2.Controls.Add(this.NombreCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(37, 102);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(409, 224);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Cliente";
            // 
            // giro
            // 
            this.giro.Enabled = false;
            this.giro.Location = new System.Drawing.Point(164, 180);
            this.giro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.giro.Name = "giro";
            this.giro.Size = new System.Drawing.Size(225, 22);
            this.giro.TabIndex = 9;
            // 
            // direccion
            // 
            this.direccion.Enabled = false;
            this.direccion.Location = new System.Drawing.Point(164, 145);
            this.direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(225, 22);
            this.direccion.TabIndex = 7;
            // 
            // nit
            // 
            this.nit.Enabled = false;
            this.nit.Location = new System.Drawing.Point(164, 103);
            this.nit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nit.Name = "nit";
            this.nit.Size = new System.Drawing.Size(225, 22);
            this.nit.TabIndex = 6;
            // 
            // nrc
            // 
            this.nrc.Enabled = false;
            this.nrc.Location = new System.Drawing.Point(164, 65);
            this.nrc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nrc.Name = "nrc";
            this.nrc.Size = new System.Drawing.Size(225, 22);
            this.nrc.TabIndex = 5;
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombreCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NombreCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NombreCliente.FormattingEnabled = true;
            this.NombreCliente.Location = new System.Drawing.Point(164, 31);
            this.NombreCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.Size = new System.Drawing.Size(225, 24);
            this.NombreCliente.TabIndex = 4;
            this.NombreCliente.SelectedIndexChanged += new System.EventHandler(this.NombreCliente_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giro :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NIT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "NRC :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Cliente :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.aumentable);
            this.groupBox3.Controls.Add(this.UnidadesRestantes);
            this.groupBox3.Controls.Add(this.CantidadVendida);
            this.groupBox3.Controls.Add(this.Disponible);
            this.groupBox3.Controls.Add(this.PrecioUnitario);
            this.groupBox3.Controls.Add(this.CodProd);
            this.groupBox3.Controls.Add(this.NombreProd);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(487, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(415, 316);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Producto";
            // 
            // aumentable
            // 
            this.aumentable.Enabled = false;
            this.aumentable.Location = new System.Drawing.Point(211, 284);
            this.aumentable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aumentable.Name = "aumentable";
            this.aumentable.Size = new System.Drawing.Size(40, 22);
            this.aumentable.TabIndex = 12;
            this.aumentable.Text = "0";
            this.aumentable.Visible = false;
            // 
            // UnidadesRestantes
            // 
            this.UnidadesRestantes.Enabled = false;
            this.UnidadesRestantes.Location = new System.Drawing.Point(211, 255);
            this.UnidadesRestantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UnidadesRestantes.Name = "UnidadesRestantes";
            this.UnidadesRestantes.Size = new System.Drawing.Size(171, 22);
            this.UnidadesRestantes.TabIndex = 13;
            // 
            // CantidadVendida
            // 
            this.CantidadVendida.Location = new System.Drawing.Point(209, 214);
            this.CantidadVendida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CantidadVendida.Name = "CantidadVendida";
            this.CantidadVendida.Size = new System.Drawing.Size(171, 22);
            this.CantidadVendida.TabIndex = 12;
            this.CantidadVendida.ValueChanged += new System.EventHandler(this.CantidadVendida_ValueChanged);
            // 
            // Disponible
            // 
            this.Disponible.Enabled = false;
            this.Disponible.Location = new System.Drawing.Point(209, 175);
            this.Disponible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disponible.Name = "Disponible";
            this.Disponible.Size = new System.Drawing.Size(171, 22);
            this.Disponible.TabIndex = 11;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.Location = new System.Drawing.Point(208, 130);
            this.PrecioUnitario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Size = new System.Drawing.Size(171, 22);
            this.PrecioUnitario.TabIndex = 10;
            // 
            // CodProd
            // 
            this.CodProd.Enabled = false;
            this.CodProd.Location = new System.Drawing.Point(209, 92);
            this.CodProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CodProd.Name = "CodProd";
            this.CodProd.Size = new System.Drawing.Size(171, 22);
            this.CodProd.TabIndex = 9;
            // 
            // NombreProd
            // 
            this.NombreProd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NombreProd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NombreProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NombreProd.FormattingEnabled = true;
            this.NombreProd.Location = new System.Drawing.Point(208, 52);
            this.NombreProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.Size = new System.Drawing.Size(171, 24);
            this.NombreProd.TabIndex = 8;
            this.NombreProd.SelectedIndexChanged += new System.EventHandler(this.NombreProd_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 17);
            this.label11.TabIndex = 5;
            this.label11.Text = "Unidades Restantes :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cantidad a vender :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Producto Disponible :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Precio Unitario :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre de Producto :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo de Producto :";
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarProducto.Image")));
            this.btnLimpiarProducto.Location = new System.Drawing.Point(520, 363);
            this.btnLimpiarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(81, 55);
            this.btnLimpiarProducto.TabIndex = 15;
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("AgregarProducto.Image")));
            this.AgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarProducto.Location = new System.Drawing.Point(265, 363);
            this.AgregarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AgregarProducto.Name = "AgregarProducto";
            this.AgregarProducto.Size = new System.Drawing.Size(181, 55);
            this.AgregarProducto.TabIndex = 14;
            this.AgregarProducto.Text = "     Agregrar\r\n     Producto";
            this.AgregarProducto.UseVisualStyleBackColor = true;
            this.AgregarProducto.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCerrarProducto
            // 
            this.btnCerrarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarProducto.AutoSize = true;
            this.btnCerrarProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrarProducto.Location = new System.Drawing.Point(909, 10);
            this.btnCerrarProducto.Name = "btnCerrarProducto";
            this.btnCerrarProducto.Size = new System.Drawing.Size(17, 17);
            this.btnCerrarProducto.TabIndex = 16;
            this.btnCerrarProducto.Text = "X";
            this.btnCerrarProducto.Click += new System.EventHandler(this.btnCerrarProducto_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 555);
            this.Controls.Add(this.btnCerrarProducto);
            this.Controls.Add(this.AgregarProducto);
            this.Controls.Add(this.btnLimpiarProducto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadVendida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fechaFactura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton BtnCreditoFiscal;
        private System.Windows.Forms.RadioButton btnConsumidorFinal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox giro;
        private System.Windows.Forms.TextBox direccion;
        private System.Windows.Forms.TextBox nit;
        private System.Windows.Forms.TextBox nrc;
        private System.Windows.Forms.ComboBox NombreCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox UnidadesRestantes;
        private System.Windows.Forms.NumericUpDown CantidadVendida;
        private System.Windows.Forms.TextBox Disponible;
        private System.Windows.Forms.TextBox PrecioUnitario;
        private System.Windows.Forms.TextBox CodProd;
        private System.Windows.Forms.ComboBox NombreProd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.Button AgregarProducto;
        private System.Windows.Forms.Label btnCerrarProducto;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.TextBox aumentable;
    }
}