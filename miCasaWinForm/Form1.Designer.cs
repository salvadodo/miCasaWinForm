namespace miCasaWinForm
{
    partial class frmDatosCasas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVmiCasa = new System.Windows.Forms.DataGridView();
            this.gbDatosCasas = new System.Windows.Forms.GroupBox();
            this.btnListaCasas = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtDueño = new System.Windows.Forms.TextBox();
            this.btnSelectDueño = new System.Windows.Forms.Button();
            this.btnBuscarUbicacion = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbobTipoCasa = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtIdCasa = new System.Windows.Forms.TextBox();
            this.lblDueño = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.lblTipoCasa = new System.Windows.Forms.Label();
            this.lblIdCasa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVmiCasa)).BeginInit();
            this.gbDatosCasas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGVmiCasa
            // 
            this.dGVmiCasa.AllowUserToAddRows = false;
            this.dGVmiCasa.AllowUserToDeleteRows = false;
            this.dGVmiCasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVmiCasa.Location = new System.Drawing.Point(12, 12);
            this.dGVmiCasa.Name = "dGVmiCasa";
            this.dGVmiCasa.ReadOnly = true;
            this.dGVmiCasa.RowHeadersWidth = 51;
            this.dGVmiCasa.RowTemplate.Height = 24;
            this.dGVmiCasa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVmiCasa.Size = new System.Drawing.Size(745, 464);
            this.dGVmiCasa.TabIndex = 0;
            // 
            // gbDatosCasas
            // 
            this.gbDatosCasas.Controls.Add(this.btnListaCasas);
            this.gbDatosCasas.Controls.Add(this.btnNuevo);
            this.gbDatosCasas.Controls.Add(this.txtDueño);
            this.gbDatosCasas.Controls.Add(this.btnSelectDueño);
            this.gbDatosCasas.Controls.Add(this.btnBuscarUbicacion);
            this.gbDatosCasas.Controls.Add(this.btnEliminar);
            this.gbDatosCasas.Controls.Add(this.btnEditar);
            this.gbDatosCasas.Controls.Add(this.btnGuardar);
            this.gbDatosCasas.Controls.Add(this.cbobTipoCasa);
            this.gbDatosCasas.Controls.Add(this.txtDescripcion);
            this.gbDatosCasas.Controls.Add(this.txtUbicacion);
            this.gbDatosCasas.Controls.Add(this.txtIdCasa);
            this.gbDatosCasas.Controls.Add(this.lblDueño);
            this.gbDatosCasas.Controls.Add(this.lblDescripcion);
            this.gbDatosCasas.Controls.Add(this.lblUbicacion);
            this.gbDatosCasas.Controls.Add(this.lblTipoCasa);
            this.gbDatosCasas.Controls.Add(this.lblIdCasa);
            this.gbDatosCasas.Location = new System.Drawing.Point(763, 12);
            this.gbDatosCasas.Name = "gbDatosCasas";
            this.gbDatosCasas.Size = new System.Drawing.Size(489, 464);
            this.gbDatosCasas.TabIndex = 1;
            this.gbDatosCasas.TabStop = false;
            this.gbDatosCasas.Text = "Datos de Casas";
            // 
            // btnListaCasas
            // 
            this.btnListaCasas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaCasas.Location = new System.Drawing.Point(231, 294);
            this.btnListaCasas.Name = "btnListaCasas";
            this.btnListaCasas.Size = new System.Drawing.Size(165, 32);
            this.btnListaCasas.TabIndex = 18;
            this.btnListaCasas.Text = "Lista de Casas";
            this.btnListaCasas.UseVisualStyleBackColor = true;
            this.btnListaCasas.Click += new System.EventHandler(this.btnListaCasas_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(29, 294);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(165, 32);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDueño
            // 
            this.txtDueño.Location = new System.Drawing.Point(155, 227);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(241, 22);
            this.txtDueño.TabIndex = 16;
            // 
            // btnSelectDueño
            // 
            this.btnSelectDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDueño.Location = new System.Drawing.Point(411, 221);
            this.btnSelectDueño.Name = "btnSelectDueño";
            this.btnSelectDueño.Size = new System.Drawing.Size(61, 32);
            this.btnSelectDueño.TabIndex = 15;
            this.btnSelectDueño.Text = "...";
            this.btnSelectDueño.UseVisualStyleBackColor = true;
            this.btnSelectDueño.Click += new System.EventHandler(this.btnSelectDueño_Click);
            // 
            // btnBuscarUbicacion
            // 
            this.btnBuscarUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUbicacion.Location = new System.Drawing.Point(231, 401);
            this.btnBuscarUbicacion.Name = "btnBuscarUbicacion";
            this.btnBuscarUbicacion.Size = new System.Drawing.Size(191, 32);
            this.btnBuscarUbicacion.TabIndex = 14;
            this.btnBuscarUbicacion.Text = "Buscar Ubicación";
            this.btnBuscarUbicacion.UseVisualStyleBackColor = true;
            this.btnBuscarUbicacion.Click += new System.EventHandler(this.btnBuscarUbicacion_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(29, 401);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(165, 32);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(231, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(165, 32);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(29, 350);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(165, 32);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbobTipoCasa
            // 
            this.cbobTipoCasa.FormattingEnabled = true;
            this.cbobTipoCasa.Items.AddRange(new object[] {
            "Pequeña",
            "Mediana",
            "Grande",
            "Lujosa"});
            this.cbobTipoCasa.Location = new System.Drawing.Point(155, 80);
            this.cbobTipoCasa.Name = "cbobTipoCasa";
            this.cbobTipoCasa.Size = new System.Drawing.Size(241, 24);
            this.cbobTipoCasa.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(155, 180);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(241, 22);
            this.txtDescripcion.TabIndex = 7;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(155, 128);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(241, 22);
            this.txtUbicacion.TabIndex = 6;
            // 
            // txtIdCasa
            // 
            this.txtIdCasa.Location = new System.Drawing.Point(155, 31);
            this.txtIdCasa.Name = "txtIdCasa";
            this.txtIdCasa.Size = new System.Drawing.Size(241, 22);
            this.txtIdCasa.TabIndex = 5;
            // 
            // lblDueño
            // 
            this.lblDueño.AutoSize = true;
            this.lblDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueño.Location = new System.Drawing.Point(26, 228);
            this.lblDueño.Name = "lblDueño";
            this.lblDueño.Size = new System.Drawing.Size(57, 18);
            this.lblDueño.TabIndex = 4;
            this.lblDueño.Text = "Dueño";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(26, 181);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 18);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUbicacion.Location = new System.Drawing.Point(26, 129);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(83, 18);
            this.lblUbicacion.TabIndex = 2;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // lblTipoCasa
            // 
            this.lblTipoCasa.AutoSize = true;
            this.lblTipoCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCasa.Location = new System.Drawing.Point(26, 81);
            this.lblTipoCasa.Name = "lblTipoCasa";
            this.lblTipoCasa.Size = new System.Drawing.Size(108, 18);
            this.lblTipoCasa.TabIndex = 1;
            this.lblTipoCasa.Text = "Tipo de Casa";
            // 
            // lblIdCasa
            // 
            this.lblIdCasa.AutoSize = true;
            this.lblIdCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCasa.Location = new System.Drawing.Point(26, 32);
            this.lblIdCasa.Name = "lblIdCasa";
            this.lblIdCasa.Size = new System.Drawing.Size(60, 18);
            this.lblIdCasa.TabIndex = 0;
            this.lblIdCasa.Text = "IdCasa";
            // 
            // frmDatosCasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 488);
            this.Controls.Add(this.gbDatosCasas);
            this.Controls.Add(this.dGVmiCasa);
            this.Name = "frmDatosCasas";
            this.Text = "miCasa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVmiCasa)).EndInit();
            this.gbDatosCasas.ResumeLayout(false);
            this.gbDatosCasas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVmiCasa;
        private System.Windows.Forms.GroupBox gbDatosCasas;
        private System.Windows.Forms.Label lblIdCasa;
        private System.Windows.Forms.Label lblDueño;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.Label lblTipoCasa;
        private System.Windows.Forms.Button btnBuscarUbicacion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbobTipoCasa;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtIdCasa;
        private System.Windows.Forms.Button btnSelectDueño;
        private System.Windows.Forms.Button btnListaCasas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtDueño;
    }
}

