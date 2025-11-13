using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectosucursales_Grupo4
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void Btncancelar_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            txtcontraseña.Clear();
        }

        private void Btningresar_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text == "27-46211405-8" && txtcontraseña.Text == "12345") ||
                (maskedTextBox1.Text == "27-47804068-2" && txtcontraseña.Text == "dani") ||
                (maskedTextBox1.Text == "00-00000000-0" && txtcontraseña.Text == "0000"))
            {
                CrudSucursales formLogin = new CrudSucursales();
                this.Hide();
                formLogin.Show();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos, Vuelva a Intentarlo");
                maskedTextBox1.Clear();
                txtcontraseña.Clear();
            }


        }

        private void lblbienvenido_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registroform registro = new();
            registro.Show();
            this.Hide();
        }

        private void lblcontraseña_Click(object sender, EventArgs e)
        {

        }

        private void btnVerContraLogin_Click(object sender, EventArgs e)
        {
            // Alterna la visibilidad de la contraseña
            txtcontraseña.UseSystemPasswordChar = !txtcontraseña.UseSystemPasswordChar;
        }
    }
}

