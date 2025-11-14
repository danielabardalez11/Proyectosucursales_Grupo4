namespace Proyectosucursales_Grupo4
{
    public partial class Formprincipal : Form
    {
        public string NumeroSucursal { get; set; }
        public string Nombre { get; set; }
        public string FechaApertura { get; set; }
        public string Telefono { get; set; }
        public string Calle { get; set; }
        public string NumeroDir { get; set; }
        public string Localidad { get; set; }
        public string Provincia { get; set; }

        public Formprincipal()
        {
            InitializeComponent();
        }

        public void CargarValoresEnControles()
        {
            txtnumsucursal.Text = NumeroSucursal ?? "";
            txtnombresucursal.Text = Nombre ?? "";
            if (DateTime.TryParse(FechaApertura, out DateTime dt))
                dtpFecha.Value = dt;
            else
                dtpFecha.Value = DateTime.Today;

            txtTelefono.Text = Telefono ?? "";
            txtCalle.Text = Calle ?? "";
            txtNumCalle.Text = NumeroDir ?? "";
            txtLocalidad.Text = Localidad ?? "";
            cmbProvincia.Text = Provincia ?? "";
        }


        private void Formprincipal_Load(object sender, EventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnbresucursal_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombresucursal.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío");
                return;
            }

            NumeroSucursal = txtnumsucursal.Text;
            Nombre = txtnombresucursal.Text;
            FechaApertura = dtpFecha.Value.ToShortDateString();
            Telefono = txtTelefono.Text;
            Calle = txtCalle.Text;
            NumeroDir = txtNumCalle.Text;
            Localidad = txtLocalidad.Text;
            Provincia = cmbProvincia.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
