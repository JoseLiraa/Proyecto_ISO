namespace SIMATIC
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.btnCerrarProducto = new System.Windows.Forms.Label();
            this.pRegistrosProductos = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NProdBuscar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.NombreProd = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.tbPVentaModificarProducto = new System.Windows.Forms.TextBox();
            this.tbPCostoModificarProducto = new System.Windows.Forms.TextBox();
            this.tbCodigoModificarProducto = new System.Windows.Forms.TextBox();
            this.tbDescripcionModificarProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pAddProducto = new System.Windows.Forms.Panel();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnLimpiarProducto = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.tbPrecioVentaProducto = new System.Windows.Forms.TextBox();
            this.tbPrecioCostoProducto = new System.Windows.Forms.TextBox();
            this.tbCodigoProducto = new System.Windows.Forms.TextBox();
            this.tbDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistroProducto = new System.Windows.Forms.Button();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbUnidadesModificarProducto = new System.Windows.Forms.NumericUpDown();
            this.tbUnidadesProducto = new System.Windows.Forms.NumericUpDown();
            this.pRegistrosProductos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pAddProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadesModificarProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadesProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarProducto
            // 
            this.btnCerrarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarProducto.AutoSize = true;
            this.btnCerrarProducto.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrarProducto.Location = new System.Drawing.Point(969, 6);
            this.btnCerrarProducto.Name = "btnCerrarProducto";
            this.btnCerrarProducto.Size = new System.Drawing.Size(17, 17);
            this.btnCerrarProducto.TabIndex = 12;
            this.btnCerrarProducto.Text = "X";
            this.btnCerrarProducto.Click += new System.EventHandler(this.btnCerrarProducto_Click);
            // 
            // pRegistrosProductos
            // 
            this.pRegistrosProductos.Controls.Add(this.groupBox2);
            this.pRegistrosProductos.Controls.Add(this.groupBox1);
            this.pRegistrosProductos.Controls.Add(this.dgvProductos);
            this.pRegistrosProductos.Location = new System.Drawing.Point(2, 52);
            this.pRegistrosProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRegistrosProductos.Name = "pRegistrosProductos";
            this.pRegistrosProductos.Size = new System.Drawing.Size(989, 411);
            this.pRegistrosProductos.TabIndex = 11;
            this.pRegistrosProductos.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.NProdBuscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(479, 71);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre del producto:";
            // 
            // NProdBuscar
            // 
            this.NProdBuscar.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.NProdBuscar.Location = new System.Drawing.Point(249, 26);
            this.NProdBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NProdBuscar.Name = "NProdBuscar";
            this.NProdBuscar.Size = new System.Drawing.Size(189, 26);
            this.NProdBuscar.TabIndex = 3;
            this.NProdBuscar.TextChanged += new System.EventHandler(this.NProdBuscar_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUnidadesModificarProducto);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.NombreProd);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnEliminarProducto);
            this.groupBox1.Controls.Add(this.btnModificarProducto);
            this.groupBox1.Controls.Add(this.tbPVentaModificarProducto);
            this.groupBox1.Controls.Add(this.tbPCostoModificarProducto);
            this.groupBox1.Controls.Add(this.tbCodigoModificarProducto);
            this.groupBox1.Controls.Add(this.tbDescripcionModificarProducto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(523, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(444, 399);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnlimpiar.Image")));
            this.btnlimpiar.Location = new System.Drawing.Point(333, 332);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(76, 52);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // NombreProd
            // 
            this.NombreProd.Location = new System.Drawing.Point(265, 81);
            this.NombreProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.Size = new System.Drawing.Size(141, 26);
            this.NombreProd.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(197, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Nombre de Producto :";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProducto.Image")));
            this.btnEliminarProducto.Location = new System.Drawing.Point(237, 335);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(76, 52);
            this.btnEliminarProducto.TabIndex = 10;
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarProducto.Image")));
            this.btnModificarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarProducto.Location = new System.Drawing.Point(27, 335);
            this.btnModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(187, 52);
            this.btnModificarProducto.TabIndex = 9;
            this.btnModificarProducto.Text = "       Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // tbPVentaModificarProducto
            // 
            this.tbPVentaModificarProducto.Location = new System.Drawing.Point(264, 281);
            this.tbPVentaModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPVentaModificarProducto.Name = "tbPVentaModificarProducto";
            this.tbPVentaModificarProducto.Size = new System.Drawing.Size(141, 26);
            this.tbPVentaModificarProducto.TabIndex = 8;
            // 
            // tbPCostoModificarProducto
            // 
            this.tbPCostoModificarProducto.Location = new System.Drawing.Point(264, 228);
            this.tbPCostoModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPCostoModificarProducto.Name = "tbPCostoModificarProducto";
            this.tbPCostoModificarProducto.Size = new System.Drawing.Size(141, 26);
            this.tbPCostoModificarProducto.TabIndex = 7;
            // 
            // tbCodigoModificarProducto
            // 
            this.tbCodigoModificarProducto.Enabled = false;
            this.tbCodigoModificarProducto.Location = new System.Drawing.Point(264, 27);
            this.tbCodigoModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoModificarProducto.Name = "tbCodigoModificarProducto";
            this.tbCodigoModificarProducto.ReadOnly = true;
            this.tbCodigoModificarProducto.Size = new System.Drawing.Size(141, 26);
            this.tbCodigoModificarProducto.TabIndex = 4;
            // 
            // tbDescripcionModificarProducto
            // 
            this.tbDescripcionModificarProducto.Location = new System.Drawing.Point(27, 143);
            this.tbDescripcionModificarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescripcionModificarProducto.Name = "tbDescripcionModificarProducto";
            this.tbDescripcionModificarProducto.Size = new System.Drawing.Size(379, 26);
            this.tbDescripcionModificarProducto.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio de venta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio de costo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Unidades disponibles:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(227, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Descripción del producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 21);
            this.label11.TabIndex = 10;
            this.label11.Text = "Código:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 100);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 28;
            this.dgvProductos.Size = new System.Drawing.Size(479, 310);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // pAddProducto
            // 
            this.pAddProducto.Controls.Add(this.tbUnidadesProducto);
            this.pAddProducto.Controls.Add(this.tbNombreProducto);
            this.pAddProducto.Controls.Add(this.label12);
            this.pAddProducto.Controls.Add(this.btnLimpiarProducto);
            this.pAddProducto.Controls.Add(this.btnGuardarProducto);
            this.pAddProducto.Controls.Add(this.tbPrecioVentaProducto);
            this.pAddProducto.Controls.Add(this.tbPrecioCostoProducto);
            this.pAddProducto.Controls.Add(this.tbCodigoProducto);
            this.pAddProducto.Controls.Add(this.tbDescripcionProducto);
            this.pAddProducto.Controls.Add(this.label5);
            this.pAddProducto.Controls.Add(this.label4);
            this.pAddProducto.Controls.Add(this.label3);
            this.pAddProducto.Controls.Add(this.label2);
            this.pAddProducto.Controls.Add(this.label1);
            this.pAddProducto.Location = new System.Drawing.Point(12, 52);
            this.pAddProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAddProducto.Name = "pAddProducto";
            this.pAddProducto.Size = new System.Drawing.Size(988, 389);
            this.pAddProducto.TabIndex = 10;
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombreProducto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbNombreProducto.Location = new System.Drawing.Point(388, 86);
            this.tbNombreProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(323, 26);
            this.tbNombreProducto.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 21);
            this.label12.TabIndex = 12;
            this.label12.Text = "Nombre del producto:";
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarProducto.Image")));
            this.btnLimpiarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarProducto.Location = new System.Drawing.Point(529, 277);
            this.btnLimpiarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(181, 55);
            this.btnLimpiarProducto.TabIndex = 19;
            this.btnLimpiarProducto.Text = "       Limpiar";
            this.btnLimpiarProducto.UseVisualStyleBackColor = true;
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarProducto.Image")));
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProducto.Location = new System.Drawing.Point(145, 277);
            this.btnGuardarProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(181, 55);
            this.btnGuardarProducto.TabIndex = 18;
            this.btnGuardarProducto.Text = "       Guardar";
            this.btnGuardarProducto.UseVisualStyleBackColor = true;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // tbPrecioVentaProducto
            // 
            this.tbPrecioVentaProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecioVentaProducto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPrecioVentaProducto.Location = new System.Drawing.Point(388, 241);
            this.tbPrecioVentaProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrecioVentaProducto.Name = "tbPrecioVentaProducto";
            this.tbPrecioVentaProducto.Size = new System.Drawing.Size(323, 26);
            this.tbPrecioVentaProducto.TabIndex = 17;
            // 
            // tbPrecioCostoProducto
            // 
            this.tbPrecioCostoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPrecioCostoProducto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPrecioCostoProducto.Location = new System.Drawing.Point(388, 198);
            this.tbPrecioCostoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrecioCostoProducto.Name = "tbPrecioCostoProducto";
            this.tbPrecioCostoProducto.Size = new System.Drawing.Size(323, 26);
            this.tbPrecioCostoProducto.TabIndex = 16;
            // 
            // tbCodigoProducto
            // 
            this.tbCodigoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCodigoProducto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbCodigoProducto.Location = new System.Drawing.Point(388, 54);
            this.tbCodigoProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCodigoProducto.Name = "tbCodigoProducto";
            this.tbCodigoProducto.Size = new System.Drawing.Size(323, 26);
            this.tbCodigoProducto.TabIndex = 12;
            // 
            // tbDescripcionProducto
            // 
            this.tbDescripcionProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcionProducto.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbDescripcionProducto.Location = new System.Drawing.Point(388, 124);
            this.tbDescripcionProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescripcionProducto.Name = "tbDescripcionProducto";
            this.tbDescripcionProducto.Size = new System.Drawing.Size(323, 26);
            this.tbDescripcionProducto.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(141, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de costo:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unidades:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción del producto:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnRegistroProducto
            // 
            this.btnRegistroProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnRegistroProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistroProducto.FlatAppearance.BorderSize = 0;
            this.btnRegistroProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistroProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroProducto.ForeColor = System.Drawing.Color.White;
            this.btnRegistroProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroProducto.Image")));
            this.btnRegistroProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroProducto.Location = new System.Drawing.Point(145, -1);
            this.btnRegistroProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistroProducto.Name = "btnRegistroProducto";
            this.btnRegistroProducto.Size = new System.Drawing.Size(145, 49);
            this.btnRegistroProducto.TabIndex = 2;
            this.btnRegistroProducto.Text = "       Registros";
            this.btnRegistroProducto.UseVisualStyleBackColor = false;
            this.btnRegistroProducto.Click += new System.EventHandler(this.btnRegistroProducto_Click);
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnAddProducto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddProducto.FlatAppearance.BorderSize = 0;
            this.btnAddProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducto.ForeColor = System.Drawing.Color.White;
            this.btnAddProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProducto.Image")));
            this.btnAddProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProducto.Location = new System.Drawing.Point(0, -1);
            this.btnAddProducto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Size = new System.Drawing.Size(145, 49);
            this.btnAddProducto.TabIndex = 1;
            this.btnAddProducto.Text = "       Agregar";
            this.btnAddProducto.UseVisualStyleBackColor = false;
            this.btnAddProducto.Click += new System.EventHandler(this.btnAddProducto_Click);
            // 
            // tbUnidadesModificarProducto
            // 
            this.tbUnidadesModificarProducto.Location = new System.Drawing.Point(264, 185);
            this.tbUnidadesModificarProducto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbUnidadesModificarProducto.Name = "tbUnidadesModificarProducto";
            this.tbUnidadesModificarProducto.Size = new System.Drawing.Size(145, 26);
            this.tbUnidadesModificarProducto.TabIndex = 6;
            // 
            // tbUnidadesProducto
            // 
            this.tbUnidadesProducto.Location = new System.Drawing.Point(388, 163);
            this.tbUnidadesProducto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.tbUnidadesProducto.Name = "tbUnidadesProducto";
            this.tbUnidadesProducto.Size = new System.Drawing.Size(323, 22);
            this.tbUnidadesProducto.TabIndex = 15;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 489);
            this.Controls.Add(this.btnCerrarProducto);
            this.Controls.Add(this.pAddProducto);
            this.Controls.Add(this.pRegistrosProductos);
            this.Controls.Add(this.btnRegistroProducto);
            this.Controls.Add(this.btnAddProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.pRegistrosProductos.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pAddProducto.ResumeLayout(false);
            this.pAddProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadesModificarProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnidadesProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrarProducto;
        private System.Windows.Forms.Panel pRegistrosProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.TextBox tbPVentaModificarProducto;
        private System.Windows.Forms.TextBox tbPCostoModificarProducto;
        private System.Windows.Forms.TextBox tbCodigoModificarProducto;
        private System.Windows.Forms.TextBox tbDescripcionModificarProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel pAddProducto;
        private System.Windows.Forms.Button btnLimpiarProducto;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.TextBox tbPrecioVentaProducto;
        private System.Windows.Forms.TextBox tbPrecioCostoProducto;
        private System.Windows.Forms.TextBox tbCodigoProducto;
        private System.Windows.Forms.TextBox tbDescripcionProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistroProducto;
        private System.Windows.Forms.Button btnAddProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.TextBox tbNombreProducto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NProdBuscar;
        private System.Windows.Forms.TextBox NombreProd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.NumericUpDown tbUnidadesModificarProducto;
        private System.Windows.Forms.NumericUpDown tbUnidadesProducto;
    }
}