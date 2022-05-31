using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace WinAppProyectoVerduras.Login
{
    public partial class frmRegistro : Form
    {
        public cEmpleados empleados = new cEmpleados();
       
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void lklRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login.frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (!validarDatos())
            {
                object[] vec = new object[12];
                vec[1] = "name imahen";
                vec[2] = "name imahen";
                vec[3] = "name imahen";
                vec[4] = "name imahen";
                vec[5] = "name imahen";
                vec[6] = "name imahen";
                vec[7] = "name imahen";
                vec[8] = "name imahen";
                vec[9] = "name imahen";
                vec[10] = "name imahen";
                vec[11] = "name imahen";
                
                empleados.guardarEmpleado(vec);
                MessageBox.Show("El empleado se registro correctamente", "Registro", MessageBoxButtons.OK);
                
            }
        
        }

        public bool validarDatos()
        {
            if (txtCedula.Texts == "" || txtNombre.Texts == "" || txtApellido.Texts == "" || txtCorreo.Texts == "" || txtDireccion.Texts == "" || txtCorreo.Texts == "")
            {
                MessageBox.Show("Ingrese todos los datos");
                return false;
             }
            if (txtContraseña.Texts != texBxConfirmarContra.Texts)
            {
                MessageBox.Show("Las constrasenas no coinsiden");
                return false;
            }

            return true;
        }

        private void botonImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName; // gurda la direccion de la imagen
                    pbxFotoPerfil.Image = Image.FromFile(imagen); // carga la imagen¡
                    pbxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
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

       

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
         private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if (txtCedula.Texts == "")
            {
                txtCedula.Texts = "Cédula";
               
            }
        }

        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if (txtCedula.Texts == "Cédula")
            {
                txtCedula.Texts = "";
             
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {

            if (txtNombre.Texts == "")
            {
                txtNombre.Texts = "Nombre";        
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Texts == "Nombre")
            {
                txtNombre.Texts = "";
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {

            if (txtApellido.Texts == "")
            {
                txtApellido.Texts = "Apellido";
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Texts == "Apellido")
            {
                txtApellido.Texts = "";
            }
        }

        private void txtDireccion_Leave(object sender, EventArgs e)
        {
            if (txtDireccion.Texts == "")
            {
                txtDireccion.Texts = "Dirección";
            }
          
        }

        private void txtDireccion_Enter(object sender, EventArgs e)
        {
            if (txtDireccion.Texts == "Dirección")
            {
                txtDireccion.Texts = "";
            }
        }

        private void textTelefono_Leave(object sender, EventArgs e)
        {
            if (textTelefono.Texts == "")
            {
                textTelefono.Texts = "Teléfono";
            }
        }

        private void textTelefono_Enter(object sender, EventArgs e)
        {
            if (textTelefono.Texts == "Telefono")
            {
                textTelefono.Texts = "";
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {

            if (txtCorreo.Texts == "")
            {
                txtCorreo.Texts = "Correo Electrónico";
            }
            
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Texts == "Correo Electrónico")
            {
                txtCorreo.Texts = "";
            }
        }

        private void texBxConfirmarContra_Leave(object sender, EventArgs e)
        {
            if (texBxConfirmarContra.Texts == "")
            {
                texBxConfirmarContra.Texts = "Confirmar Contraseña";
                texBxConfirmarContra.PasswordChar = false;
            }

        }

        private void texBxConfirmarContra_Enter(object sender, EventArgs e)
        {
            if (texBxConfirmarContra.Texts == "ConfirmarContra")
            {
                texBxConfirmarContra.Texts = "";
                texBxConfirmarContra.PasswordChar = true;
            }
        }
    }
}
