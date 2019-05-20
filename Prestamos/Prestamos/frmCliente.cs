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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarExistenciaCliente() == true)
            {
                MessageBox.Show("Numero de cliente ya existe");
            }

            else
            {
                Cliente cliente = ObtenerClienteForm();
                Cliente.Agregar(cliente);
                LimpiarFormulario();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void txtNumCliente_Leave(object sender, EventArgs e)
        {
            List<Cliente> listaclientes = Cliente.ListarCliente();
            foreach (Cliente cli in listaclientes)
                if (cli.NumeroCliente == Convert.ToInt32(txtNumCliente.Text))
                {
                    txtNumCliente.Text = Convert.ToString(cli.NumeroCliente);
                    cmbTipoDocumento.SelectedItem = cli.TipoDeDocumento;
                    txtNroDocumento.Text = cli.Documento;
                    cmbSexo.SelectedItem = cli.Sexo;
                    txtRazonSocial.Text = cli.RazonSocial;
                    dtpFechaNacimiento.Value = cli.Nacimiento;
                    txtTelefono.Text = cli.Telefono;
                    txtDireccion.Text = cli.Direccion;
                    txtLugarTrabajo.Text = cli.LugarTrabajo;
                    txtAntiguedad.Text = Convert.ToString(cli.AntiguedadLaboral);
                    if (cli.Informconf == false)
                    {
                        rdbInformconfNO.Checked = true;
                    }
                    else if (cli.Informconf == true)
                    {
                        rdbInformConfSI.Checked = true;
                    }
                    btnAgregar.Enabled = false;
                    btnGuardar.Enabled = true;
                }
              else
              {
                    //     MessageBox.Show("Cliente no encontrado");
                    //      LimpiarFormulario();
                    btnAgregar.Enabled = true;
                    LimpiarFormularioParcial();
                    btnGuardar.Enabled = false;
                }

         }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cmbTipoDocumento.SelectedItem = null;
            cmbSexo.SelectedItem = null;
            rdbInformconfNO.Checked = true;
            rdbInformConfSI.Checked = false;
            btnGuardar.Enabled = false;

        }

        private Boolean VerificarExistenciaCliente()

        {
            List<Cliente> listaclientes = Cliente.ListarCliente();
            Boolean fl = false;
            foreach (Cliente cli in listaclientes)
                
                if (cli.NumeroCliente == Convert.ToInt32(txtNumCliente.Text))
                {
                   fl = true;
                }
            return fl;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaclientes = Cliente.ListarCliente();
            foreach (Cliente cli in listaclientes)
                if (cli.NumeroCliente == Convert.ToInt32(txtNumCliente.Text))
                {
                    Cliente.Eliminar(cli);
                    Cliente.Agregar(ObtenerClienteForm());


                }

        }

        private Cliente ObtenerClienteForm()
        {

            Cliente cliente = new Cliente();
            cliente.NumeroCliente = Convert.ToInt32(txtNumCliente.Text);
            cliente.TipoDeDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;
            cliente.Documento = txtNroDocumento.Text;
            cliente.Sexo = (Sexo)cmbSexo.SelectedItem;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.Nacimiento = dtpFechaNacimiento.Value;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Foto = "texto_en_duro_por_ahora";
            cliente.LugarTrabajo = txtLugarTrabajo.Text;
            cliente.AntiguedadLaboral = Convert.ToInt32(txtAntiguedad.Text);
            if (rdbInformconfNO.Checked)
            {
                cliente.Informconf = false;

            }
            else if (rdbInformConfSI.Checked)
            {
                cliente.Informconf = true;
            }

            return cliente;

        }

        private void LimpiarFormulario()
        {

            txtNumCliente.Text = "";
            cmbTipoDocumento.SelectedItem = null;
            txtNroDocumento.Text = "";
            cmbSexo.SelectedItem = null;
            txtRazonSocial.Text = "";
            dtpFechaNacimiento.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtLugarTrabajo.Text = "";
            txtAntiguedad.Text = "";
            rdbInformconfNO.Checked = true;
            rdbInformConfSI.Checked = false;
            btnAgregar.Enabled = true;
        }

        //limpia el formulario, pero deja el numero de cliente
        private void LimpiarFormularioParcial()
        {

            cmbTipoDocumento.SelectedItem = null;
            txtNroDocumento.Text = "";
            cmbSexo.SelectedItem = null;
            txtRazonSocial.Text = "";
            dtpFechaNacimiento.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtLugarTrabajo.Text = "";
            txtAntiguedad.Text = "";
            rdbInformconfNO.Checked = true;
            rdbInformConfSI.Checked = false;
            btnAgregar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            List<Cliente> listaclientes = Cliente.ListarCliente();
            foreach (Cliente cli in listaclientes)
                if (cli.NumeroCliente == Convert.ToInt32(txtNumCliente.Text))
                {
                    Cliente.Eliminar(cli);

                }
        }
    }
}
