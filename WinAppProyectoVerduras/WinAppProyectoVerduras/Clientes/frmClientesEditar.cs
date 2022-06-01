using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoVerduras.Clientes
{
    public partial class frmClientesEditar : Form
    {

        cClientes Clasecliente = new cClientes();

        object[] clientes = new object[8];
        public frmClientesEditar()
        {
            InitializeComponent();
            gbxCliente.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            clientes = Clasecliente.getClienteId(txtCedulaBusca.Text);

            if (clientes[0] != null)
            {
                txtCedula.Enabled = false;
                txtCedula.Text = clientes[0].ToString();
                txtNombre.Text = clientes[1].ToString();
                txtApellido.Text = clientes[2].ToString();
                txtTelefono.Text = clientes[3].ToString();
                txtDireccion.Text = clientes[4].ToString();
                txtCorreo.Text = clientes[5].ToString();
                txtDescripcion.Text = clientes[6].ToString();
                gbxCliente.Visible = true;
            }
            else
            {
                txtCedulaBusca.Clear();
                MessageBox.Show("!No hay cliente con el numero de cédula ingresada!");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbxCliente.Visible = false;
            txtCedulaBusca.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if((MessageBox.Show("Esta segúro que quiere editar?", "Editar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) ==DialogResult.Yes)
            {
                try
                {

                    clientes[0] = txtCedula.Text;
                    clientes[1] = txtNombre.Text;
                    clientes[2] = txtApellido.Text;
                    clientes[3] = txtTelefono.Text;
                    clientes[4] = txtDireccion.Text;
                    clientes[5] = txtCorreo.Text;
                    clientes[6] = txtDescripcion.Text;
                    Clasecliente.editarCliente(clientes);
                    MessageBox.Show("!Actualización realizada!");
                }
                catch
                {
                    MessageBox.Show("!Actualización no realizada!");
                }
            }
            else
            {
                gbxCliente.Visible = false;
                txtCedulaBusca.Clear();
            }
        }
    }
}
