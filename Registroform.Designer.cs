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
            label1.Font = new Font("Cascadia Mono", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 29);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 124);
            label2.Name = "label2";
            label2.Size = new Size(61, 30);
            label2.TabIndex = 1;
            label2.Text = "CUIL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 182);
            label3.Name = "label3";
            label3.Size = new Size(130, 30);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(278, 179);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PlaceholderText = "Ingrese contraseña";
            txtContrasena.Size = new Size(259, 37);
            txtContrasena.TabIndex = 3;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // txtRepetirContrasena
            // 
            txtRepetirContrasena.Location = new Point(278, 241);
            txtRepetirContrasena.Name = "txtRepetirContrasena";
            txtRepetirContrasena.PlaceholderText = "Repita contraseña";
            txtRepetirContrasena.Size = new Size(259, 37);
            txtRepetirContrasena.TabIndex = 6;
            txtRepetirContrasena.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 244);
            label4.Name = "label4";
            label4.Size = new Size(240, 30);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Contraseña";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(120, 311);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(131, 41);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolverlogin
            // 
            btnVolverlogin.Location = new Point(344, 311);
            btnVolverlogin.Name = "btnVolverlogin";
            btnVolverlogin.Size = new Size(176, 41);
            btnVolverlogin.TabIndex = 8;
            btnVolverlogin.Text = "Volver al login";
            btnVolverlogin.UseVisualStyleBackColor = true;
            // 
            // mtbCuil
            // 
            mtbCuil.Location = new Point(278, 121);
            mtbCuil.Mask = "00-00000000-0";
            mtbCuil.Name = "mtbCuil";
            mtbCuil.Size = new Size(146, 37);
            mtbCuil.TabIndex = 9;
            mtbCuil.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // btnVercontrasena
            // 
            btnVercontrasena.Image = (Image)resources.GetObject("btnVercontrasena.Image");
            btnVercontrasena.Location = new Point(557, 173);
            btnVercontrasena.Name = "btnVercontrasena";
            btnVercontrasena.Size = new Size(60, 49);
            btnVercontrasena.TabIndex = 10;
            btnVercontrasena.UseVisualStyleBackColor = true;
            btnVercontrasena.Click += button3_Click;
            // 
            // btnVerRepetir
            // 
            btnVerRepetir.Image = (Image)resources.GetObject("btnVerRepetir.Image");
            btnVerRepetir.Location = new Point(557, 234);
            btnVerRepetir.Name = "btnVerRepetir";
            btnVerRepetir.Size = new Size(60, 50);
            btnVerRepetir.TabIndex = 11;
            btnVerRepetir.UseVisualStyleBackColor = true;
            btnVerRepetir.Click += btnVerRepetir_Click;
            // 
            // Registroform
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(639, 395);
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
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Registroform";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
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