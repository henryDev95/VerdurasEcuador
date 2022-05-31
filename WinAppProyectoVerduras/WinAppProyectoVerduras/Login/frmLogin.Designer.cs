
namespace WinAppProyectoVerduras.Login
{
    partial class frmLogin
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
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlDelantero = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnContlogin = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.pictMini = new System.Windows.Forms.PictureBox();
            this.pictuCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.textCorreo = new WinAppProyectoVerduras.Clases.TextBox();
            this.txtContraseña = new WinAppProyectoVerduras.Clases.TextBox();
            this.btnIngresar = new WinAppProyectoVerduras.Clases.Botones();
            this.pnlContenedor.SuspendLayout();
            this.pnlDelantero.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnContlogin.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictuCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlContenedor.Controls.Add(this.panelBarraTitulo);
            this.pnlContenedor.Controls.Add(this.pnlDelantero);
            this.pnlContenedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(661, 420);
            this.pnlContenedor.TabIndex = 0;
            this.pnlContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContenedor_Paint);
            // 
            // pnlDelantero
            // 
            this.pnlDelantero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDelantero.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnlDelantero.Controls.Add(this.pictureBox1);
            this.pnlDelantero.Controls.Add(this.panel1);
            this.pnlDelantero.Location = new System.Drawing.Point(27, 35);
            this.pnlDelantero.Name = "pnlDelantero";
            this.pnlDelantero.Size = new System.Drawing.Size(606, 352);
            this.pnlDelantero.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pnContlogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(293, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 352);
            this.panel1.TabIndex = 0;
            // 
            // pnContlogin
            // 
            this.pnContlogin.Controls.Add(this.textCorreo);
            this.pnContlogin.Controls.Add(this.linkLabel1);
            this.pnContlogin.Controls.Add(this.txtContraseña);
            this.pnContlogin.Controls.Add(this.pictureBox2);
            this.pnContlogin.Controls.Add(this.pictureBox6);
            this.pnContlogin.Controls.Add(this.btnIngresar);
            this.pnContlogin.Controls.Add(this.label1);
            this.pnContlogin.Location = new System.Drawing.Point(51, 28);
            this.pnContlogin.Name = "pnContlogin";
            this.pnContlogin.Size = new System.Drawing.Size(215, 257);
            this.pnContlogin.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(80, 231);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 16);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Desea Registrarse ?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO";
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelBarraTitulo.Controls.Add(this.pictMini);
            this.panelBarraTitulo.Controls.Add(this.pictuCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(661, 39);
            this.panelBarraTitulo.TabIndex = 1;
            this.panelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseDown);
            // 
            // pictMini
            // 
            this.pictMini.Image = global::WinAppProyectoVerduras.Properties.Resources.minimizar;
            this.pictMini.Location = new System.Drawing.Point(570, 0);
            this.pictMini.Name = "pictMini";
            this.pictMini.Size = new System.Drawing.Size(38, 39);
            this.pictMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictMini.TabIndex = 1;
            this.pictMini.TabStop = false;
            this.pictMini.Click += new System.EventHandler(this.pictMini_Click);
            // 
            // pictuCerrar
            // 
            this.pictuCerrar.Image = global::WinAppProyectoVerduras.Properties.Resources.cerrar4;
            this.pictuCerrar.Location = new System.Drawing.Point(614, 0);
            this.pictuCerrar.Name = "pictuCerrar";
            this.pictuCerrar.Size = new System.Drawing.Size(44, 39);
            this.pictuCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictuCerrar.TabIndex = 0;
            this.pictuCerrar.TabStop = false;
            this.pictuCerrar.Click += new System.EventHandler(this.pictuCerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pictureBox1.BackgroundImage = global::WinAppProyectoVerduras.Properties.Resources.Password;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(16, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 257);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::WinAppProyectoVerduras.Properties.Resources.Llave;
            this.pictureBox2.Location = new System.Drawing.Point(9, 131);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox6.Image = global::WinAppProyectoVerduras.Properties.Resources.Correo;
            this.pictureBox6.Location = new System.Drawing.Point(9, 78);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // textCorreo
            // 
            this.textCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCorreo.BackColor = System.Drawing.Color.White;
            this.textCorreo.BackgroundImage = global::WinAppProyectoVerduras.Properties.Resources.loguin;
            this.textCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textCorreo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textCorreo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textCorreo.BorderRadius = 10;
            this.textCorreo.BorderSize = 2;
            this.textCorreo.Location = new System.Drawing.Point(39, 78);
            this.textCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.textCorreo.Multiline = false;
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Padding = new System.Windows.Forms.Padding(7);
            this.textCorreo.PasswordChar = false;
            this.textCorreo.PlaceholderColor = System.Drawing.Color.White;
            this.textCorreo.PlaceholderText = "";
            this.textCorreo.Size = new System.Drawing.Size(165, 28);
            this.textCorreo.TabIndex = 21;
            this.textCorreo.Texts = "Correo Electrónico";
            this.textCorreo.UnderlinedStyle = false;
            this.textCorreo.Enter += new System.EventHandler(this.textCorreo_Enter);
            this.textCorreo.Leave += new System.EventHandler(this.textCorreo_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.BackgroundImage = global::WinAppProyectoVerduras.Properties.Resources.loguin;
            this.txtContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtContraseña.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtContraseña.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtContraseña.BorderRadius = 10;
            this.txtContraseña.BorderSize = 2;
            this.txtContraseña.Location = new System.Drawing.Point(39, 131);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Multiline = false;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Padding = new System.Windows.Forms.Padding(7);
            this.txtContraseña.PasswordChar = false;
            this.txtContraseña.PlaceholderColor = System.Drawing.Color.White;
            this.txtContraseña.PlaceholderText = "";
            this.txtContraseña.Size = new System.Drawing.Size(165, 28);
            this.txtContraseña.TabIndex = 20;
            this.txtContraseña.Texts = "Contraseña";
            this.txtContraseña.UnderlinedStyle = false;
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIngresar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIngresar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresar.BorderRadius = 10;
            this.btnIngresar.BorderSize = 2;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(65, 175);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(88, 25);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 420);
            this.Controls.Add(this.pnlContenedor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlDelantero.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnContlogin.ResumeLayout(false);
            this.pnContlogin.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictuCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlDelantero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnContlogin;
        private System.Windows.Forms.Label label1;
        private Clases.Botones btnIngresar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private Clases.TextBox txtContraseña;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Clases.TextBox textCorreo;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox pictMini;
        private System.Windows.Forms.PictureBox pictuCerrar;
    }
}