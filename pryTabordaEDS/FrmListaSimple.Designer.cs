namespace pryTabordaEDS
{
    partial class FrmListaSimple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox ptbxImagen;
        private System.Windows.Forms.GroupBox grpNuevo;
        private System.Windows.Forms.GroupBox grpEliminado;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.Label lblCodigoNuevo;
        private System.Windows.Forms.Label lblNombreNuevo;
        private System.Windows.Forms.Label lblTramiteNuevo;
        private System.Windows.Forms.TextBox txtCodigoNuevo;
        private System.Windows.Forms.TextBox txtNombreNuevo;
        private System.Windows.Forms.TextBox txtTramiteNuevo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCodigoElim;
        private System.Windows.Forms.TextBox txtNombreElim;
        private System.Windows.Forms.TextBox txtTramiteElim;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListBox lstListaSimple;
        private System.Windows.Forms.DataGridView dgvListaSimple;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaSimple));
            this.ptbxImagen = new System.Windows.Forms.PictureBox();
            this.grpNuevo = new System.Windows.Forms.GroupBox();
            this.lblCodigoNuevo = new System.Windows.Forms.Label();
            this.lblNombreNuevo = new System.Windows.Forms.Label();
            this.lblTramiteNuevo = new System.Windows.Forms.Label();
            this.txtCodigoNuevo = new System.Windows.Forms.TextBox();
            this.txtNombreNuevo = new System.Windows.Forms.TextBox();
            this.txtTramiteNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpEliminado = new System.Windows.Forms.GroupBox();
            this.txtCodigoElim = new System.Windows.Forms.TextBox();
            this.txtNombreElim = new System.Windows.Forms.TextBox();
            this.txtTramiteElim = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.lstListaSimple = new System.Windows.Forms.ListBox();
            this.dgvListaSimple = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).BeginInit();
            this.grpNuevo.SuspendLayout();
            this.grpEliminado.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbxImagen
            // 
            this.ptbxImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbxImagen.Image = ((System.Drawing.Image)(resources.GetObject("ptbxImagen.Image")));
            this.ptbxImagen.Location = new System.Drawing.Point(12, 12);
            this.ptbxImagen.Name = "ptbxImagen";
            this.ptbxImagen.Size = new System.Drawing.Size(170, 160);
            this.ptbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxImagen.TabIndex = 0;
            this.ptbxImagen.TabStop = false;
            // 
            // grpNuevo
            // 
            this.grpNuevo.Controls.Add(this.lblCodigoNuevo);
            this.grpNuevo.Controls.Add(this.lblNombreNuevo);
            this.grpNuevo.Controls.Add(this.lblTramiteNuevo);
            this.grpNuevo.Controls.Add(this.txtCodigoNuevo);
            this.grpNuevo.Controls.Add(this.txtNombreNuevo);
            this.grpNuevo.Controls.Add(this.txtTramiteNuevo);
            this.grpNuevo.Controls.Add(this.btnAgregar);
            this.grpNuevo.Location = new System.Drawing.Point(200, 12);
            this.grpNuevo.Name = "grpNuevo";
            this.grpNuevo.Size = new System.Drawing.Size(220, 160);
            this.grpNuevo.TabIndex = 1;
            this.grpNuevo.TabStop = false;
            this.grpNuevo.Text = "Nuevo Elemento";
            // 
            // lblCodigoNuevo
            // 
            this.lblCodigoNuevo.AutoSize = true;
            this.lblCodigoNuevo.Location = new System.Drawing.Point(12, 28);
            this.lblCodigoNuevo.Name = "lblCodigoNuevo";
            this.lblCodigoNuevo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoNuevo.TabIndex = 0;
            this.lblCodigoNuevo.Text = "Código:";
            // 
            // lblNombreNuevo
            // 
            this.lblNombreNuevo.AutoSize = true;
            this.lblNombreNuevo.Location = new System.Drawing.Point(12, 58);
            this.lblNombreNuevo.Name = "lblNombreNuevo";
            this.lblNombreNuevo.Size = new System.Drawing.Size(47, 13);
            this.lblNombreNuevo.TabIndex = 1;
            this.lblNombreNuevo.Text = "Nombre:";
            // 
            // lblTramiteNuevo
            // 
            this.lblTramiteNuevo.AutoSize = true;
            this.lblTramiteNuevo.Location = new System.Drawing.Point(12, 88);
            this.lblTramiteNuevo.Name = "lblTramiteNuevo";
            this.lblTramiteNuevo.Size = new System.Drawing.Size(45, 13);
            this.lblTramiteNuevo.TabIndex = 2;
            this.lblTramiteNuevo.Text = "Trámite:";
            // 
            // txtCodigoNuevo
            // 
            this.txtCodigoNuevo.Location = new System.Drawing.Point(80, 25);
            this.txtCodigoNuevo.Name = "txtCodigoNuevo";
            this.txtCodigoNuevo.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoNuevo.TabIndex = 3;
            // 
            // txtNombreNuevo
            // 
            this.txtNombreNuevo.Location = new System.Drawing.Point(80, 55);
            this.txtNombreNuevo.Name = "txtNombreNuevo";
            this.txtNombreNuevo.Size = new System.Drawing.Size(120, 20);
            this.txtNombreNuevo.TabIndex = 4;
            // 
            // txtTramiteNuevo
            // 
            this.txtTramiteNuevo.Location = new System.Drawing.Point(80, 85);
            this.txtTramiteNuevo.Name = "txtTramiteNuevo";
            this.txtTramiteNuevo.Size = new System.Drawing.Size(120, 20);
            this.txtTramiteNuevo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(55, 115);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 25);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grpEliminado
            // 
            this.grpEliminado.Controls.Add(this.txtCodigoElim);
            this.grpEliminado.Controls.Add(this.txtNombreElim);
            this.grpEliminado.Controls.Add(this.txtTramiteElim);
            this.grpEliminado.Controls.Add(this.btnEliminar);
            this.grpEliminado.Location = new System.Drawing.Point(440, 12);
            this.grpEliminado.Name = "grpEliminado";
            this.grpEliminado.Size = new System.Drawing.Size(220, 160);
            this.grpEliminado.TabIndex = 2;
            this.grpEliminado.TabStop = false;
            this.grpEliminado.Text = "Elemento Eliminado";
            // 
            // txtCodigoElim
            // 
            this.txtCodigoElim.Location = new System.Drawing.Point(80, 25);
            this.txtCodigoElim.Name = "txtCodigoElim";
            this.txtCodigoElim.ReadOnly = true;
            this.txtCodigoElim.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoElim.TabIndex = 0;
            // 
            // txtNombreElim
            // 
            this.txtNombreElim.Location = new System.Drawing.Point(80, 55);
            this.txtNombreElim.Name = "txtNombreElim";
            this.txtNombreElim.ReadOnly = true;
            this.txtNombreElim.Size = new System.Drawing.Size(120, 20);
            this.txtNombreElim.TabIndex = 1;
            // 
            // txtTramiteElim
            // 
            this.txtTramiteElim.Location = new System.Drawing.Point(80, 85);
            this.txtTramiteElim.Name = "txtTramiteElim";
            this.txtTramiteElim.ReadOnly = true;
            this.txtTramiteElim.Size = new System.Drawing.Size(120, 20);
            this.txtTramiteElim.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(55, 115);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 25);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.lstListaSimple);
            this.grpListado.Controls.Add(this.dgvListaSimple);
            this.grpListado.Location = new System.Drawing.Point(12, 190);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(648, 240);
            this.grpListado.TabIndex = 3;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstListaSimple
            // 
            this.lstListaSimple.FormattingEnabled = true;
            this.lstListaSimple.Location = new System.Drawing.Point(10, 20);
            this.lstListaSimple.Name = "lstListaSimple";
            this.lstListaSimple.Size = new System.Drawing.Size(200, 199);
            this.lstListaSimple.TabIndex = 0;
            // 
            // dgvListaSimple
            // 
            this.dgvListaSimple.AllowUserToAddRows = false;
            this.dgvListaSimple.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSimple.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvListaSimple.Location = new System.Drawing.Point(220, 20);
            this.dgvListaSimple.Name = "dgvListaSimple";
            this.dgvListaSimple.Size = new System.Drawing.Size(412, 200);
            this.dgvListaSimple.TabIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            // 
            // colTramite
            // 
            this.colTramite.HeaderText = "Trámite";
            this.colTramite.Name = "colTramite";
            // 
            // FrmListaSimple
            // 
            this.ClientSize = new System.Drawing.Size(672, 445);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.grpEliminado);
            this.Controls.Add(this.grpNuevo);
            this.Controls.Add(this.ptbxImagen);
            this.Name = "FrmListaSimple";
            this.Text = "Estructura de datos: LISTA SIMPLE";
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).EndInit();
            this.grpNuevo.ResumeLayout(false);
            this.grpNuevo.PerformLayout();
            this.grpEliminado.ResumeLayout(false);
            this.grpEliminado.PerformLayout();
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSimple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}