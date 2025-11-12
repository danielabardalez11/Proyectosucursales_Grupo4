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
            btncancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblcuil
            // 
            lblcuil.AutoSize = true;
            lblcuil.Font = new Font("Georgia", 14.25F, FontStyle.Italic);
            lblcuil.ForeColor = SystemColors.ActiveCaptionText;
            lblcuil.Location = new Point(68, 189);
            lblcuil.Name = "lblcuil";
            lblcuil.Size = new Size(51, 23);
            lblcuil.TabIndex = 0;
            lblcuil.Text = "Cuil:";
            // 
            // lblcontraseña
            // 
            lblcontraseña.AutoSize = true;
            lblcontraseña.Font = new Font("Georgia", 14.25F, FontStyle.Italic);
            lblcontraseña.Location = new Point(51, 265);
            lblcontraseña.Name = "lblcontraseña";
            lblcontraseña.Size = new Size(116, 23);
            lblcontraseña.TabIndex = 1;
            lblcontraseña.Text = "Contraseña:";
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(173, 265);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(137, 23);
            txtcontraseña.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 137);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(173, 189);
            maskedTextBox1.Mask = "00-00000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(83, 23);
            maskedTextBox1.TabIndex = 5;
            // 
            // btningresar
            // 
            btningresar.Location = new Point(68, 326);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(75, 23);
            btningresar.TabIndex = 6;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = true;
            btningresar.Click += Btningresar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(173, 326);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 7;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            btncancelar.Click += Btncancelar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(333, 371);
            Controls.Add(btncancelar);
            Controls.Add(btningresar);
            Controls.Add(maskedTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(txtcontraseña);
            Controls.Add(lblcontraseña);
            Controls.Add(lblcuil);
            Name = "FormLogin";
            Text = "FormLogin";
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
        private Button btncancelar;
    }
}