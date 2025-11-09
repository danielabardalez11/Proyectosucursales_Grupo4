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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 30);
            label1.TabIndex = 0;
            label1.Text = "Registro";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 121);
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
            // textBox1
            // 
            textBox1.Location = new Point(278, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(321, 37);
            textBox1.TabIndex = 3;
            textBox1.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(278, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(321, 37);
            textBox3.TabIndex = 6;
            textBox3.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 234);
            label4.Name = "label4";
            label4.Size = new Size(240, 30);
            label4.TabIndex = 5;
            label4.Text = "Confirmar Contraseña";
            // 
            // button1
            // 
            button1.Location = new Point(120, 311);
            button1.Name = "button1";
            button1.Size = new Size(131, 41);
            button1.TabIndex = 7;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(344, 311);
            button2.Name = "button2";
            button2.Size = new Size(176, 41);
            button2.TabIndex = 8;
            button2.Text = "Volver al login";
            button2.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(278, 121);
            maskedTextBox1.Mask = "00-00000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(146, 37);
            maskedTextBox1.TabIndex = 9;
            // 
            // Registroform
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 395);
            Controls.Add(maskedTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label4;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox1;
    }
}