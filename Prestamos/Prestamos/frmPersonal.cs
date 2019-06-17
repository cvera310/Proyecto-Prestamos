using BibliotecaClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prestamos
{
    public partial class frmPersonal : MetroFramework.Forms.MetroForm
    {
        string modo;
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            Personal personal = new Personal();
            dgvPersonal.AutoGenerateColumns = true;

            BloquearFormulario();

            if (Personal.ListarPersonal() != null)
            {
                ActualizarDataGrid();
            }


            cmbTipoDoc.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cmbTipoDoc.SelectedItem = null;
            cmbCargo.DataSource = Enum.GetValues(typeof(Cargo));
            cmbCargo.SelectedItem = null;
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbSexo.SelectedItem = null;

        }

        private Personal ObtenerPersonalForm()
        {
         Personal personal = new Personal();
            if (!string.IsNullOrEmpty(txtNroEmpleado.Text))
            {
                personal.NumeroEmpleado = Convert.ToInt32(txtNroEmpleado.Text);
            }

            //personal.NumeroEmpleado = Convert.ToInt32(txtNroEmpleado1.Text);
            //personal.Documento = txtNroDocumento1.Text;
            personal.TipoDeDocumento = (TipoDocumento)cmbTipoDoc.SelectedItem;
            personal.Documento = txtNroDocumento.Text;
            personal.Nombre = txtNombre.Text;
            personal.Apellido = txtApellido.Text;
            personal.Cargo = (Cargo)cmbCargo.SelectedItem;
            personal.FechaNac = dtpFechaNac.Value;
            personal.Telefono = txtTelefono.Text;
            personal.Direccion = txtDireccion.Text;
            personal.sexo = (Sexo)cmbSexo.SelectedItem;

            return personal;

        }

        private void LimpiarFormulario()
        {

            txtNroEmpleado.Text = "";
            cmbTipoDoc.SelectedItem = null;
            txtNroDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbCargo.SelectedItem = null;
            cmbTipoDoc.SelectedItem = null;
            dtpFechaNac.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbSexo.SelectedItem = null;

        }
        private void BloquearFormulario()
        {
            txtNroEmpleado.Enabled = false;
            cmbTipoDoc.Enabled = false;
            txtNroDocumento.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cmbCargo.Enabled = false;
            cmbTipoDoc.Enabled = false;
            dtpFechaNac.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            cmbSexo.Enabled = false;

        }

        private void DesbloquearFormulario()
        {
            cmbTipoDoc.Enabled = true;
            txtNroDocumento.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cmbCargo.Enabled = true;
            cmbTipoDoc.Enabled = true;
            dtpFechaNac.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            cmbSexo.Enabled = true;
        }

         private void LimpiarFormularioParcial()
         {
            //limpia el formulario pero deja el nro empleado
            //¿Por qué? .. no recuerdo

            //txtNroEmpleado.Text = "";
            cmbTipoDoc.SelectedItem = null;
            txtNroDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cmbCargo.SelectedItem = null;
            cmbTipoDoc.SelectedItem = null;
            dtpFechaNac.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbSexo.SelectedItem = null;
         }

        private void ActualizarDataGrid()
        {
            dgvPersonal.DataSource = null;
            dgvPersonal.DataSource = Personal.ListarPersonal();
        }

        //No se que hacía esta parte, pero ya no importa...
        //
        /*private void txtNroEmpleado_Leave(object sender, EventArgs e)
        {
            List<Personal> listaDelPersonal = Personal.ListarPersonal();
            foreach (Personal per in listaDelPersonal)
                if (per.NumeroEmpleado == Convert.ToInt32(txtNroEmpleado1.Text))
                {
                    txtNroEmpleado1.Text = Convert.ToString(per.NumeroEmpleado);
                    txtNroDocumento1.Text = per.Documento;
                    txtNombre.Text = per.Nombre;
                    txtApellido.Text = per.Apellido;
                    dtpFechaNac.Value = per.FechaNac;
                    txtTelefono.Text = per.Telefono;
                    txtDireccion.Text = per.Direccion;
                    cmbCargo.SelectedItem = per.Cargo;
                    btnAgregar.Enabled = false;
                    btnEditar.Enabled = true;
                }
                else
                {
                   
                    btnAgregar.Enabled = true;
                   
                    btnEditar.Enabled = false;
                    LimpiarFormularioParcial();
                }
        }*/

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            modo = "I";


            LimpiarFormulario();
            DesbloquearFormulario();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Personal personal = (Personal)dgvPersonal.CurrentRow.DataBoundItem;
            if (personal != null)
            {
                modo = "E";
                DesbloquearFormulario();
                txtNroEmpleado.Text = Convert.ToString(personal.NumeroEmpleado);
                cmbTipoDoc.SelectedItem = (TipoDocumento)personal.TipoDeDocumento;
                txtNroDocumento.Text = personal.Documento;
                txtNombre.Text = personal.Nombre;
                txtApellido.Text = personal.Apellido;
                cmbCargo.SelectedItem = (Cargo)personal.Cargo;
                dtpFechaNac.Value = personal.FechaNac;
                txtTelefono.Text = personal.Telefono;
                txtDireccion.Text = personal.Direccion;
                cmbSexo.SelectedItem = (Sexo)personal.sexo;


            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Personal personal = (Personal)dgvPersonal.CurrentRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show("Confirma la eliminacion del registro?", "Eliminar registro", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                if (personal != null)
                {
                    Personal.Eliminar(personal);
                }
                ActualizarDataGrid();
                LimpiarFormulario();
                BloquearFormulario();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipoDoc.SelectedItem != null)
            {
                if (modo == "I")
                {
                    Personal personal = ObtenerPersonalForm();
                    Personal.Agregar(personal);
                }
                else if (modo == "E")
                {
                    int index = dgvPersonal.CurrentRow.Index;
                    Personal personal = ObtenerPersonalForm();
                    Personal.Editar(personal);


                }
                ActualizarDataGrid();
                LimpiarFormulario();
                BloquearFormulario();

            }
        }
    }
}
