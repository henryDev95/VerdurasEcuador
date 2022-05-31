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
    public partial class frmVentasEditar : Form
    {
        public frmVentasEditar()
        {
            InitializeComponent();
            pnlEditar.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnlEditar.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se edito correctamente", "Venta Editar", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
