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
            colNumero = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colFechaApertura = new DataGridViewTextBoxColumn();
            colTelefono = new DataGridViewTextBoxColumn();
            colCalle = new DataGridViewTextBoxColumn();
            colNumeroDir = new DataGridViewTextBoxColumn();
            colLocalidad = new DataGridViewTextBoxColumn();
            colProvincia = new DataGridViewTextBoxColumn();
            cmbFiltrar = new ComboBox();
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colNumero, colNombre, colFechaApertura, colTelefono, colCalle, colNumeroDir, colLocalidad, colProvincia });
            dataGridView1.Location = new Point(307, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1053, 610);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "N°";
            colNumero.MinimumWidth = 8;
            colNumero.Name = "colNumero";
            colNumero.Width = 60;
            // 
            // colNombre
            // 
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.Width = 170;
            // 
            // colFechaApertura
            // 
            colFechaApertura.HeaderText = "Fecha Apertura";
            colFechaApertura.MinimumWidth = 8;
            colFechaApertura.Name = "colFechaApertura";
            colFechaApertura.Width = 110;
            // 
            // colTelefono
            // 
            colTelefono.HeaderText = "Teléfono";
            colTelefono.MinimumWidth = 8;
            colTelefono.Name = "colTelefono";
            colTelefono.Width = 130;
            // 
            // colCalle
            // 
            colCalle.HeaderText = "Calle";
            colCalle.MinimumWidth = 8;
            colCalle.Name = "colCalle";
            colCalle.Width = 160;
            // 
            // colNumeroDir
            // 
            colNumeroDir.HeaderText = "N° Calle";
            colNumeroDir.MinimumWidth = 8;
            colNumeroDir.Name = "colNumeroDir";
            colNumeroDir.Width = 70;
            // 
            // colLocalidad
            // 
            colLocalidad.HeaderText = "Localidad";
            colLocalidad.MinimumWidth = 8;
            colLocalidad.Name = "colLocalidad";
            colLocalidad.Width = 140;
            // 
            // colProvincia
            // 
            colProvincia.HeaderText = "Provincia";
            colProvincia.MinimumWidth = 8;
            colProvincia.Name = "colProvincia";
            colProvincia.Width = 140;
            // 
            // cmbFiltrar
            // 
            cmbFiltrar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFiltrar.FormattingEnabled = true;
            cmbFiltrar.Items.AddRange(new object[] { "Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Todas", "Tucumán" });
            cmbFiltrar.Location = new Point(1049, 12);
            cmbFiltrar.Name = "cmbFiltrar";
            cmbFiltrar.Size = new Size(297, 38);
            cmbFiltrar.TabIndex = 2;
            cmbFiltrar.Text = "Filtrar por Provincia";
            cmbFiltrar.SelectedIndexChanged += cmbFiltrar_SelectedIndexChanged;
            // 
            // CrudSucursales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 682);
            Controls.Add(cmbFiltrar);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrudSucursales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Gestion de Sucursales";
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
        private PictureBox pictureBox2;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colFechaApertura;
        private DataGridViewTextBoxColumn colTelefono;
        private DataGridViewTextBoxColumn colCalle;
        private DataGridViewTextBoxColumn colNumeroDir;
        private DataGridViewTextBoxColumn colLocalidad;
        private DataGridViewTextBoxColumn colProvincia;
        private ComboBox cmbFiltrar;
    }
}