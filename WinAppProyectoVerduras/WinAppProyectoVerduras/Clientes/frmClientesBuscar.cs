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
    public partial class frmClientesBuscar : Form
    {
        cClientes Clasecliente = new cClientes();
       

        public frmClientesBuscar()
        {
            InitializeComponent();
            gbxCliente.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            object[] clientes = new object[8];

            clientes = Clasecliente.getClienteId(txtCedula.Text);

            if (clientes[0] != null ) {
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
            else {
                txtCedula.Clear();
                MessageBox.Show("!No hay cliente con el numero de cédula ingresada!");
            
            }
           

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gbxCliente.Visible = false;
            txtCedula.Clear();
        }

        private void frmClientesBuscar_Load(object sender, EventArgs e)
        {

        }
    }
}
