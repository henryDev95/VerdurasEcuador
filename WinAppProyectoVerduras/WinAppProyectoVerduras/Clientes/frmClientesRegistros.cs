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
    public partial class frmClientesRegistros : Form
    {

        public cClientes clientes = new cClientes();
        Clases.ValidarClienteCam validarCampos = new Clases.ValidarClienteCam();
        Clases.Correo ValidadCorreo = new Clases.Correo();
        public string cedula, nombre, apellido, correo, direccion, telefono, descripcion;
        object[] vec = new object[7];

        public frmClientesRegistros()
        {
            InitializeComponent();
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
                    direccion = TxtDireccion.Text;
                    TxtTelefono.Focus();

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
                    if ((validarCampos.ValidarTelefonos7a10Digitos(TxtTelefono.Text)))
                    {
                        telefono = TxtTelefono.Text;
                        TxtCorreo.Focus();
                    }
                    else
                    {
                        TxtTelefono.Focus();
                        MessageBox.Show("!Teléfono Incorrecta! ");
                        TxtTelefono.Clear();
                        telefono = TxtTelefono.Text;
                    }
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
                        TxtDescripcion.Focus();
                    }
                    else
                    {
                        TxtCorreo.Focus();
                        MessageBox.Show("!Correo Electrónico Incorrecto! ");
                        TxtCorreo.Clear();
                    }

                }
            }
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (TxtDescripcion.Text == "")
                {
                    TxtDescripcion.Focus();
                   
                }
                else
                {
                    descripcion = TxtDescripcion.Text;
                 

                }
            }

        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {
           
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
                else
                {

                    if ((txtCedula.Text.Length == 10))
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

     
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vec[0] = cedula;
            vec[1] = nombre;
            vec[2] = apellido;
            vec[3] = telefono;
            vec[4] = direccion;
            vec[5] = correo;
            vec[6] = descripcion;
            clientes.guardarCliente(vec);
            MessageBox.Show("El cliente se registro correctamente");
            limpiarCuadroTexto();
            limpiarVariable();
            

        }

        public void limpiarVariable()
        {
            cedula = "";
            nombre = "";
            apellido = "";
            direccion = "";
            telefono = "";
            correo = "";
            descripcion = "";
        }

        public void limpiarCuadroTexto()
        {
            txtCedula.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtCorreo.Clear();
            TxtDescripcion.Clear();
            TxtCorreo.Clear();
            TxtTelefono.Clear();
            TxtDireccion.Clear();
        }

        private void lklRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

       
    }
}
