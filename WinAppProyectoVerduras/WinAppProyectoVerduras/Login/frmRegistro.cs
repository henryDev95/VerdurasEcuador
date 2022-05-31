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
    public partial class frmRegistro : Form
    {
        public cEmpleados empleados = new cEmpleados();
       
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void lklRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
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

       


    }
}
