using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoVerduras.Empleados
{
    public partial class frmEmpleados : Form
    {
        cEmpleados empleados= new cEmpleados();
        public frmEmpleados()
        {
            InitializeComponent();
            cargarDataGrid();
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
            AbrirFormulariosHijos(new frmEmpleadosBuscar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmEmpleadosEditar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmEmpleadosEliminar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new Login.frmRegistro());
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        public void cargarDataGrid()
        {
            lblEmpleadosRegistrados.Text = empleados.cantidadEmpleados().ToString();
            dataGridView1.Refresh();
            dataGridView1.DataSource = empleados.getEmpleadosAll();
        }
    }


}
