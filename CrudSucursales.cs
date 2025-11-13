using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectosucursales_Grupo4
{
    public partial class CrudSucursales : Form
    {
        public CrudSucursales()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CrudSucursales_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("001", "Sucursal Centro", "01/03/2023", "11-5555-5555", "Av. Corrientes", "1200", "San Nicolas", "Buenos Aires");
            dataGridView1.Rows.Add("002", "Sucursal Norte", "10/05/2024", "11-4444-4444", "Av. Cabildo", "3500", "Belgrano", "Buenos Aires");
            dataGridView1.Rows.Add("003", "Sucursal Sur", "15/07/2022", "11-3333-3333", "Av. Pavón", "500", "Avellaneda", "Buenos Aires");
            dataGridView1.Rows.Add("004", "Sucursal Rosario", "12/03/2023", "341-456-7890", "Bv. Oroño", "2145", "Rosario", "Santa Fe");
            dataGridView1.Rows.Add("005", "Sucursal Córdoba Capital", "25/04/2023", "351-487-3322", "Av. Colón", "1020", "Córdoba", "Córdoba");
            dataGridView1.Rows.Add("006", "Sucursal Godoy Cruz", "18/05/2023", "261-424-7788", "San Martín Sur", "1530", "Godoy Cruz", "Mendoza");
            dataGridView1.Rows.Add("007", "Sucursal Tafí Viejo", "03/06/2023", "381-432-9900", "Av. Alem", "890", "Tafí Viejo", "Tucumán");
            dataGridView1.Rows.Add("008", "Sucursal Orán", "21/06/2023", "3878-421-556", "Av. Palacios", "770", "San Ramón de la Nueva Orán", "Salta");
            dataGridView1.Rows.Add("009", "Sucursal Cipolletti", "09/07/2023", "299-478-6655", "Av. Mengelle", "1455", "Cipolletti", "Río Negro");
            dataGridView1.Rows.Add("010", "Sucursal Posadas Centro", "15/08/2023", "376-444-9988", "Av. Uruguay", "2150", "Posadas", "Misiones");
            dataGridView1.Rows.Add("011", "Sucursal Corrientes Sur", "03/09/2023", "379-443-1122", "Av. Maipú", "1860", "Corrientes", "Corrientes");
            dataGridView1.Rows.Add("012", "Sucursal Rawson", "27/09/2023", "264-423-7711", "Av. España", "720", "Rawson", "San Juan");
            dataGridView1.Rows.Add("013", "Sucursal Resistencia Oeste", "14/10/2023", "362-446-2255", "Av. Sarmiento", "950", "Resistencia", "Chaco");
            dataGridView1.Rows.Add("014", "Sucursal San Rafael", "28/10/2023", "260-443-5566", "Av. Hipólito Yrigoyen", "1150", "San Rafael", "Mendoza");
            dataGridView1.Rows.Add("015", "Sucursal Villa Mercedes", "11/11/2023", "2657-421-334", "Av. Mitre", "640", "Villa Mercedes", "San Luis");
            dataGridView1.Rows.Add("016", "Sucursal Trelew", "22/11/2023", "280-442-9988", "Av. Fontana", "330", "Trelew", "Chubut");
            dataGridView1.Rows.Add("017", "Sucursal Paraná", "05/12/2023", "343-423-5577", "Av. Ramírez", "1210", "Paraná", "Entre Ríos");
            dataGridView1.Rows.Add("018", "Sucursal Ushuaia Sur", "19/12/2023", "2901-433-889", "Av. San Martín", "460", "Ushuaia", "Tierra del Fuego");
            dataGridView1.Rows.Add("019", "Sucursal Bahía Blanca", "10/01/2024", "291-455-6677", "Av. Alem", "1350", "Bahía Blanca", "Buenos Aires");
            dataGridView1.Rows.Add("020", "Sucursal Mar del Plata", "25/01/2024", "223-472-8899", "Av. Colón", "2100", "Mar del Plata", "Buenos Aires");
            dataGridView1.Rows.Add("021", "Sucursal Recoleta", "08/02/2024", "11-4372-5566", "Av. Santa Fe", "1820", "Recoleta", "CABA");
            dataGridView1.Rows.Add("022", "Sucursal Lanús", "20/02/2024", "11-4246-7788", "Av. Hipólito Yrigoyen", "4600", "Lanús", "Buenos Aires");
            dataGridView1.Rows.Add("023", "Sucursal Caseros", "05/03/2024", "11-4750-9922", "Av. San Martín", "2850", "Caseros", "Buenos Aires");
            dataGridView1.Rows.Add("024", "Sucursal Boedo", "15/03/2024", "11-4931-4411", "Av. Boedo", "750", "Boedo", "CABA");
            dataGridView1.Rows.Add("025", "Sucursal Vicente López", "28/03/2024", "11-4796-5533", "Av. Maipú", "3500", "Vicente López", "Buenos Aires");
            dataGridView1.Rows.Add("026", "Sucursal Tigre", "10/04/2024", "11-4731-2299", "Av. Cazón", "950", "Tigre", "Buenos Aires");






        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
