using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoVerduras.Ventas
{
    public partial class frmVentasEliminar : Form
    {
        public frmVentasEliminar()
        {
            InitializeComponent();
            pnlEliminar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlEliminar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
