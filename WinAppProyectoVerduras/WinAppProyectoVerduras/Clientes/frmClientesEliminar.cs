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
    public partial class frmClientesEliminar : Form
    {
        cClientes Clasecliente = new cClientes();
        object[] clientes = new object[8];
        public frmClientesEliminar()
        {
            InitializeComponent();
            gbxCliente.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            object[] clientes = new object[8];

            clientes = Clasecliente.getClienteId(txtCedulaBus.Text);
            if (clientes[0] != null)
            {
                System.Console.WriteLine(clientes.Length.ToString());
                labCedula.Text = clientes[0].ToString();
                labNombre.Text = clientes[1].ToString();
                labApellido.Text = clientes[2].ToString();
                labTelefono.Text = clientes[3].ToString();
                labDireccion.Text = clientes[4].ToString();
                labCorreoElec.Text = clientes[5].ToString();
                labDescripcion.Text = clientes[6].ToString();
                gbxCliente.Visible = true;
            }
            else
            {
                txtCedulaBus.Clear();
                MessageBox.Show("!No hay cliente con el numero de cédula ingresada!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbxCliente.Visible = false;
            txtCedulaBus.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Esta segúro que quiere eliminar?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)) == DialogResult.Yes)
            {
                try
                {             
                    Clasecliente.EliminarCliente(clientes);
                    MessageBox.Show("!Eliminación realizada!");
                }
                catch
                {
                    MessageBox.Show("!Eliminación no realizada!");
                }
            }
            else
            {
                gbxCliente.Visible = false;
                txtCedulaBus.Clear();
            }
        }
    }
}
