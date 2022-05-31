using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoVerduras
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }


        //Abrir formularios hijos en panel contenedor

        private Form formularioActivo = null;
        private void AbrirFormulariosHijos(Form formularioHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(formularioHijo);
            pnlContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Empleados.frmEmpleados());
        }

        private void frmPincipal_Load(object sender, EventArgs e)
        {
            Login.frmLogin objLogin = new Login.frmLogin();
            objLogin.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Clientes.frmClientes());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Productos.frmProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Ventas.frmVentas());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Reportes.frmReportes());
        }
    }
}
