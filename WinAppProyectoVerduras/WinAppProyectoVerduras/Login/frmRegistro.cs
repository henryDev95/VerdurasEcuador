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
            if (validarDatos())
            {
                Random rd = new Random();

                int rand_num = rd.Next(100, 200);

                object[] vec = new object[9];
                vec[0] = rand_num;
                vec[1] = txtNombre.Texts;
                vec[2] = txtApellido.Texts;
                vec[3] = txtCorreo.Texts;
                vec[4] = "name imahen";
                vec[5] = txtContraseña.Texts;
                vec[6] = txtCedula.Texts;
                vec[7] = txtCiudad.Texts;
                vec[8] = comboBoxRol.Text;
                
                empleados.guardarEmpleado(vec);
                MessageBox.Show("El empleado se registro correctamente", "Registro", MessageBoxButtons.OK);
                this.Close();
            }
            else { return; }
        
        }

        public bool validarDatos()
        {
            if (txtCedula.Texts == "" || txtNombre.Texts == "" || txtApellido.Texts == "" || txtCorreo.Texts == "" || txtCiudad.Texts == "" || txtCorreo.Texts == "")
            {
                MessageBox.Show("Ingrese todos los datos");
                return false;
             }
            if (txtContraseña.Texts != txtConfirmarContraseña.Texts)
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
            catch (Exception ex)
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

        private void txtConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            if (txtConfirmarContraseña.Texts == "Confirmar Contraseña")
            {
                txtConfirmarContraseña.Texts = "";
                txtConfirmarContraseña.PasswordChar = true;
            }
        }

        private void txtConfirmarContraseña_Leave(object sender, EventArgs e)
        {

            if (txtConfirmarContraseña.Texts == "")
            {
                txtConfirmarContraseña.Texts = "Confirmar Contraseña";
                txtConfirmarContraseña.PasswordChar = false;
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
    
    }
}
