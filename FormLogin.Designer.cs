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
            lblbienvenido = new Label();
            btnRegistro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblcuil
            // 
            lblcuil.AutoSize = true;
            lblcuil.Font = new Font("Sitka Small", 14.25F, FontStyle.Italic);
            lblcuil.ForeColor = SystemColors.ActiveCaptionText;
            lblcuil.Location = new Point(71, 239);
            lblcuil.Name = "lblcuil";
            lblcuil.Size = new Size(57, 28);
            lblcuil.TabIndex = 0;
            lblcuil.Text = "Cuil:";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Sitka Small", 14.25F, FontStyle.Italic);
            lblcontraseña.Location = new Point(35, 293);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(126, 28);
            lblcontraseña.TabIndex = 1;
            lblcontraseña.Text = "Contraseña:";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(178, 300);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(137, 23);
            txtcontraseña.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.Cursor;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(178, 239);
            maskedTextBox1.Mask = "00-00000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(78, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // btningresar
            // 
            btningresar.Font = new Font("Sitka Small", 12F, FontStyle.Bold);
            btningresar.Location = new Point(231, 361);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(105, 40);
            btningresar.TabIndex = 6;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += Btningresar_Click;
            // 
            // lblbienvenido
            // 
            lblbienvenido.AutoSize = true;
            lblbienvenido.Font = new Font("ROSSTEN", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbienvenido.Location = new Point(46, 27);
            lblbienvenido.Name = "lblbienvenido";
            lblbienvenido.Size = new Size(290, 33);
            lblbienvenido.TabIndex = 8;
            lblbienvenido.Text = "Bienvenido Inicie sesión";
            lblbienvenido.Click += lblbienvenido_Click;
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Sitka Small", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(71, 361);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(116, 40);
            btnRegistro.TabIndex = 9;
            btnRegistro.Text = "Registrarse";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(400, 429);
            Controls.Add(btnRegistro);
            Controls.Add(lblbienvenido);
            Controls.Add(btningresar);
            Controls.Add(maskedTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(txtcontraseña);
            Controls.Add(lblcontraseña);
            Controls.Add(lblcuil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
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
        private Label lblbienvenido;
        private Button btnRegistro;
    }
}