using CN_miCasa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miCasaWinForm
{
    public partial class Datos_de_Dueños : Form
    {
        private bool Editar=false;
        public Datos_de_Dueños()
        {
            InitializeComponent();
        }
        private void Datos_de_Dueños_Load(object sender, EventArgs e)
        {
            txtIdDueño.Enabled = false;
            txtIdDueño.Text = NegDueños.DueñoSeleccionado;
            listarDueños();
            if (txtIdDueño.Text != "")
            {
                DueñosMod newDueñosMod = NegDueños.selectDueño(txtIdDueño.Text);
                txtIdDueño.Text = newDueñosMod.IdDueño.ToString();
                txtNombre.Text = newDueñosMod.Nombre;
                txtEdad.Text = newDueñosMod.Edad.ToString();
                txtDireccion.Text = newDueñosMod.Direccion;
            }
        }
        private void listarDueños()
        {
            dgvDatosUsuarios.DataSource = NegDueños.mostrarDueños();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    if (txtNombre.Text != "" && txtEdad.Text != "" && txtDireccion.Text != "")
                    {
                        NegDueños.insertarDueño(txtNombre.Text, txtEdad.Text, txtDireccion.Text);
                        MessageBox.Show("Insertado correctamente", "Datos de Dueños");
                        listarDueños();
                        limpiarDueños();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese los campos faltantes", "Datos de Dueños");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar:" + ex, "Datos de Dueños");
                }
            }
            else
            {
                try
                {
                    NegDueños.editarDueños(txtIdDueño.Text, txtNombre.Text, txtEdad.Text, txtDireccion.Text);
                    MessageBox.Show("Editado correctamente", "Datos de Dueños");
                    listarDueños();
                    limpiarDueños();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar:" + ex, "Datos de Dueños");
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgvDatosUsuarios.SelectedRows.Count == 1)
            {
                Editar = true;
                txtIdDueño.Text = dgvDatosUsuarios.CurrentRow.Cells["idDueño"].Value.ToString();
                txtNombre.Text = dgvDatosUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtEdad.Text = dgvDatosUsuarios.CurrentRow.Cells["Edad"].Value.ToString();
                txtDireccion.Text = dgvDatosUsuarios.CurrentRow.Cells["Direccion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar", "Datos de Dueños");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatosUsuarios.SelectedRows.Count == 1)
            {
                try
                {
                    txtIdDueño.Text = dgvDatosUsuarios.CurrentRow.Cells["idDueño"].Value.ToString();
                    NegDueños.eliminarDueños(txtIdDueño.Text);
                    MessageBox.Show("Eliminado correctamente", "Datos de Dueños");
                    listarDueños();
                    limpiarDueños();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar" + ex, "Datos de Dueños");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Datos de Dueños");
            }
        }
        private void btnBuscarDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDatosUsuarios.DataSource = NegDueños.buscarDireccion(txtDireccion.Text);
                limpiarDueños();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar" + ex, "Datos de Dueños");
            }
        }
        private void limpiarDueños()
        {
            txtIdDueño.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";
            txtDireccion.Text = "";
        }

        private void btnSeleccionarDueño_Click(object sender, EventArgs e)
        {
            if(dgvDatosUsuarios.SelectedRows.Count == 1)
            {
                frmDatosCasas frmCasas = Owner as frmDatosCasas;
                txtIdDueño.Text = dgvDatosUsuarios.CurrentRow.Cells["idDueño"].Value.ToString();
                frmCasas.IdentDueño.Text = txtIdDueño.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione la fila del Dueño", "Datos de Dueños");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarDueños();
        }

        private void btnListaDueños_Click(object sender, EventArgs e)
        {
            listarDueños();
        }
    }
}
