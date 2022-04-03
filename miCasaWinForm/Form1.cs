using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CN_miCasa;

namespace miCasaWinForm
{
    public partial class frmDatosCasas : Form
    {
        private bool Editar=false;
        private TextBox identDueño;
        public TextBox IdentDueño { get => identDueño; set => identDueño = value; }

        public frmDatosCasas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIdCasa.Enabled=false;
            txtDueño.Enabled=false;
            listaCasas(); 
            objTexboxIdDueño();
        }
        private void objTexboxIdDueño()
        {
            identDueño = txtDueño;
        }
        private void listaCasas()
        {
            dGVmiCasa.DataSource = NegCasas.mostrarCasas();
        }
        private void btnSelectDueño_Click(object sender, EventArgs e)
        {
            Datos_de_Dueños newfrmDatosDueños = new Datos_de_Dueños();
            AddOwnedForm(newfrmDatosDueños);
            if (dGVmiCasa.SelectedRows.Count == 1)
            {
                txtDueño.Text = dGVmiCasa.CurrentRow.Cells["Dueño"].Value.ToString();
                NegDueños.DueñoSeleccionado = txtDueño.Text;
                newfrmDatosDueños.ShowDialog();
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar==false)
            {
                try
                {
                    if (cbobTipoCasa.Text != "" && txtUbicacion.Text != "" && txtDescripcion.Text != "" && txtDueño.Text != "")
                    {
                        NegCasas.insertarCasas(cbobTipoCasa.Text, txtUbicacion.Text, txtDescripcion.Text, txtDueño.Text);
                        MessageBox.Show("Insertado correctamente", "Datos de Casas");
                        listaCasas();
                        limpiarCasas();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione el campo Dueño o campo faltante", "Datos de Casas");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar:" + ex, "Datos de Casas");
                }

            }
            else
            {
                try
                {
                    NegCasas.editarCasas(txtIdCasa.Text, cbobTipoCasa.Text, txtUbicacion.Text, txtDescripcion.Text, txtDueño.Text);
                    MessageBox.Show("Editado correctamente", "Datos de Casas");
                    listaCasas();
                    limpiarCasas();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar:" + ex, "Datos de Casas");
                }

            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dGVmiCasa.SelectedRows.Count == 1)
            {
                Editar = true;
                txtIdCasa.Text = dGVmiCasa.CurrentRow.Cells["idCasa"].Value.ToString();
                cbobTipoCasa.Text = dGVmiCasa.CurrentRow.Cells["tipodeCasa"].Value.ToString();
                txtUbicacion.Text = dGVmiCasa.CurrentRow.Cells["Ubicacion"].Value.ToString();
                txtDescripcion.Text = dGVmiCasa.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtDueño.Text = dGVmiCasa.CurrentRow.Cells["Dueño"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar", "Datos de Casas");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dGVmiCasa.SelectedRows.Count == 1)
            {
                try
                {
                    txtIdCasa.Text = dGVmiCasa.CurrentRow.Cells["idCasa"].Value.ToString();
                    NegCasas.eliminarCasas(txtIdCasa.Text);
                    MessageBox.Show("Eliminado correctamente", "Datos de Casas");
                    listaCasas();
                    limpiarCasas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar" + ex, "Datos de Casas");
                }
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Datos de Casas");
            }
        }
        private void btnBuscarUbicacion_Click(object sender, EventArgs e)
        {
            try
            {
                dGVmiCasa.DataSource = NegCasas.buscarUbicacion(txtUbicacion.Text);
                limpiarCasas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar" + ex, "Datos de Casas");
            }
        }
        private void limpiarCasas()
        {
            txtIdCasa.Text = "";
            cbobTipoCasa.Text = "";
            txtUbicacion.Text = "";
            txtDescripcion.Text = "";
            txtDueño.Text = "";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarCasas();
        }

        private void btnListaCasas_Click(object sender, EventArgs e)
        {
            listaCasas();
        }
    }
}
