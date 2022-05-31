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
    public partial class frmLogin : Form
    {
        public frmLogin()
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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnContlogin.BackColor=Color.FromArgb(80, 10, 0, 0);
        }





        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmAdministrador objPrincipal = new frmAdministrador();
            objPrincipal.Show();
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "Correo")
                txtCorreo.Texts = "";
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "")
                txtCorreo.Texts = "Correo";
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Texts == "Contraseña")
            {
                txtContraseña.Texts = "";
                txtContraseña.PasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Texts == "")
            {
                txtContraseña.Texts = "Contraseña";
                txtContraseña.PasswordChar = false;
            } 
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtContraseña.Focus();
            }
        }
    }
}
