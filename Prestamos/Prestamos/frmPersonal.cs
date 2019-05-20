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
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            cmbCargo.DataSource = Enum.GetValues(typeof(Cargo));
            cmbCargo.SelectedItem = null;
        }

        private Personal ObtenerPersonalForm()
        {
         Personal personal = new Personal();
            personal.NumeroEmpleado = Convert.ToInt32(txtNroEmpleado.Text);
            personal.Documento = txtNroDocumento.Text;
            personal.Nombre = txtNombre.Text;
            personal.Apellido = txtApellido.Text;
            personal.FechaNac = dtpFechaNac.Value;
            personal.Telefono = txtTelefono.Text;
            personal.Direccion = txtDireccion.Text;
            personal.Cargo = (Cargo)cmbCargo.SelectedItem;
            personal.Foto = "texto_en_duro_mientras_tanto";

            return personal;

        }

        private void LimpiarFormulario()
        {

            txtNroEmpleado.Text = "";
            txtNroDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNac.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbCargo.SelectedItem= null;
        }

        private void LimpiarFormularioParcial()
        {

            
            txtNroDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            dtpFechaNac.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cmbCargo.SelectedItem = null;
        }

        private void btnAgragar_Click(object sender, EventArgs e)
        {
            Personal personal = ObtenerPersonalForm();
            Personal.Agregar(personal);
        }

        private void txtNroEmpleado_Leave(object sender, EventArgs e)
        {
            List<Personal> listaDelPersonal = Personal.ListarPersonal();
            foreach (Personal per in listaDelPersonal)
                if (per.NumeroEmpleado == Convert.ToInt32(txtNroEmpleado.Text))
                {
                    txtNroEmpleado.Text = Convert.ToString(per.NumeroEmpleado);
                    txtNroDocumento.Text = per.Documento;
                    txtNombre.Text = per.Nombre;
                    txtApellido.Text = per.Apellido;
                    dtpFechaNac.Value = per.FechaNac;
                    txtTelefono.Text = per.Telefono;
                    txtDireccion.Text = per.Direccion;
                    cmbCargo.SelectedItem = per.Cargo;
                    btnAgragar.Enabled = false;
                    btnGuardar.Enabled = true;
                }
                else
                {
                   
                    btnAgragar.Enabled = true;
                   
                    btnGuardar.Enabled = false;
                    LimpiarFormularioParcial();
                }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
