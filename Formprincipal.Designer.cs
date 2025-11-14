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
            txtnombresucursal = new TextBox();
            label2 = new Label();
            txtnumsucursal = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            label4 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtLocalidad = new TextBox();
            txtNumCalle = new TextBox();
            txtCalle = new TextBox();
            cmbProvincia = new ComboBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 26.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(336, 77);
            label1.TabIndex = 0;
            label1.Text = "SUCURSAL";
            // 
            // lblnombresucur
            // 
            lblnombresucur.AutoSize = true;
            lblnombresucur.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnombresucur.ForeColor = SystemColors.ButtonHighlight;
            lblnombresucur.ImageAlign = ContentAlignment.MiddleLeft;
            lblnombresucur.Location = new Point(300, 90);
            lblnombresucur.Name = "lblnombresucur";
            lblnombresucur.Size = new Size(299, 35);
            lblnombresucur.TabIndex = 1;
            lblnombresucur.Text = "Nombre de la sucursal";
            // 
            // txtnombresucursal
            // 
            txtnombresucursal.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombresucursal.Location = new Point(291, 135);
            txtnombresucursal.Margin = new Padding(3, 4, 3, 4);
            txtnombresucursal.Name = "txtnombresucursal";
            txtnombresucursal.Size = new Size(308, 35);
            txtnombresucursal.TabIndex = 2;
            txtnombresucursal.TextChanged += txtnbresucursal_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(641, 90);
            label2.Name = "label2";
            label2.Size = new Size(200, 35);
            label2.TabIndex = 3;
            label2.Text = "N° de Sucursal";
            // 
            // txtnumsucursal
            // 
            txtnumsucursal.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnumsucursal.Location = new Point(691, 135);
            txtnumsucursal.Margin = new Padding(3, 4, 3, 4);
            txtnumsucursal.Name = "txtnumsucursal";
            txtnumsucursal.Size = new Size(100, 35);
            txtnumsucursal.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(17, 90);
            label3.Name = "label3";
            label3.Size = new Size(244, 35);
            label3.TabIndex = 5;
            label3.Text = "Fecha de apertura";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarFont = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(37, 135);
            dtpFecha.Margin = new Padding(3, 4, 3, 4);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(198, 35);
            dtpFecha.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(461, 204);
            label4.Name = "label4";
            label4.Size = new Size(125, 35);
            label4.TabIndex = 7;
            label4.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(605, 208);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(226, 35);
            txtTelefono.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(17, 284);
            label5.Name = "label5";
            label5.Size = new Size(150, 35);
            label5.TabIndex = 9;
            label5.Text = "N° de calle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(17, 209);
            label6.Name = "label6";
            label6.Size = new Size(78, 35);
            label6.TabIndex = 10;
            label6.Text = "Calle";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(461, 279);
            label7.Name = "label7";
            label7.Size = new Size(138, 35);
            label7.TabIndex = 11;
            label7.Text = "Localidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(219, 366);
            label8.Name = "label8";
            label8.Size = new Size(136, 35);
            label8.TabIndex = 12;
            label8.Text = "Provincia";
            // 
            // txtLocalidad
            // 
            txtLocalidad.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocalidad.Location = new Point(605, 284);
            txtLocalidad.Margin = new Padding(3, 4, 3, 4);
            txtLocalidad.Name = "txtLocalidad";
            txtLocalidad.Size = new Size(226, 35);
            txtLocalidad.TabIndex = 14;
            // 
            // txtNumCalle
            // 
            txtNumCalle.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumCalle.Location = new Point(189, 289);
            txtNumCalle.Margin = new Padding(3, 4, 3, 4);
            txtNumCalle.Name = "txtNumCalle";
            txtNumCalle.Size = new Size(166, 35);
            txtNumCalle.TabIndex = 15;
            // 
            // txtCalle
            // 
            txtCalle.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCalle.Location = new Point(172, 209);
            txtCalle.Margin = new Padding(3, 4, 3, 4);
            txtCalle.Name = "txtCalle";
            txtCalle.Size = new Size(263, 35);
            txtCalle.TabIndex = 16;
            // 
            // cmbProvincia
            // 
            cmbProvincia.Font = new Font("Sitka Small", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProvincia.FormattingEnabled = true;
            cmbProvincia.Items.AddRange(new object[] { "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucumán" });
            cmbProvincia.Location = new Point(461, 370);
            cmbProvincia.Margin = new Padding(3, 4, 3, 4);
            cmbProvincia.Name = "cmbProvincia";
            cmbProvincia.Size = new Size(263, 40);
            cmbProvincia.TabIndex = 17;
            cmbProvincia.Text = "Seleccione Provincia";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Small", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(339, 438);
            button1.Name = "button1";
            button1.Size = new Size(153, 50);
            button1.TabIndex = 19;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Formprincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Brown;
            ClientSize = new Size(853, 516);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(cmbProvincia);
            Controls.Add(txtCalle);
            Controls.Add(txtNumCalle);
            Controls.Add(txtLocalidad);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTelefono);
            Controls.Add(label4);
            Controls.Add(dtpFecha);
            Controls.Add(label3);
            Controls.Add(txtnumsucursal);
            Controls.Add(label2);
            Controls.Add(txtnombresucursal);
            Controls.Add(lblnombresucur);
            Controls.Add(label1);
            Font = new Font("Sitka Small", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "Formprincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Agregar Sucursal";
            Load += Formprincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblnombresucur;
        private TextBox txtnombresucursal;
        private Label label2;
        private TextBox txtnumsucursal;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Label label4;
        private TextBox txtTelefono;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtLocalidad;
        private TextBox txtNumCalle;
        private TextBox txtCalle;
        private ComboBox cmbProvincia;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
