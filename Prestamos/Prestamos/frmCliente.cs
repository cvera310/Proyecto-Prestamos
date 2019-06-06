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
    public partial class frmCliente : MetroFramework.Forms.MetroForm
    {

        string modo;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            modo = "I";
        

            LimpiarFormulario();
            DesbloquearFormulario();
            
            /*if (VerificarExistenciaCliente() == true)
            {
                MessageBox.Show("Numero de cliente ya existe");
            }

            else
            {
                Cliente cliente = ObtenerClienteForm();
                Cliente.Agregar(cliente);
                LimpiarFormulario();
            }*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void txtNumCliente_Leave(object sender, EventArgs e)
        {
            /*List<Cliente> listaclientes = Cliente.ListarCliente();
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
                    
                    btnAgregar.Enabled = false;
                    btnGuardar.Enabled = true;
                }
              else
              {
                    
                    btnAgregar.Enabled = true;
                    LimpiarFormularioParcial();
                    btnGuardar.Enabled = false;
                }*/

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            dgvCliente.AutoGenerateColumns = true;
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cmbTipoDocumento.SelectedItem = null;
            cmbSexo.SelectedItem = null;
            BloquearFormulario();

            if (Cliente.ListarCliente() !=null)
            {
                ActualizarDataGrid();
            }
            
            
            
            
            /*dgvCliente.AutoGenerateColumns = true;
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(TipoDocumento));
            cmbTipoDocumento.SelectedItem = null;
            cmbSexo.SelectedItem = null;
            //rdbInformconfNO.Checked = true;
            //rdbInformConfSI.Checked = false;
            btnGuardar.Enabled = false;*/

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
            /*List<Cliente> listaclientes = Cliente.ListarCliente();
            foreach (Cliente cli in listaclientes)
                if (cli.NumeroCliente == Convert.ToInt32(txtNumCliente.Text))
                {
                    Cliente.Eliminar(cli);
                    Cliente.Agregar(ObtenerClienteForm());


                }*/

            if (modo == "I")
            {
                Cliente cliente = ObtenerClienteForm();
                Cliente.Agregar(cliente);
            }
            else if (modo == "E")
            {
                int index = dgvCliente.CurrentRow.Index;
                Cliente cliente = ObtenerClienteForm();
                
            }

            ActualizarDataGrid();
            LimpiarFormulario();
            BloquearFormulario();



        }

        private Cliente ObtenerClienteForm()
        {

            Cliente cliente = new Cliente();
            if (!string.IsNullOrEmpty(txtNumCliente.Text))
            {
                cliente.NumeroCliente = Convert.ToInt32(txtNumCliente.Text);
            }
            //cliente.NumeroCliente = Convert.ToInt32(txtNumCliente.Text);
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.TipoDeDocumento = (TipoDocumento)cmbTipoDocumento.SelectedItem;
            cliente.Documento = txtNroDocumento.Text;
            cliente.sexo = (Sexo)cmbSexo.SelectedItem;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.Nacimiento = dtpFechaNacimiento.Value;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            //cliente.Foto = "texto_en_duro_por_ahora";
            cliente.LugarTrabajo = txtLugarTrabajo.Text;
            cliente.AntiguedadLaboral = Convert.ToInt32(txtAntiguedad.Text);
            /*if (rdbInformconfNO.Checked)
            {
                cliente.Informconf = false;

            }
            else if (rdbInformConfSI.Checked)
            {
                cliente.Informconf = true;
            }*/

            return cliente;

        }

        private void LimpiarFormulario()
        {

            txtNumCliente.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDirLaboral.Text = "";
            cmbTipoDocumento.SelectedItem = null;
            txtNroDocumento.Text = "";
            cmbSexo.SelectedItem = null;
            txtRazonSocial.Text = "";
            dtpFechaNacimiento.Value = System.DateTime.Now;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtLugarTrabajo.Text = "";
            txtAntiguedad.Text = "";
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
            //rdbInformconfNO.Checked = true;
            //rdbInformConfSI.Checked = false;
            btnAgregar.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            /*List<Cliente> listaclientes = Cliente.ListarCliente();
            foreach (Cliente cli in listaclientes)
                if (cli.NumeroCliente == Convert.ToInt32(txtNumCliente.Text))
                {
                    Cliente.Eliminar(cli);

                }*/

            Cliente cliente = (Cliente)dgvCliente.CurrentRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show("Confirma la eliminacion del registro?", "Eliminar registro", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                if (cliente != null)
                {
                    Cliente.Eliminar(cliente);
                }
                ActualizarDataGrid();
                LimpiarFormulario();
                BloquearFormulario();
            }



        }

        private void BloquearFormulario()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtRazonSocial.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtNroDocumento.Enabled = false;
            cmbSexo.Enabled = false;
            cmbTipoDocumento.Enabled = false;
            txtTelefono.Enabled = false;
            txtDirLaboral.Enabled = false;
            txtAntiguedad.Enabled = false;
            txtLugarTrabajo.Enabled = false;
            txtLugarTrabajo.Enabled = false;

        }

        private void DesbloquearFormulario()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtRazonSocial.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
            txtNroDocumento.Enabled = true;
            cmbSexo.Enabled = true;
            cmbTipoDocumento.Enabled = true;
            txtTelefono.Enabled = true;
            txtDirLaboral.Enabled = true;
            txtAntiguedad.Enabled = true;
            txtLugarTrabajo.Enabled = true;
            txtLugarTrabajo.Enabled = true;
        }

        private void ActualizarDataGrid()
        {
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = Cliente.ListarCliente();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modo = "E";
            DesbloquearFormulario();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            BloquearFormulario();
        }
    }
}
