﻿using System;
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
    public partial class frmProductosEditar : Form
    {
        public frmProductosEditar()
        {
            InitializeComponent();
            gbxProducto.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            gbxProducto.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
