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
    public partial class frmClientes : Form
    {
        cClientes Clientes = new cClientes();
        public frmClientes()
        {
            InitializeComponent();
            cargarDatos();
        }

        public void cargarDatos()
        {
            dataGridView1.Refresh();
            dataGridView1.DataSource = Clientes.getClientesAll();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmClientesBuscar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmClientesEditar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmClientesEliminar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmClientesRegistros());
            dataGridView1.Refresh();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
