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
    public partial class frmVentasVender : Form
    {
        public frmVentasVender()
        {
            InitializeComponent();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venta realizada con exito", "Informe", MessageBoxButtons.OK);
            this.Close();
        }

       
    }
}
