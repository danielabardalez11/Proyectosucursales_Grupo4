namespace Proyectosucursales_Grupo4
{
    partial class Formprincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formprincipal));
            label1 = new Label();
            lblnombresucur = new Label();
            txtnbresucursal = new TextBox();
            label2 = new Label();
            txtnumsucursal = new TextBox();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 52);
            label1.TabIndex = 0;
            label1.Text = "SUCURSAL";
            // 
            // lblnombresucur
            // 
            lblnombresucur.AutoSize = true;
            lblnombresucur.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombresucur.ImageAlign = ContentAlignment.MiddleLeft;
            lblnombresucur.Location = new Point(12, 97);
            lblnombresucur.Name = "lblnombresucur";
            lblnombresucur.Size = new Size(199, 24);
            lblnombresucur.TabIndex = 1;
            lblnombresucur.Text = "Nombre de la sucursal";
            // 
            // txtnbresucursal
            // 
            txtnbresucursal.Location = new Point(217, 97);
            txtnbresucursal.Name = "txtnbresucursal";
            txtnbresucursal.Size = new Size(127, 23);
            txtnbresucursal.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 144);
            label2.Name = "label2";
            label2.Size = new Size(134, 24);
            label2.TabIndex = 3;
            label2.Text = "N° de Sucursal";
            // 
            // txtnumsucursal
            // 
            txtnumsucursal.Location = new Point(217, 145);
            txtnumsucursal.Name = "txtnumsucursal";
            txtnumsucursal.Size = new Size(88, 23);
            txtnumsucursal.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(599, 144);
            label3.Name = "label3";
            label3.Size = new Size(162, 24);
            label3.TabIndex = 5;
            label3.Text = "Fecha de apertura";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(492, 142);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(101, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(614, 98);
            label4.Name = "label4";
            label4.Size = new Size(82, 24);
            label4.TabIndex = 7;
            label4.Text = "Teléfono";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(440, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 23);
            textBox1.TabIndex = 8;
            // 
            // Formprincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(791, 519);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtnumsucursal);
            Controls.Add(label2);
            Controls.Add(txtnbresucursal);
            Controls.Add(lblnombresucur);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Formprincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "     Sucursales";
            Load += Formprincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblnombresucur;
        private TextBox txtnbresucursal;
        private Label label2;
        private TextBox txtnumsucursal;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox textBox1;
    }
}
