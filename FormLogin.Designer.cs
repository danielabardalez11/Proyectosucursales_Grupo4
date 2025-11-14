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
            maskedTextBox1 = new MaskedTextBox();
            btningresar = new Button();
            btnVerContraLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            btnRegistro = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblcuil
            // 
            lblcuil.AutoSize = true;
            lblcuil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblcuil.ForeColor = SystemColors.ActiveCaptionText;
            lblcuil.Location = new Point(66, 160);
            lblcuil.Margin = new Padding(4, 0, 4, 0);
            lblcuil.Name = "lblcuil";
            lblcuil.Size = new Size(65, 32);
            lblcuil.TabIndex = 0;
            lblcuil.Text = "CUIL";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblcontraseña.Location = new Point(66, 284);
            lblcontraseña.Margin = new Padding(4, 0, 4, 0);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(138, 32);
            lblcontraseña.TabIndex = 1;
            lblcontraseña.Text = "Contraseña";
            lblcontraseña.Click += lblcontraseña_Click;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontraseña.Location = new Point(134, 321);
            txtcontraseña.Margin = new Padding(4, 5, 4, 5);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PlaceholderText = "Escriba su Contraseña";
            txtcontraseña.Size = new Size(256, 42);
            txtcontraseña.TabIndex = 2;
            txtcontraseña.UseSystemPasswordChar = true;
            txtcontraseña.TextChanged += txtcontraseña_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.Location = new Point(134, 197);
            maskedTextBox1.Margin = new Padding(4, 5, 4, 5);
            maskedTextBox1.Mask = "00-00000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(225, 42);
            maskedTextBox1.TabIndex = 5;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btningresar.ForeColor = Color.FromArgb(0, 51, 102);
            btningresar.Location = new Point(180, 392);
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
            btnVerContraLogin.Location = new Point(397, 321);
            btnVerContraLogin.Name = "btnVerContraLogin";
            btnVerContraLogin.Size = new Size(65, 48);
            btnVerContraLogin.TabIndex = 10;
            btnVerContraLogin.UseVisualStyleBackColor = true;
            btnVerContraLogin.Click += btnVerContraLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 51, 102);
            label2.Location = new Point(134, 73);
            label2.Name = "label2";
            label2.Size = new Size(255, 54);
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
            btnRegistro.BackColor = Color.FromArgb(0, 51, 102);
            btnRegistro.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.ForeColor = SystemColors.ButtonHighlight;
            btnRegistro.Location = new Point(171, 511);
            btnRegistro.Margin = new Padding(4, 5, 4, 5);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(174, 49);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 474);
            label1.Name = "label1";
            label1.Size = new Size(387, 32);
            label1.TabIndex = 11;
            label1.Text = "Haz clic aqui para crear tu cuenta!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(516, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(591, 625);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(628, 157);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(357, 267);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1102, 600);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnRegistro);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnVerContraLogin);
            Controls.Add(btningresar);
            Controls.Add(maskedTextBox1);
            Controls.Add(txtcontraseña);
            Controls.Add(lblcontraseña);
            Controls.Add(lblcuil);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Inicia Sesion";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcuil;
        private Label lblcontraseña;
        private TextBox txtcontraseña;
        private MaskedTextBox maskedTextBox1;
        private Button btningresar;
        private Button btnVerContraLogin;
        private Label label2;
        private Label label3;
        private Button btnRegistro;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}