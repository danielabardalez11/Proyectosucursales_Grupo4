namespace Proyectosucursales_Grupo4
{
    partial class Registroform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registroform));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContrasena = new TextBox();
            txtRepetirContrasena = new TextBox();
            label4 = new Label();
            btnRegistrar = new Button();
            btnVolverlogin = new Button();
            mtbCuil = new MaskedTextBox();
            btnVercontrasena = new Button();
            btnVerRepetir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(140, 47);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(103, 139);
            label2.Name = "label2";
            label2.Size = new Size(74, 40);
            label2.TabIndex = 1;
            label2.Text = "CUIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 207);
            label3.Name = "label3";
            label3.Size = new Size(145, 40);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(278, 209);
            txtContrasena.Margin = new Padding(3, 4, 3, 4);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Ingrese contraseña";
            txtContrasena.Size = new Size(259, 38);
            txtContrasena.TabIndex = 3;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtRepetirContrasena
            // 
            txtRepetirContrasena.Location = new Point(278, 281);
            txtRepetirContrasena.Margin = new Padding(3, 4, 3, 4);
            txtRepetirContrasena.Name = "txtRepetirContrasena";
            txtRepetirContrasena.PlaceholderText = "Repita contraseña";
            txtRepetirContrasena.Size = new Size(259, 38);
            txtRepetirContrasena.TabIndex = 6;
            txtRepetirContrasena.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Banner", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 281);
            label4.Name = "label4";
            label4.Size = new Size(269, 40);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Contraseña";
            label4.Click += label4_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(120, 363);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(131, 48);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolverlogin
            // 
            btnVolverlogin.Location = new Point(344, 363);
            btnVolverlogin.Margin = new Padding(3, 4, 3, 4);
            btnVolverlogin.Name = "btnVolverlogin";
            btnVolverlogin.Size = new Size(176, 48);
            btnVolverlogin.TabIndex = 8;
            btnVolverlogin.Text = "Volver al login";
            btnVolverlogin.UseVisualStyleBackColor = true;
            btnVolverlogin.Click += btnVolverlogin_Click;
            // 
            // mtbCuil
            // 
            mtbCuil.Location = new Point(278, 141);
            mtbCuil.Margin = new Padding(3, 4, 3, 4);
            mtbCuil.Mask = "00-00000000-0";
            mtbCuil.Name = "mtbCuil";
            mtbCuil.Size = new Size(168, 38);
            mtbCuil.TabIndex = 9;
            mtbCuil.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // btnVercontrasena
            // 
            btnVercontrasena.Image = (Image)resources.GetObject("btnVercontrasena.Image");
            btnVercontrasena.Location = new Point(557, 202);
            btnVercontrasena.Margin = new Padding(3, 4, 3, 4);
            btnVercontrasena.Name = "btnVercontrasena";
            btnVercontrasena.Size = new Size(60, 57);
            btnVercontrasena.TabIndex = 10;
            btnVercontrasena.UseVisualStyleBackColor = true;
            btnVercontrasena.Click += button3_Click;
            // 
            // btnVerRepetir
            // 
            btnVerRepetir.Image = (Image)resources.GetObject("btnVerRepetir.Image");
            btnVerRepetir.Location = new Point(557, 273);
            btnVerRepetir.Margin = new Padding(3, 4, 3, 4);
            btnVerRepetir.Name = "btnVerRepetir";
            btnVerRepetir.Size = new Size(60, 58);
            btnVerRepetir.TabIndex = 11;
            btnVerRepetir.UseVisualStyleBackColor = true;
            btnVerRepetir.Click += btnVerRepetir_Click;
            // 
            // Registroform
            // 
            AutoScaleDimensions = new SizeF(13F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(639, 432);
            Controls.Add(btnVerRepetir);
            Controls.Add(btnVercontrasena);
            Controls.Add(mtbCuil);
            Controls.Add(btnVolverlogin);
            Controls.Add(btnRegistrar);
            Controls.Add(txtRepetirContrasena);
            Controls.Add(label4);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Registroform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            Load += Registroform_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContrasena;
        private TextBox txtRepetirContrasena;
        private Label label4;
        private Button btnRegistrar;
        private Button btnVolverlogin;
        private MaskedTextBox mtbCuil;
        private Button btnVercontrasena;
        private Button btnVerRepetir;
    }
}