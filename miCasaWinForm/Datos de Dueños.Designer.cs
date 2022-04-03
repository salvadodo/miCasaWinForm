namespace miCasaWinForm
{
    partial class Datos_de_Dueños
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
            this.gbBuscarDueño = new System.Windows.Forms.GroupBox();
            this.dgvDatosUsuarios = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblIdDueño = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtIdDueño = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBuscarDireccion = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSeleccionarDueño = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnListaDueños = new System.Windows.Forms.Button();
            this.gbBuscarDueño.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBuscarDueño
            // 
            this.gbBuscarDueño.Controls.Add(this.btnListaDueños);
            this.gbBuscarDueño.Controls.Add(this.btnNuevo);
            this.gbBuscarDueño.Controls.Add(this.btnSeleccionarDueño);
            this.gbBuscarDueño.Controls.Add(this.btnBuscarDireccion);
            this.gbBuscarDueño.Controls.Add(this.btnEliminar);
            this.gbBuscarDueño.Controls.Add(this.btnEditar);
            this.gbBuscarDueño.Controls.Add(this.txtDireccion);
            this.gbBuscarDueño.Controls.Add(this.txtEdad);
            this.gbBuscarDueño.Controls.Add(this.txtNombre);
            this.gbBuscarDueño.Controls.Add(this.txtIdDueño);
            this.gbBuscarDueño.Controls.Add(this.lblDireccion);
            this.gbBuscarDueño.Controls.Add(this.lblEdad);
            this.gbBuscarDueño.Controls.Add(this.lblNombre);
            this.gbBuscarDueño.Controls.Add(this.lblIdDueño);
            this.gbBuscarDueño.Controls.Add(this.btnGuardar);
            this.gbBuscarDueño.Location = new System.Drawing.Point(641, 12);
            this.gbBuscarDueño.Name = "gbBuscarDueño";
            this.gbBuscarDueño.Size = new System.Drawing.Size(409, 453);
            this.gbBuscarDueño.TabIndex = 2;
            this.gbBuscarDueño.TabStop = false;
            this.gbBuscarDueño.Text = "Datos de Dueño";
            // 
            // dgvDatosUsuarios
            // 
            this.dgvDatosUsuarios.AllowUserToAddRows = false;
            this.dgvDatosUsuarios.AllowUserToDeleteRows = false;
            this.dgvDatosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosUsuarios.Location = new System.Drawing.Point(12, 12);
            this.dgvDatosUsuarios.Name = "dgvDatosUsuarios";
            this.dgvDatosUsuarios.ReadOnly = true;
            this.dgvDatosUsuarios.RowHeadersWidth = 51;
            this.dgvDatosUsuarios.RowTemplate.Height = 24;
            this.dgvDatosUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosUsuarios.Size = new System.Drawing.Size(623, 453);
            this.dgvDatosUsuarios.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(6, 347);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(185, 32);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblIdDueño
            // 
            this.lblIdDueño.AutoSize = true;
            this.lblIdDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDueño.Location = new System.Drawing.Point(16, 33);
            this.lblIdDueño.Name = "lblIdDueño";
            this.lblIdDueño.Size = new System.Drawing.Size(98, 18);
            this.lblIdDueño.TabIndex = 3;
            this.lblIdDueño.Text = "Id de Dueño";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(16, 79);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.Location = new System.Drawing.Point(16, 127);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(46, 18);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(16, 175);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(80, 18);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtIdDueño
            // 
            this.txtIdDueño.Location = new System.Drawing.Point(158, 32);
            this.txtIdDueño.Name = "txtIdDueño";
            this.txtIdDueño.Size = new System.Drawing.Size(250, 22);
            this.txtIdDueño.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(250, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(158, 126);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(250, 22);
            this.txtEdad.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(158, 174);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 22);
            this.txtDireccion.TabIndex = 10;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(213, 347);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(185, 32);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBuscarDireccion
            // 
            this.btnBuscarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDireccion.Location = new System.Drawing.Point(213, 398);
            this.btnBuscarDireccion.Name = "btnBuscarDireccion";
            this.btnBuscarDireccion.Size = new System.Drawing.Size(185, 32);
            this.btnBuscarDireccion.TabIndex = 13;
            this.btnBuscarDireccion.Text = "Buscar Dirección";
            this.btnBuscarDireccion.UseVisualStyleBackColor = true;
            this.btnBuscarDireccion.Click += new System.EventHandler(this.btnBuscarDireccion_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(9, 398);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(185, 32);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSeleccionarDueño
            // 
            this.btnSeleccionarDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarDueño.Location = new System.Drawing.Point(9, 239);
            this.btnSeleccionarDueño.Name = "btnSeleccionarDueño";
            this.btnSeleccionarDueño.Size = new System.Drawing.Size(389, 32);
            this.btnSeleccionarDueño.TabIndex = 14;
            this.btnSeleccionarDueño.Text = "Seleccionar Dueño";
            this.btnSeleccionarDueño.UseVisualStyleBackColor = true;
            this.btnSeleccionarDueño.Click += new System.EventHandler(this.btnSeleccionarDueño_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(6, 293);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(185, 32);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnListaDueños
            // 
            this.btnListaDueños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaDueños.Location = new System.Drawing.Point(213, 293);
            this.btnListaDueños.Name = "btnListaDueños";
            this.btnListaDueños.Size = new System.Drawing.Size(185, 32);
            this.btnListaDueños.TabIndex = 16;
            this.btnListaDueños.Text = "Lista de Dueños";
            this.btnListaDueños.UseVisualStyleBackColor = true;
            this.btnListaDueños.Click += new System.EventHandler(this.btnListaDueños_Click);
            // 
            // Datos_de_Dueños
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 477);
            this.Controls.Add(this.dgvDatosUsuarios);
            this.Controls.Add(this.gbBuscarDueño);
            this.Name = "Datos_de_Dueños";
            this.Text = "Datos_de_Dueños";
            this.Load += new System.EventHandler(this.Datos_de_Dueños_Load);
            this.gbBuscarDueño.ResumeLayout(false);
            this.gbBuscarDueño.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbBuscarDueño;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdDueño;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvDatosUsuarios;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Button btnBuscarDireccion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSeleccionarDueño;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnListaDueños;
        private System.Windows.Forms.TextBox txtIdDueño;
    }
}