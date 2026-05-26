namespace pryTabordaEDS
{
    partial class FrmGrafo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrafo));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTramiteEliminar = new System.Windows.Forms.Label();
            this.lblNombreEliminar = new System.Windows.Forms.Label();
            this.lblCodigoEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVerTodosLosViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.lblTramiteEliminar);
            this.groupBox2.Controls.Add(this.lblNombreEliminar);
            this.groupBox2.Controls.Add(this.lblCodigoEliminar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(459, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 181);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta De Datos";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(80, 67);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(80, 30);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 100);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // lblTramiteEliminar
            // 
            this.lblTramiteEliminar.AutoSize = true;
            this.lblTramiteEliminar.Location = new System.Drawing.Point(8, 103);
            this.lblTramiteEliminar.Name = "lblTramiteEliminar";
            this.lblTramiteEliminar.Size = new System.Drawing.Size(40, 13);
            this.lblTramiteEliminar.TabIndex = 3;
            this.lblTramiteEliminar.Text = "Precio:";
            this.lblTramiteEliminar.Click += new System.EventHandler(this.lblTramiteEliminar_Click);
            // 
            // lblNombreEliminar
            // 
            this.lblNombreEliminar.AutoSize = true;
            this.lblNombreEliminar.Location = new System.Drawing.Point(6, 67);
            this.lblNombreEliminar.Name = "lblNombreEliminar";
            this.lblNombreEliminar.Size = new System.Drawing.Size(43, 13);
            this.lblNombreEliminar.TabIndex = 2;
            this.lblNombreEliminar.Text = "Destino";
            // 
            // lblCodigoEliminar
            // 
            this.lblCodigoEliminar.AutoSize = true;
            this.lblCodigoEliminar.Location = new System.Drawing.Point(10, 33);
            this.lblCodigoEliminar.Name = "lblCodigoEliminar";
            this.lblCodigoEliminar.Size = new System.Drawing.Size(38, 13);
            this.lblCodigoEliminar.TabIndex = 1;
            this.lblCodigoEliminar.Text = "Origen";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(97, 139);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(86, 23);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtTramite);
            this.groupBox1.Controls.Add(this.lblTramite);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(207, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 181);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Carga de Datos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(84, 67);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(95, 100);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(110, 20);
            this.txtTramite.TabIndex = 6;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(6, 103);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(40, 13);
            this.lblTramite.TabIndex = 3;
            this.lblTramite.Text = "Precio:";
            this.lblTramite.Click += new System.EventHandler(this.lblTramite_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(43, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Destino";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(38, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Origen";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 139);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Borrar Todo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column2,
            this.Column3});
            this.dgvPila.Location = new System.Drawing.Point(0, 72);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.Size = new System.Drawing.Size(654, 215);
            this.dgvPila.TabIndex = 10;
            this.dgvPila.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPila_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Origen";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cordoba";
            this.Column1.Name = "Column1";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mendoza";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Santa Fe";
            this.Column5.Name = "Column5";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Buenos Aires";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Salta";
            this.Column3.Name = "Column3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVerTodosLosViajes);
            this.groupBox3.Controls.Add(this.btnListarOrigenes);
            this.groupBox3.Controls.Add(this.cmbHasta);
            this.groupBox3.Controls.Add(this.lblHasta);
            this.groupBox3.Controls.Add(this.btnListarDestinos);
            this.groupBox3.Controls.Add(this.cmbDesde);
            this.groupBox3.Controls.Add(this.lblDesde);
            this.groupBox3.Controls.Add(this.dgvPila);
            this.groupBox3.Location = new System.Drawing.Point(12, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 298);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de viajes";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnVerTodosLosViajes
            // 
            this.btnVerTodosLosViajes.Location = new System.Drawing.Point(520, 49);
            this.btnVerTodosLosViajes.Name = "btnVerTodosLosViajes";
            this.btnVerTodosLosViajes.Size = new System.Drawing.Size(115, 23);
            this.btnVerTodosLosViajes.TabIndex = 17;
            this.btnVerTodosLosViajes.Text = "Ver todos los viajes";
            this.btnVerTodosLosViajes.UseVisualStyleBackColor = true;
            this.btnVerTodosLosViajes.Click += new System.EventHandler(this.btnVerTodosLosViajes_Click_1);
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(520, 25);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(115, 23);
            this.btnListarOrigenes.TabIndex = 16;
            this.btnListarOrigenes.Text = "Listar Origenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // cmbHasta
            // 
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Items.AddRange(new object[] {
            "Cordoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbHasta.Location = new System.Drawing.Point(381, 27);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(121, 21);
            this.cmbHasta.TabIndex = 15;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(334, 31);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 14;
            this.lblHasta.Text = "Hasta";
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(203, 25);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(115, 23);
            this.btnListarDestinos.TabIndex = 13;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbDesde
            // 
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Items.AddRange(new object[] {
            "Cordoba",
            "Mendoza",
            "Santa Fe",
            "Buenos Aires",
            "Salta"});
            this.cmbDesde.Location = new System.Drawing.Point(64, 27);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(121, 21);
            this.cmbDesde.TabIndex = 12;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(17, 31);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 11;
            this.lblDesde.Text = "Desde:";
            // 
            // FrmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGrafo";
            this.Text = "FrmGrafo";
            this.Load += new System.EventHandler(this.FrmGrafo_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTramiteEliminar;
        private System.Windows.Forms.Label lblNombreEliminar;
        private System.Windows.Forms.Label lblCodigoEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnVerTodosLosViajes;
    }
}
