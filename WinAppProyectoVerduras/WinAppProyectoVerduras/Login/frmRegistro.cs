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
        Clases.ValidarClienteCam validarCampos = new Clases.ValidarClienteCam();
        Clases.Correo ValidadCorreo = new Clases.Correo();
        public string cedula, nombre, apellido, correo, contraseña, direccion, telefono, genero, estado, imagen, rol; 
        
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
                      
                object[] vec = new object[12];
                vec[1] = cedula;
                vec[2] = nombre;
                vec[3] = apellido;
                vec[4] = correo;
                vec[5] = contraseña;
                vec[6] = direccion;
                vec[7] = telefono;
                vec[8] = imagen;
                vec[9] = rol;
                vec[10] = genero;
                vec[11] = "Activo";
                
                empleados.guardarEmpleado(vec);
                MessageBox.Show("El empleado se registro correctamente", "Registro", MessageBoxButtons.OK);
                
        
        
        }

       

        private void botonImagen_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    imagen = openFileDialog1.FileName; // gurda la direccion de la imagen
                    MessageBox.Show(imagen);
                    pbxFotoPerfil.Image = Image.FromFile(imagen); // carga la imagen¡
                    pbxFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;

                }
            }
            catch
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }
           

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            rol = comboBoxRol.SelectedItem.ToString();
        }

        private void comboBoxGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            genero = comboBoxGenero.SelectedItem.ToString();
        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


       
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("En este campo, se coloca números");
               
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCedula.Text == "")
                {
                    txtCedula.Focus();
                }
                else {

                    if ((txtCedula.Text.Length == 10 ))
                    {
                        if ((validarCampos.validadCedula(txtCedula.Text)))
                        {
                            cedula = txtCedula.Text;
                            TxtNombre.Focus();
                        }
                        else
                        {
                            txtCedula.Focus();
                            MessageBox.Show("!Cédula Incorrecta! ");
                            txtCedula.Clear();
                        }
                    }
                    else
                    {
                        txtCedula.Focus();
                        MessageBox.Show("!Longuitud de la cédula incorrecta! ");
                        txtCedula.Clear();
                    }
                                     
                }
            }
       }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtNombre.Text == "")
                {
                    TxtNombre.Focus();
                }
                else
                {
                    nombre = TxtNombre.Text;
                    TxtApellido.Focus();
                   
                }
            }

        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtApellido.Text == "")
                {
                    TxtApellido.Focus();
                }
                else
                {
                    apellido = TxtApellido.Text;
                    TxtDireccion.Focus();

                }
            }

        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("En este campo, se coloca números");

            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtTelefono.Text == "")
                {
                    TxtTelefono.Focus();
                }
                else
                {

                    if (!(validarCampos.ValidarTelefonos7a10Digitos(TxtTelefono.Text)))
                    {
                        TxtTelefono.Focus();
                        MessageBox.Show("!Teléfono Incorrecta! ");
                        TxtTelefono.Clear();
                    }
                    else
                    {
                        telefono = TxtTelefono.Text;
                    }
                   

                }
            }
        }

        private void TxtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtDireccion.Text == "")
                {
                    TxtDireccion.Focus();
                }
                else
                {
                    TxtTelefono.Focus();

                }
            }
        }

        private void TxtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtCorreo.Text == "")
                {
                    TxtCorreo.Focus();
                }
                else
                {
                    if (ValidadCorreo.ValidarEmail(TxtCorreo.Text))
                    {
                        correo = TxtCorreo.Text;
                        TxtContraseña.Focus();
                    }
                    else {
                        TxtCorreo.Focus();
                        MessageBox.Show("!Correo Electrónico Incorrecto! ");
                        TxtCorreo.Clear();
                    }

                }
            }
        }

        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtContraseña.Text == "")
                {
                    TxtContraseña.Focus();
                }
                else
                {
                    if (validarCampos.IsValidPassword(TxtContraseña.Text))
                    {
                        contraseña = TxtContraseña.Text;
                        TxtConfimarContra.Focus();
                    }
                    else
                    {
                        TxtContraseña.Focus();
                        MessageBox.Show("!Contraseña no permitída! ");
                        TxtContraseña.Clear();
                    }

                }
            }
        }

        private void TxtConfimarContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtConfimarContra.Text == "")
                {
                    TxtConfimarContra.Focus();
                }
                else
                {
                    if (!validarCampos.ValidarConfirmacionContraseña(TxtContraseña.Text ,TxtConfimarContra.Text))
                    {
                        TxtConfimarContra.Focus();
                        MessageBox.Show("!La Contraseña no es igual! ");
                        TxtConfimarContra.Clear();
                    }
                }
            }
        }
    }
}
