﻿using System;
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
    public partial class frmEmpleadosEliminar : Form
    {
        public frmEmpleadosEliminar()
        {
            InitializeComponent();
            gbxEmpleado.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbxEmpleado.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
