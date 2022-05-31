using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoVerduras.Login
{
    public partial class frmLoginEmpleado : Form
    {
        public frmLoginEmpleado()
        {
            InitializeComponent();
        }

        private void frmLoginEmpleado_Load(object sender, EventArgs e)
        {
            pnContlogin.BackColor = Color.FromArgb(80, 10, 0, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmEmpleado objEmpleado = new frmEmpleado();
            objEmpleado.Show();
        }
    }
}
