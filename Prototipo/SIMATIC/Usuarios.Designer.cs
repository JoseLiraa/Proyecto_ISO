namespace SIMATIC
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.btnCerrarCliente = new System.Windows.Forms.Label();
            this.pRegistrosUsuarios = new System.Windows.Forms.Panel();
            this.lblIdUsuarioRol = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNombreBuscarUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUsuarioId = new System.Windows.Forms.Label();
            this.lblIdRol = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbTelefonoModificarUsuarios = new System.Windows.Forms.MaskedTextBox();
            this.cbRolModificarUsuarios = new System.Windows.Forms.ComboBox();
            this.tbCorreoModificarUsuarios = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbRespuestaModificarUsuarios = new System.Windows.Forms.TextBox();
            this.tbPreguntaModificarUsuarios = new System.Windows.Forms.TextBox();
            this.tbClaveModificarUsuarios = new System.Windows.Forms.TextBox();
            this.tbNombreModificarUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.pAddUsuarios = new System.Windows.Forms.Panel();
            this.lblRolID = new System.Windows.Forms.Label();
            this.lblidusuario = new System.Windows.Forms.Label();
            this.tbTelefonoUsuario = new System.Windows.Forms.MaskedTextBox();
            this.cbRolUsuario = new System.Windows.Forms.ComboBox();
            this.tbCorreoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRespuestaUsuario = new System.Windows.Forms.TextBox();
            this.tbPreguntaUsuario = new System.Windows.Forms.TextBox();
            this.tbClaveUsuario = new System.Windows.Forms.TextBox();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLimpiarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.btnRegistroUsuarios = new System.Windows.Forms.Button();
            this.btnAddUsuarios = new System.Windows.Forms.Button();
            this.btnCerrarUsuarios = new System.Windows.Forms.Label();
            this.pRegistrosUsuarios.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.pAddUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarCliente
            // 
            this.btnCerrarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarCliente.AutoSize = true;
            this.btnCerrarCliente.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrarCliente.Location = new System.Drawing.Point(1065, 18);
            this.btnCerrarCliente.Name = "btnCerrarCliente";
            this.btnCerrarCliente.Size = new System.Drawing.Size(17, 17);
            this.btnCerrarCliente.TabIndex = 12;
            this.btnCerrarCliente.Text = "X";
            // 
            // pRegistrosUsuarios
            // 
            this.pRegistrosUsuarios.Controls.Add(this.lblIdUsuarioRol);
            this.pRegistrosUsuarios.Controls.Add(this.groupBox2);
            this.pRegistrosUsuarios.Controls.Add(this.lblUsuarioId);
            this.pRegistrosUsuarios.Controls.Add(this.lblIdRol);
            this.pRegistrosUsuarios.Controls.Add(this.groupBox1);
            this.pRegistrosUsuarios.Controls.Add(this.dgvUsuarios);
            this.pRegistrosUsuarios.Location = new System.Drawing.Point(3, 53);
            this.pRegistrosUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pRegistrosUsuarios.Name = "pRegistrosUsuarios";
            this.pRegistrosUsuarios.Size = new System.Drawing.Size(988, 425);
            this.pRegistrosUsuarios.TabIndex = 11;
            this.pRegistrosUsuarios.Visible = false;
            this.pRegistrosUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.pRegistrosUsuarios_Paint);
            // 
            // lblIdUsuarioRol
            // 
            this.lblIdUsuarioRol.AutoSize = true;
            this.lblIdUsuarioRol.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUsuarioRol.Location = new System.Drawing.Point(441, 9);
            this.lblIdUsuarioRol.Name = "lblIdUsuarioRol";
            this.lblIdUsuarioRol.Size = new System.Drawing.Size(66, 21);
            this.lblIdUsuarioRol.TabIndex = 33;
            this.lblIdUsuarioRol.Text = "Clave:";
            this.lblIdUsuarioRol.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNombreBuscarUsuario);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(24, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(411, 68);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Usuario";
            // 
            // tbNombreBuscarUsuario
            // 
            this.tbNombreBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbNombreBuscarUsuario.Location = new System.Drawing.Point(124, 20);
            this.tbNombreBuscarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreBuscarUsuario.Name = "tbNombreBuscarUsuario";
            this.tbNombreBuscarUsuario.Size = new System.Drawing.Size(259, 26);
            this.tbNombreBuscarUsuario.TabIndex = 3;
            this.tbNombreBuscarUsuario.TextChanged += new System.EventHandler(this.tbNombreBuscarUsuario_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nombre:";
            // 
            // lblUsuarioId
            // 
            this.lblUsuarioId.AutoSize = true;
            this.lblUsuarioId.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioId.Location = new System.Drawing.Point(441, 34);
            this.lblUsuarioId.Name = "lblUsuarioId";
            this.lblUsuarioId.Size = new System.Drawing.Size(66, 21);
            this.lblUsuarioId.TabIndex = 30;
            this.lblUsuarioId.Text = "Clave:";
            this.lblUsuarioId.Visible = false;
            // 
            // lblIdRol
            // 
            this.lblIdRol.AutoSize = true;
            this.lblIdRol.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdRol.Location = new System.Drawing.Point(441, 57);
            this.lblIdRol.Name = "lblIdRol";
            this.lblIdRol.Size = new System.Drawing.Size(66, 21);
            this.lblIdRol.TabIndex = 31;
            this.lblIdRol.Text = "Clave:";
            this.lblIdRol.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbTelefonoModificarUsuarios);
            this.groupBox1.Controls.Add(this.cbRolModificarUsuarios);
            this.groupBox1.Controls.Add(this.tbCorreoModificarUsuarios);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnEliminarCliente);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.tbRespuestaModificarUsuarios);
            this.groupBox1.Controls.Add(this.tbPreguntaModificarUsuarios);
            this.groupBox1.Controls.Add(this.tbClaveModificarUsuarios);
            this.groupBox1.Controls.Add(this.tbNombreModificarUsuario);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(523, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(463, 399);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // tbTelefonoModificarUsuarios
            // 
            this.tbTelefonoModificarUsuarios.Location = new System.Drawing.Point(221, 239);
            this.tbTelefonoModificarUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefonoModificarUsuarios.Mask = "0000-0000";
            this.tbTelefonoModificarUsuarios.Name = "tbTelefonoModificarUsuarios";
            this.tbTelefonoModificarUsuarios.Size = new System.Drawing.Size(224, 26);
            this.tbTelefonoModificarUsuarios.TabIndex = 9;
            // 
            // cbRolModificarUsuarios
            // 
            this.cbRolModificarUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRolModificarUsuarios.FormattingEnabled = true;
            this.cbRolModificarUsuarios.Location = new System.Drawing.Point(221, 283);
            this.cbRolModificarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRolModificarUsuarios.Name = "cbRolModificarUsuarios";
            this.cbRolModificarUsuarios.Size = new System.Drawing.Size(224, 28);
            this.cbRolModificarUsuarios.TabIndex = 10;
            // 
            // tbCorreoModificarUsuarios
            // 
            this.tbCorreoModificarUsuarios.Location = new System.Drawing.Point(221, 201);
            this.tbCorreoModificarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorreoModificarUsuarios.Name = "tbCorreoModificarUsuarios";
            this.tbCorreoModificarUsuarios.Size = new System.Drawing.Size(224, 26);
            this.tbCorreoModificarUsuarios.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Rol:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "Teléfono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "Corrreo:";
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCliente.Image")));
            this.btnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCliente.Location = new System.Drawing.Point(240, 335);
            this.btnEliminarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(187, 52);
            this.btnEliminarCliente.TabIndex = 12;
            this.btnEliminarCliente.Text = "       Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(27, 335);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "       Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbRespuestaModificarUsuarios
            // 
            this.tbRespuestaModificarUsuarios.Location = new System.Drawing.Point(221, 159);
            this.tbRespuestaModificarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRespuestaModificarUsuarios.Name = "tbRespuestaModificarUsuarios";
            this.tbRespuestaModificarUsuarios.Size = new System.Drawing.Size(224, 26);
            this.tbRespuestaModificarUsuarios.TabIndex = 7;
            // 
            // tbPreguntaModificarUsuarios
            // 
            this.tbPreguntaModificarUsuarios.Location = new System.Drawing.Point(221, 117);
            this.tbPreguntaModificarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPreguntaModificarUsuarios.Name = "tbPreguntaModificarUsuarios";
            this.tbPreguntaModificarUsuarios.Size = new System.Drawing.Size(224, 26);
            this.tbPreguntaModificarUsuarios.TabIndex = 6;
            // 
            // tbClaveModificarUsuarios
            // 
            this.tbClaveModificarUsuarios.Location = new System.Drawing.Point(221, 76);
            this.tbClaveModificarUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClaveModificarUsuarios.Name = "tbClaveModificarUsuarios";
            this.tbClaveModificarUsuarios.Size = new System.Drawing.Size(224, 26);
            this.tbClaveModificarUsuarios.TabIndex = 5;
            // 
            // tbNombreModificarUsuario
            // 
            this.tbNombreModificarUsuario.Location = new System.Drawing.Point(221, 37);
            this.tbNombreModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreModificarUsuario.Name = "tbNombreModificarUsuario";
            this.tbNombreModificarUsuario.Size = new System.Drawing.Size(224, 26);
            this.tbNombreModificarUsuario.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Respuesta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Pregunta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Clave:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 21);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nombre de usuario:";
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToResizeColumns = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(11, 100);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 28;
            this.dgvUsuarios.Size = new System.Drawing.Size(471, 310);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // pAddUsuarios
            // 
            this.pAddUsuarios.Controls.Add(this.lblRolID);
            this.pAddUsuarios.Controls.Add(this.lblidusuario);
            this.pAddUsuarios.Controls.Add(this.tbTelefonoUsuario);
            this.pAddUsuarios.Controls.Add(this.cbRolUsuario);
            this.pAddUsuarios.Controls.Add(this.tbCorreoUsuario);
            this.pAddUsuarios.Controls.Add(this.label1);
            this.pAddUsuarios.Controls.Add(this.label2);
            this.pAddUsuarios.Controls.Add(this.label3);
            this.pAddUsuarios.Controls.Add(this.tbRespuestaUsuario);
            this.pAddUsuarios.Controls.Add(this.tbPreguntaUsuario);
            this.pAddUsuarios.Controls.Add(this.tbClaveUsuario);
            this.pAddUsuarios.Controls.Add(this.tbNombreUsuario);
            this.pAddUsuarios.Controls.Add(this.label4);
            this.pAddUsuarios.Controls.Add(this.label5);
            this.pAddUsuarios.Controls.Add(this.label14);
            this.pAddUsuarios.Controls.Add(this.label15);
            this.pAddUsuarios.Controls.Add(this.btnLimpiarUsuario);
            this.pAddUsuarios.Controls.Add(this.btnGuardarUsuario);
            this.pAddUsuarios.Location = new System.Drawing.Point(0, 63);
            this.pAddUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pAddUsuarios.Name = "pAddUsuarios";
            this.pAddUsuarios.Size = new System.Drawing.Size(885, 354);
            this.pAddUsuarios.TabIndex = 10;
            // 
            // lblRolID
            // 
            this.lblRolID.AutoSize = true;
            this.lblRolID.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRolID.Location = new System.Drawing.Point(672, 322);
            this.lblRolID.Name = "lblRolID";
            this.lblRolID.Size = new System.Drawing.Size(39, 21);
            this.lblRolID.TabIndex = 45;
            this.lblRolID.Text = "Rol:";
            this.lblRolID.Visible = false;
            // 
            // lblidusuario
            // 
            this.lblidusuario.AutoSize = true;
            this.lblidusuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidusuario.Location = new System.Drawing.Point(672, 292);
            this.lblidusuario.Name = "lblidusuario";
            this.lblidusuario.Size = new System.Drawing.Size(39, 21);
            this.lblidusuario.TabIndex = 44;
            this.lblidusuario.Text = "Rol:";
            this.lblidusuario.Visible = false;
            // 
            // tbTelefonoUsuario
            // 
            this.tbTelefonoUsuario.Location = new System.Drawing.Point(717, 69);
            this.tbTelefonoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tbTelefonoUsuario.Mask = "0000-0000";
            this.tbTelefonoUsuario.Name = "tbTelefonoUsuario";
            this.tbTelefonoUsuario.Size = new System.Drawing.Size(132, 22);
            this.tbTelefonoUsuario.TabIndex = 20;
            this.tbTelefonoUsuario.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tbTelefonoUsuario_MaskInputRejected);
            // 
            // cbRolUsuario
            // 
            this.cbRolUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRolUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.cbRolUsuario.FormattingEnabled = true;
            this.cbRolUsuario.Location = new System.Drawing.Point(717, 117);
            this.cbRolUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRolUsuario.Name = "cbRolUsuario";
            this.cbRolUsuario.Size = new System.Drawing.Size(141, 28);
            this.cbRolUsuario.TabIndex = 21;
            // 
            // tbCorreoUsuario
            // 
            this.tbCorreoUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbCorreoUsuario.Location = new System.Drawing.Point(717, 28);
            this.tbCorreoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCorreoUsuario.Name = "tbCorreoUsuario";
            this.tbCorreoUsuario.Size = new System.Drawing.Size(141, 26);
            this.tbCorreoUsuario.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Corrreo:";
            // 
            // tbRespuestaUsuario
            // 
            this.tbRespuestaUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbRespuestaUsuario.Location = new System.Drawing.Point(241, 159);
            this.tbRespuestaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRespuestaUsuario.Name = "tbRespuestaUsuario";
            this.tbRespuestaUsuario.Size = new System.Drawing.Size(224, 26);
            this.tbRespuestaUsuario.TabIndex = 18;
            // 
            // tbPreguntaUsuario
            // 
            this.tbPreguntaUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbPreguntaUsuario.Location = new System.Drawing.Point(241, 118);
            this.tbPreguntaUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPreguntaUsuario.Name = "tbPreguntaUsuario";
            this.tbPreguntaUsuario.Size = new System.Drawing.Size(224, 26);
            this.tbPreguntaUsuario.TabIndex = 17;
            // 
            // tbClaveUsuario
            // 
            this.tbClaveUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbClaveUsuario.Location = new System.Drawing.Point(247, 74);
            this.tbClaveUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClaveUsuario.Name = "tbClaveUsuario";
            this.tbClaveUsuario.Size = new System.Drawing.Size(141, 26);
            this.tbClaveUsuario.TabIndex = 16;
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.tbNombreUsuario.Location = new System.Drawing.Point(247, 34);
            this.tbNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(141, 26);
            this.tbNombreUsuario.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Respuesta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Pregunta:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(48, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 21);
            this.label14.TabIndex = 29;
            this.label14.Text = "Clave:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(48, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(173, 21);
            this.label15.TabIndex = 28;
            this.label15.Text = "Nombre de usuario:";
            // 
            // btnLimpiarUsuario
            // 
            this.btnLimpiarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnLimpiarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarUsuario.Image")));
            this.btnLimpiarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarUsuario.Location = new System.Drawing.Point(677, 218);
            this.btnLimpiarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiarUsuario.Name = "btnLimpiarUsuario";
            this.btnLimpiarUsuario.Size = new System.Drawing.Size(181, 55);
            this.btnLimpiarUsuario.TabIndex = 23;
            this.btnLimpiarUsuario.Text = "       Limpiar";
            this.btnLimpiarUsuario.UseVisualStyleBackColor = true;
            this.btnLimpiarUsuario.Click += new System.EventHandler(this.btnLimpiarUsuario_Click);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUsuario.Image")));
            this.btnGuardarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(47, 218);
            this.btnGuardarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(181, 55);
            this.btnGuardarUsuario.TabIndex = 22;
            this.btnGuardarUsuario.Text = "       Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            // 
            // btnRegistroUsuarios
            // 
            this.btnRegistroUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnRegistroUsuarios.FlatAppearance.BorderSize = 0;
            this.btnRegistroUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnRegistroUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnRegistroUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroUsuarios.Image")));
            this.btnRegistroUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistroUsuarios.Location = new System.Drawing.Point(145, 0);
            this.btnRegistroUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistroUsuarios.Name = "btnRegistroUsuarios";
            this.btnRegistroUsuarios.Size = new System.Drawing.Size(145, 49);
            this.btnRegistroUsuarios.TabIndex = 2;
            this.btnRegistroUsuarios.Text = "       Registros";
            this.btnRegistroUsuarios.UseVisualStyleBackColor = false;
            this.btnRegistroUsuarios.Click += new System.EventHandler(this.btnRegistroUsuarios_Click);
            // 
            // btnAddUsuarios
            // 
            this.btnAddUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(113)))), ((int)(((byte)(179)))));
            this.btnAddUsuarios.FlatAppearance.BorderSize = 0;
            this.btnAddUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAddUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUsuarios.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnAddUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUsuarios.Image")));
            this.btnAddUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnAddUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUsuarios.Name = "btnAddUsuarios";
            this.btnAddUsuarios.Size = new System.Drawing.Size(145, 49);
            this.btnAddUsuarios.TabIndex = 1;
            this.btnAddUsuarios.Text = "       Agregar";
            this.btnAddUsuarios.UseVisualStyleBackColor = false;
            this.btnAddUsuarios.Click += new System.EventHandler(this.btnAddUsuarios_Click);
            // 
            // btnCerrarUsuarios
            // 
            this.btnCerrarUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarUsuarios.AutoSize = true;
            this.btnCerrarUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCerrarUsuarios.Location = new System.Drawing.Point(969, 7);
            this.btnCerrarUsuarios.Name = "btnCerrarUsuarios";
            this.btnCerrarUsuarios.Size = new System.Drawing.Size(17, 17);
            this.btnCerrarUsuarios.TabIndex = 13;
            this.btnCerrarUsuarios.Text = "X";
            this.btnCerrarUsuarios.Click += new System.EventHandler(this.btnCerrarUsuarios_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 489);
            this.Controls.Add(this.btnCerrarUsuarios);
            this.Controls.Add(this.btnCerrarCliente);
            this.Controls.Add(this.btnRegistroUsuarios);
            this.Controls.Add(this.btnAddUsuarios);
            this.Controls.Add(this.pRegistrosUsuarios);
            this.Controls.Add(this.pAddUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.pRegistrosUsuarios.ResumeLayout(false);
            this.pRegistrosUsuarios.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.pAddUsuarios.ResumeLayout(false);
            this.pAddUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnCerrarCliente;
        private System.Windows.Forms.Panel pRegistrosUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbRespuestaModificarUsuarios;
        private System.Windows.Forms.TextBox tbPreguntaModificarUsuarios;
        private System.Windows.Forms.TextBox tbClaveModificarUsuarios;
        private System.Windows.Forms.TextBox tbNombreModificarUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel pAddUsuarios;
        private System.Windows.Forms.Button btnLimpiarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.Button btnRegistroUsuarios;
        private System.Windows.Forms.Button btnAddUsuarios;
        private System.Windows.Forms.TextBox tbCorreoModificarUsuarios;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label btnCerrarUsuarios;
        private System.Windows.Forms.ComboBox cbRolModificarUsuarios;
        private System.Windows.Forms.ComboBox cbRolUsuario;
        private System.Windows.Forms.TextBox tbCorreoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRespuestaUsuario;
        private System.Windows.Forms.TextBox tbPreguntaUsuario;
        private System.Windows.Forms.TextBox tbClaveUsuario;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox tbTelefonoModificarUsuarios;
        private System.Windows.Forms.MaskedTextBox tbTelefonoUsuario;
        private System.Windows.Forms.Label lblUsuarioId;
        private System.Windows.Forms.Label lblIdRol;
        private System.Windows.Forms.Label lblRolID;
        private System.Windows.Forms.Label lblidusuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNombreBuscarUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblIdUsuarioRol;
    }
}