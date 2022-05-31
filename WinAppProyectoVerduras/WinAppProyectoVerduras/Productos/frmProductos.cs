using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppProyectoVerduras.Productos
{
    public partial class frmProductos : Form
    {
        public frmProductos()
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
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmProductosRegistrar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmProductosBuscar());
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmProductosEditar()) ;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormulariosHijos(new frmProductosEliminar());
        }
    }
}
