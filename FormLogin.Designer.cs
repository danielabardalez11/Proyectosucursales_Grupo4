namespace Proyectosucursales_Grupo4
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            lblcuil = new Label();
            lblcontraseña = new Label();
            txtcontraseña = new TextBox();
            pictureBox1 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            btningresar = new Button();
            btnVerContraLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            btnRegistro = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblcuil
            // 
            lblcuil.AutoSize = true;
            lblcuil.Font = new Font("Sitka Small", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcuil.ForeColor = SystemColors.ActiveCaptionText;
            lblcuil.Location = new Point(92, 295);
            lblcuil.Margin = new Padding(4, 0, 4, 0);
            lblcuil.Name = "lblcuil";
            lblcuil.Size = new Size(85, 40);
            lblcuil.TabIndex = 0;
            lblcuil.Text = "CUIL";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Sitka Small", 14F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblcontraseña.Location = new Point(92, 384);
            lblcontraseña.Margin = new Padding(4, 0, 4, 0);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(173, 40);
            lblcontraseña.TabIndex = 1;
            lblcontraseña.Text = "Contraseña";
            lblcontraseña.Click += lblcontraseña_Click;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontraseña.Location = new Point(156, 429);
            txtcontraseña.Margin = new Padding(4, 5, 4, 5);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PlaceholderText = "Escriba su Contraseña";
            txtcontraseña.Size = new Size(256, 39);
            txtcontraseña.TabIndex = 2;
            txtcontraseña.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.Cursor;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 81);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(156, 340);
            maskedTextBox1.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox1.Mask = "00-00000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(196, 39);
            maskedTextBox1.TabIndex = 5;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            btningresar.Location = new Point(180, 497);
            btningresar.Margin = new Padding(4, 5, 4, 5);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(150, 67);
            btningresar.TabIndex = 6;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += Btningresar_Click;
            // 
            // btnVerContraLogin
            // 
            btnVerContraLogin.Image = (Image)resources.GetObject("btnVerContraLogin.Image");
            btnVerContraLogin.Location = new Point(419, 425);
            btnVerContraLogin.Name = "btnVerContraLogin";
            btnVerContraLogin.Size = new Size(65, 51);
            btnVerContraLogin.TabIndex = 10;
            btnVerContraLogin.UseVisualStyleBackColor = true;
            btnVerContraLogin.Click += btnVerContraLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(163, 29);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 12;
            label2.Text = "Inicia Sesión";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 6);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 13;
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.GreenYellow;
            btnRegistro.Font = new Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(346, 581);
            btnRegistro.Margin = new Padding(4, 5, 4, 5);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(169, 41);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 587);
            label1.Name = "label1";
            label1.Size = new Size(318, 28);
            label1.TabIndex = 11;
            label1.Text = "Haz clic aqui para crear tu cuenta!";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            BackColor = Color.FromArgb(141, 215, 254);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(534, 638);
=======
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(400, 458);
>>>>>>> actualizacion diseño
            Controls.Add(btnRegistro);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVerContraLogin);
            Controls.Add(btningresar);
            Controls.Add(maskedTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(txtcontraseña);
            Controls.Add(lblcontraseña);
            Controls.Add(lblcuil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio ";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcuil;
        private Label lblcontraseña;
        private TextBox txtcontraseña;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox1;
        private Button btningresar;
        private Button btnVerContraLogin;
        private Label label2;
        private Label label3;
        private Button btnRegistro;
        private Label label1;
    }
}