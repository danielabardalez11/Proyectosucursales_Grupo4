namespace Proyectosucursales_Grupo4
{
    partial class CrudSucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudSucursales));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnCerrarSesion = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            NumSucursal = new DataGridViewTextBoxColumn();
            NombreSucursal = new DataGridViewTextBoxColumn();
            FechaSucursal = new DataGridViewTextBoxColumn();
            TelefonoSucursal = new DataGridViewTextBoxColumn();
            CalleSucursal = new DataGridViewTextBoxColumn();
            NumCalleSucursal = new DataGridViewTextBoxColumn();
            LocalidadSucursal = new DataGridViewTextBoxColumn();
            ProvinciaSucursal = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 51, 102);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnModificar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 687);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(98, 606);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(101, 69);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(39, 551);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(224, 49);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(66, 464);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(167, 57);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleRight;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Gold;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            btnModificar.Location = new Point(63, 388);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(170, 61);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.MiddleRight;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.LimeGreen;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ButtonHighlight;
            btnAgregar.Image = (Image)resources.GetObject("btnAgregar.Image");
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(66, 301);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(163, 69);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleRight;
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(98, 233);
            label1.Name = "label1";
            label1.Size = new Size(116, 38);
            label1.TabIndex = 1;
            label1.Text = "ADMIN";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(50, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(213, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NumSucursal, NombreSucursal, FechaSucursal, TelefonoSucursal, CalleSucursal, NumCalleSucursal, LocalidadSucursal, ProvinciaSucursal });
            dataGridView1.Location = new Point(307, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1077, 543);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NumSucursal
            // 
            NumSucursal.HeaderText = "N°";
            NumSucursal.MinimumWidth = 8;
            NumSucursal.Name = "NumSucursal";
            NumSucursal.Width = 60;
            // 
            // NombreSucursal
            // 
            NombreSucursal.HeaderText = "Nombre";
            NombreSucursal.MinimumWidth = 8;
            NombreSucursal.Name = "NombreSucursal";
            NombreSucursal.Width = 170;
            // 
            // FechaSucursal
            // 
            FechaSucursal.HeaderText = "Fecha Apertura";
            FechaSucursal.MinimumWidth = 8;
            FechaSucursal.Name = "FechaSucursal";
            FechaSucursal.Width = 110;
            // 
            // TelefonoSucursal
            // 
            TelefonoSucursal.HeaderText = "Teléfono";
            TelefonoSucursal.MinimumWidth = 8;
            TelefonoSucursal.Name = "TelefonoSucursal";
            TelefonoSucursal.Width = 130;
            // 
            // CalleSucursal
            // 
            CalleSucursal.HeaderText = "Calle";
            CalleSucursal.MinimumWidth = 8;
            CalleSucursal.Name = "CalleSucursal";
            CalleSucursal.Width = 160;
            // 
            // NumCalleSucursal
            // 
            NumCalleSucursal.HeaderText = "N° Calle";
            NumCalleSucursal.MinimumWidth = 8;
            NumCalleSucursal.Name = "NumCalleSucursal";
            NumCalleSucursal.Width = 70;
            // 
            // LocalidadSucursal
            // 
            LocalidadSucursal.HeaderText = "Localidad";
            LocalidadSucursal.MinimumWidth = 8;
            LocalidadSucursal.Name = "LocalidadSucursal";
            LocalidadSucursal.Width = 140;
            // 
            // ProvinciaSucursal
            // 
            ProvinciaSucursal.HeaderText = "Provincia";
            ProvinciaSucursal.MinimumWidth = 8;
            ProvinciaSucursal.Name = "ProvinciaSucursal";
            ProvinciaSucursal.Width = 140;
            // 
            // CrudSucursales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1387, 682);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "CrudSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrudSucursales";
            Load += CrudSucursales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnCerrarSesion;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NumSucursal;
        private DataGridViewTextBoxColumn NombreSucursal;
        private DataGridViewTextBoxColumn FechaSucursal;
        private DataGridViewTextBoxColumn TelefonoSucursal;
        private DataGridViewTextBoxColumn CalleSucursal;
        private DataGridViewTextBoxColumn NumCalleSucursal;
        private DataGridViewTextBoxColumn LocalidadSucursal;
        private DataGridViewTextBoxColumn ProvinciaSucursal;
        private PictureBox pictureBox2;
    }
}