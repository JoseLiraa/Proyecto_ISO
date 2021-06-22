namespace SIMATIC
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            this.btnCerrarProveedores = new System.Windows.Forms.Label();
            this.pRegistrosProveedores = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuscarProvNom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.btnEliminarProveedores = new System.Windows.Forms.Button();
            this.btnModificarProveedores = new System.Windows.Forms.Button();
            this.tbDireccionModificarPro = new System.Windows.Forms.TextBox();
            this.tbCorreoModificarPro = new System.Windows.Forms.TextBox();
            this.tbCodigoModificarPro = new System.Windows.Forms.TextBox();
            this.tbNombreModificarPro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.pAddProveedores = new System.Windows.Forms.Panel();
            this.btnLimpiarProveedores = new System.Windows.Forms.Button();
            this.btnGuardarProveedores = new System.Windows.Forms.Button();
            this.direccionprov = new System.Windows.Forms.TextBox();
            this.correoprov = new System.Windows.Forms.TextBox();
            this.codProv = new System.Windows.Forms.TextBox();
            this.NombreProv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistroProveedores = new System.Windows.Forms.Button();
            this.btnAddProveedores = new System.Windows.Forms.Button();
            this.tbTelModificarPro = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.telefonoprov = new System.Windows.Forms.MaskedTextBox();
            this.pRegistrosProveedores.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.pAddProveedores.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarProveedores
            // 
            this.btnCerrarProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarProveedores.AutoSize = true;
            this.btnCerrarProveedores.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrarProveedores.Location = new System.Drawing.Point(727, 6);
            this.btnCerrarProveedores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnCerrarProveedores.Name = "btnCerrarProveedores";
            this.btnCerrarProveedores.Size = new System.Drawing.Size(14, 13);
            this.btnCerrarProveedores.TabIndex = 12;
            this.btnCerrarProveedores.Text = "X";
            this.btnCerrarProveedores.Click += new System.EventHandler(this.btnCerrarProveedores_Click);
            // 
            // pRegistrosProveedores
            // 
            this.pRegistrosProveedores.Controls.Add(this.groupBox2);
            this.pRegistrosProveedores.Controls.Add(this.groupBox1);
            this.pRegistrosProveedores.Controls.Add(this.dgvProveedores);
            this.pRegistrosProveedores.Location = new System.Drawing.Point(0, 44);
            this.pRegistrosProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.pRegistrosProveedores.Name = "pRegistrosProveedores";
            this.pRegistrosProveedores.Size = new System.Drawing.Size(741, 334);
            this.pRegistrosProveedores.TabIndex = 11;
            this.pRegistrosProveedores.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.BuscarProvNom);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 65);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Proveedor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre de proveedor:";
            // 
            // BuscarProvNom
            // 
            this.BuscarProvNom.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarProvNom.Location = new System.Drawing.Point(178, 22);
            this.BuscarProvNom.Margin = new System.Windows.Forms.Padding(2);
            this.BuscarProvNom.Name = "BuscarProvNom";
            this.BuscarProvNom.Size = new System.Drawing.Size(145, 22);
            this.BuscarProvNom.TabIndex = 4;
            this.BuscarProvNom.TextChanged += new System.EventHandler(this.tbCodigoBuscarProveedores_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelModificarPro);
            this.groupBox1.Controls.Add(this.Limpiar);
            this.groupBox1.Controls.Add(this.btnEliminarProveedores);
            this.groupBox1.Controls.Add(this.btnModificarProveedores);
            this.groupBox1.Controls.Add(this.tbDireccionModificarPro);
            this.groupBox1.Controls.Add(this.tbCorreoModificarPro);
            this.groupBox1.Controls.Add(this.tbCodigoModificarPro);
            this.groupBox1.Controls.Add(this.tbNombreModificarPro);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(392, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(344, 324);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // Limpiar
            // 
            this.Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Limpiar.Image")));
            this.Limpiar.Location = new System.Drawing.Point(256, 274);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(48, 40);
            this.Limpiar.TabIndex = 23;
            this.Limpiar.Text = "     ";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // btnEliminarProveedores
            // 
            this.btnEliminarProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEliminarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProveedores.Image")));
            this.btnEliminarProveedores.Location = new System.Drawing.Point(180, 272);
            this.btnEliminarProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarProveedores.Name = "btnEliminarProveedores";
            this.btnEliminarProveedores.Size = new System.Drawing.Size(53, 42);
            this.btnEliminarProveedores.TabIndex = 21;
            this.btnEliminarProveedores.UseVisualStyleBackColor = true;
            this.btnEliminarProveedores.Click += new System.EventHandler(this.btnEliminarProveedores_Click);
            // 
            // btnModificarProveedores
            // 
            this.btnModificarProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnModificarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProveedores.Image")));
            this.btnModificarProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProveedores.Location = new System.Drawing.Point(20, 272);
            this.btnModificarProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarProveedores.Name = "btnModificarProveedores";
            this.btnModificarProveedores.Size = new System.Drawing.Size(140, 42);
            this.btnModificarProveedores.TabIndex = 20;
            this.btnModificarProveedores.Text = "       Modificar";
            this.btnModificarProveedores.UseVisualStyleBackColor = true;
            this.btnModificarProveedores.Click += new System.EventHandler(this.btnModificarProveedores_Click);
            // 
            // tbDireccionModificarPro
            // 
            this.tbDireccionModificarPro.Location = new System.Drawing.Point(166, 193);
            this.tbDireccionModificarPro.Margin = new System.Windows.Forms.Padding(2);
            this.tbDireccionModificarPro.Name = "tbDireccionModificarPro";
            this.tbDireccionModificarPro.Size = new System.Drawing.Size(138, 22);
            this.tbDireccionModificarPro.TabIndex = 18;
            // 
            // tbCorreoModificarPro
            // 
            this.tbCorreoModificarPro.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreoModificarPro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbCorreoModificarPro.Location = new System.Drawing.Point(166, 144);
            this.tbCorreoModificarPro.Margin = new System.Windows.Forms.Padding(2);
            this.tbCorreoModificarPro.Name = "tbCorreoModificarPro";
            this.tbCorreoModificarPro.Size = new System.Drawing.Size(139, 22);
            this.tbCorreoModificarPro.TabIndex = 17;
            // 
            // tbCodigoModificarPro
            // 
            this.tbCodigoModificarPro.Location = new System.Drawing.Point(166, 42);
            this.tbCodigoModificarPro.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodigoModificarPro.Name = "tbCodigoModificarPro";
            this.tbCodigoModificarPro.Size = new System.Drawing.Size(138, 22);
            this.tbCodigoModificarPro.TabIndex = 16;
            // 
            // tbNombreModificarPro
            // 
            this.tbNombreModificarPro.Location = new System.Drawing.Point(197, 95);
            this.tbNombreModificarPro.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreModificarPro.Name = "tbNombreModificarPro";
            this.tbNombreModificarPro.Size = new System.Drawing.Size(107, 22);
            this.tbNombreModificarPro.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Teléfono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 145);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Correo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nombre de proveedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "Código:";
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(8, 81);
            this.dgvProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowTemplate.Height = 28;
            this.dgvProveedores.Size = new System.Drawing.Size(353, 252);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellDoubleClick);
            // 
            // pAddProveedores
            // 
            this.pAddProveedores.Controls.Add(this.telefonoprov);
            this.pAddProveedores.Controls.Add(this.btnLimpiarProveedores);
            this.pAddProveedores.Controls.Add(this.btnGuardarProveedores);
            this.pAddProveedores.Controls.Add(this.direccionprov);
            this.pAddProveedores.Controls.Add(this.correoprov);
            this.pAddProveedores.Controls.Add(this.codProv);
            this.pAddProveedores.Controls.Add(this.NombreProv);
            this.pAddProveedores.Controls.Add(this.label5);
            this.pAddProveedores.Controls.Add(this.label4);
            this.pAddProveedores.Controls.Add(this.label3);
            this.pAddProveedores.Controls.Add(this.label2);
            this.pAddProveedores.Controls.Add(this.label1);
            this.pAddProveedores.Location = new System.Drawing.Point(0, 51);
            this.pAddProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.pAddProveedores.Name = "pAddProveedores";
            this.pAddProveedores.Size = new System.Drawing.Size(606, 288);
            this.pAddProveedores.TabIndex = 10;
            // 
            // btnLimpiarProveedores
            // 
            this.btnLimpiarProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarProveedores.Image")));
            this.btnLimpiarProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarProveedores.Location = new System.Drawing.Point(289, 194);
            this.btnLimpiarProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarProveedores.Name = "btnLimpiarProveedores";
            this.btnLimpiarProveedores.Size = new System.Drawing.Size(136, 45);
            this.btnLimpiarProveedores.TabIndex = 11;
            this.btnLimpiarProveedores.Text = "       Limpiar";
            this.btnLimpiarProveedores.UseVisualStyleBackColor = true;
            this.btnLimpiarProveedores.Click += new System.EventHandler(this.btnLimpiarProveedores_Click);
            // 
            // btnGuardarProveedores
            // 
            this.btnGuardarProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProveedores.Image")));
            this.btnGuardarProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProveedores.Location = new System.Drawing.Point(109, 195);
            this.btnGuardarProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarProveedores.Name = "btnGuardarProveedores";
            this.btnGuardarProveedores.Size = new System.Drawing.Size(136, 45);
            this.btnGuardarProveedores.TabIndex = 10;
            this.btnGuardarProveedores.Text = "       Guardar";
            this.btnGuardarProveedores.UseVisualStyleBackColor = true;
            this.btnGuardarProveedores.Click += new System.EventHandler(this.btnGuardarProveedores_Click);
            // 
            // direccionprov
            // 
            this.direccionprov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.direccionprov.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.direccionprov.Location = new System.Drawing.Point(289, 129);
            this.direccionprov.Margin = new System.Windows.Forms.Padding(2);
            this.direccionprov.Name = "direccionprov";
            this.direccionprov.Size = new System.Drawing.Size(170, 22);
            this.direccionprov.TabIndex = 8;
            // 
            // correoprov
            // 
            this.correoprov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.correoprov.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.correoprov.ForeColor = System.Drawing.SystemColors.WindowText;
            this.correoprov.Location = new System.Drawing.Point(289, 99);
            this.correoprov.Margin = new System.Windows.Forms.Padding(2);
            this.correoprov.Name = "correoprov";
            this.correoprov.Size = new System.Drawing.Size(170, 22);
            this.correoprov.TabIndex = 7;
            // 
            // codProv
            // 
            this.codProv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codProv.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codProv.Location = new System.Drawing.Point(289, 42);
            this.codProv.Margin = new System.Windows.Forms.Padding(2);
            this.codProv.Name = "codProv";
            this.codProv.Size = new System.Drawing.Size(170, 22);
            this.codProv.TabIndex = 6;
            // 
            // NombreProv
            // 
            this.NombreProv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NombreProv.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NombreProv.Location = new System.Drawing.Point(289, 69);
            this.NombreProv.Margin = new System.Windows.Forms.Padding(2);
            this.NombreProv.Name = "NombreProv";
            this.NombreProv.Size = new System.Drawing.Size(170, 22);
            this.NombreProv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Corrreo:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de proveedor:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnRegistroProveedores
            // 
            this.btnRegistroProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnRegistroProveedores.FlatAppearance.BorderSize = 0;
            this.btnRegistroProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnRegistroProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroProveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroProveedores.ForeColor = System.Drawing.Color.White;
            this.btnRegistroProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroProveedores.Image")));
            this.btnRegistroProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroProveedores.Location = new System.Drawing.Point(109, 0);
            this.btnRegistroProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistroProveedores.Name = "btnRegistroProveedores";
            this.btnRegistroProveedores.Size = new System.Drawing.Size(109, 40);
            this.btnRegistroProveedores.TabIndex = 9;
            this.btnRegistroProveedores.Text = "       Registros";
            this.btnRegistroProveedores.UseVisualStyleBackColor = false;
            this.btnRegistroProveedores.Click += new System.EventHandler(this.btnRegistroProveedores_Click);
            // 
            // btnAddProveedores
            // 
            this.btnAddProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnAddProveedores.FlatAppearance.BorderSize = 0;
            this.btnAddProveedores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProveedores.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProveedores.ForeColor = System.Drawing.Color.White;
            this.btnAddProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProveedores.Image")));
            this.btnAddProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProveedores.Location = new System.Drawing.Point(0, 0);
            this.btnAddProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProveedores.Name = "btnAddProveedores";
            this.btnAddProveedores.Size = new System.Drawing.Size(109, 40);
            this.btnAddProveedores.TabIndex = 8;
            this.btnAddProveedores.Text = "       Agregar";
            this.btnAddProveedores.UseVisualStyleBackColor = false;
            this.btnAddProveedores.Click += new System.EventHandler(this.btnAddProveedores_Click);
            // 
            // tbTelModificarPro
            // 
            this.tbTelModificarPro.Location = new System.Drawing.Point(166, 235);
            this.tbTelModificarPro.Mask = "0000-0000";
            this.tbTelModificarPro.Name = "tbTelModificarPro";
            this.tbTelModificarPro.Size = new System.Drawing.Size(138, 22);
            this.tbTelModificarPro.TabIndex = 24;
            // 
            // telefonoprov
            // 
            this.telefonoprov.Location = new System.Drawing.Point(287, 165);
            this.telefonoprov.Mask = "0000-0000";
            this.telefonoprov.Name = "telefonoprov";
            this.telefonoprov.Size = new System.Drawing.Size(172, 20);
            this.telefonoprov.TabIndex = 12;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 397);
            this.Controls.Add(this.btnCerrarProveedores);
            this.Controls.Add(this.pRegistrosProveedores);
            this.Controls.Add(this.pAddProveedores);
            this.Controls.Add(this.btnRegistroProveedores);
            this.Controls.Add(this.btnAddProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.pRegistrosProveedores.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.pAddProveedores.ResumeLayout(false);
            this.pAddProveedores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrarProveedores;
        private System.Windows.Forms.Panel pRegistrosProveedores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarProveedores;
        private System.Windows.Forms.Button btnModificarProveedores;
        private System.Windows.Forms.TextBox tbDireccionModificarPro;
        private System.Windows.Forms.TextBox tbCorreoModificarPro;
        private System.Windows.Forms.TextBox tbCodigoModificarPro;
        private System.Windows.Forms.TextBox tbNombreModificarPro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Panel pAddProveedores;
        private System.Windows.Forms.Button btnLimpiarProveedores;
        private System.Windows.Forms.Button btnGuardarProveedores;
        private System.Windows.Forms.TextBox direccionprov;
        private System.Windows.Forms.TextBox correoprov;
        private System.Windows.Forms.TextBox codProv;
        private System.Windows.Forms.TextBox NombreProv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroProveedores;
        private System.Windows.Forms.Button btnAddProveedores;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BuscarProvNom;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.MaskedTextBox tbTelModificarPro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox telefonoprov;
    }
}