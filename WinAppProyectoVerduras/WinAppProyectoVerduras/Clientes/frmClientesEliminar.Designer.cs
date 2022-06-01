
namespace WinAppProyectoVerduras.Clientes
{
    partial class frmClientesEliminar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaBus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labDireccion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labDescripcion = new System.Windows.Forms.Label();
            this.labCorreoElec = new System.Windows.Forms.Label();
            this.labTelefono = new System.Windows.Forms.Label();
            this.labApellido = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.labCedula = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCedulaBus);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(100, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 72);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar Cliente a Eliminar";
            // 
            // txtCedulaBus
            // 
            this.txtCedulaBus.Location = new System.Drawing.Point(142, 47);
            this.txtCedulaBus.Name = "txtCedulaBus";
            this.txtCedulaBus.Size = new System.Drawing.Size(162, 20);
            this.txtCedulaBus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Location = new System.Drawing.Point(72, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cédula:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscar.Location = new System.Drawing.Point(316, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 27);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.labDireccion);
            this.gbxCliente.Controls.Add(this.label3);
            this.gbxCliente.Controls.Add(this.labDescripcion);
            this.gbxCliente.Controls.Add(this.labCorreoElec);
            this.gbxCliente.Controls.Add(this.labTelefono);
            this.gbxCliente.Controls.Add(this.labApellido);
            this.gbxCliente.Controls.Add(this.labNombre);
            this.gbxCliente.Controls.Add(this.labCedula);
            this.gbxCliente.Controls.Add(this.label10);
            this.gbxCliente.Controls.Add(this.label9);
            this.gbxCliente.Controls.Add(this.label8);
            this.gbxCliente.Controls.Add(this.label7);
            this.gbxCliente.Controls.Add(this.label6);
            this.gbxCliente.Controls.Add(this.label4);
            this.gbxCliente.Controls.Add(this.btnCancelar);
            this.gbxCliente.Controls.Add(this.btnEliminar);
            this.gbxCliente.Controls.Add(this.label5);
            this.gbxCliente.Location = new System.Drawing.Point(100, 79);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(472, 287);
            this.gbxCliente.TabIndex = 29;
            this.gbxCliente.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(368, 229);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 34);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminar.Location = new System.Drawing.Point(368, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 34);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(129, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Datos del Cliente a Eliminar";
            // 
            // labDireccion
            // 
            this.labDireccion.AutoSize = true;
            this.labDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDireccion.Location = new System.Drawing.Point(164, 183);
            this.labDireccion.Name = "labDireccion";
            this.labDireccion.Size = new System.Drawing.Size(174, 20);
            this.labDireccion.TabIndex = 50;
            this.labDireccion.Text = ".................................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Azure;
            this.label3.Location = new System.Drawing.Point(60, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Dirección:";
            // 
            // labDescripcion
            // 
            this.labDescripcion.AutoSize = true;
            this.labDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDescripcion.Location = new System.Drawing.Point(164, 243);
            this.labDescripcion.Name = "labDescripcion";
            this.labDescripcion.Size = new System.Drawing.Size(174, 20);
            this.labDescripcion.TabIndex = 48;
            this.labDescripcion.Text = ".................................";
            // 
            // labCorreoElec
            // 
            this.labCorreoElec.AutoSize = true;
            this.labCorreoElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCorreoElec.Location = new System.Drawing.Point(164, 215);
            this.labCorreoElec.Name = "labCorreoElec";
            this.labCorreoElec.Size = new System.Drawing.Size(174, 20);
            this.labCorreoElec.TabIndex = 47;
            this.labCorreoElec.Text = ".................................";
            // 
            // labTelefono
            // 
            this.labTelefono.AutoSize = true;
            this.labTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefono.Location = new System.Drawing.Point(164, 155);
            this.labTelefono.Name = "labTelefono";
            this.labTelefono.Size = new System.Drawing.Size(174, 20);
            this.labTelefono.TabIndex = 46;
            this.labTelefono.Text = ".................................";
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(164, 124);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(174, 20);
            this.labApellido.TabIndex = 45;
            this.labApellido.Text = ".................................";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(164, 93);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(174, 20);
            this.labNombre.TabIndex = 44;
            this.labNombre.Text = ".................................";
            // 
            // labCedula
            // 
            this.labCedula.AutoSize = true;
            this.labCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCedula.Location = new System.Drawing.Point(164, 57);
            this.labCedula.Name = "labCedula";
            this.labCedula.Size = new System.Drawing.Size(174, 20);
            this.labCedula.TabIndex = 43;
            this.labCedula.Text = ".................................";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Azure;
            this.label10.Location = new System.Drawing.Point(36, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Azure;
            this.label9.Location = new System.Drawing.Point(72, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cédula :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Azure;
            this.label8.Location = new System.Drawing.Point(63, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(3, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Correo Electrónico:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Azure;
            this.label6.Location = new System.Drawing.Point(66, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Azure;
            this.label4.Location = new System.Drawing.Point(71, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Nombre:";
            // 
            // frmClientesEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(668, 378);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientesEliminar";
            this.Text = "frmClientesEliminar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaBus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labDescripcion;
        private System.Windows.Forms.Label labCorreoElec;
        private System.Windows.Forms.Label labTelefono;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.Label labCedula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
    }
}