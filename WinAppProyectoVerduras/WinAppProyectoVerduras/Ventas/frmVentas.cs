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
    public partial class frmVentas : Form
    {
        public frmVentas()
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

        private void btnVender_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmVentasVender());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmVentasBuscar());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmVentasEliminar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmVentasEditar());
        }
    }
}
