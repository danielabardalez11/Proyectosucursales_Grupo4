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
    public partial class Registroform : Form
    {
        public Registroform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnVerRepetir_Click(object sender, EventArgs e)
        {
            // Alterna la visibilidad del campo "Repetir contraseña"
            txtRepetirContrasena.UseSystemPasswordChar = !txtRepetirContrasena.UseSystemPasswordChar;

        }

        // Agrega este método en la clase Registroform para manejar el evento Click del botón btnVercontrasena
        private void button3_Click(object sender, EventArgs e)
        {
            // Alterna la visibilidad de la contraseña
            txtContrasena.UseSystemPasswordChar = !txtContrasena.UseSystemPasswordChar;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Verifica que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtContrasena.Text) || string.IsNullOrWhiteSpace(txtRepetirContrasena.Text))
            {
                MessageBox.Show("Por favor, completá ambos campos de contraseña.",
                                "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica que las contraseñas coincidan
            if (txtContrasena.Text != txtRepetirContrasena.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // (Opcional) Verifica que la contraseña tenga cierta longitud mínima
            if (txtContrasena.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.",
                                "Contraseña débil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Si todo está bien
            MessageBox.Show("Usuario registrado correctamente",
                            "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolverlogin_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de login
            FormLogin formLogin = new FormLogin();

            // Mostrar el login
            formLogin.Show();

            // Cerrar el formulario actual
            this.Close();
        }

        private void Registroform_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

