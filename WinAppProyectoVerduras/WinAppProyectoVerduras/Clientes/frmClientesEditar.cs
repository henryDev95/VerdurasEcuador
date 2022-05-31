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
        public frmClientesEditar()
        {
            InitializeComponent();
            gbxCliente.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbxCliente.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
