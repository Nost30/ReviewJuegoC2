using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewJuegoC2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = TxtUsuario.Text;
            string password = TxtContra.Text;

            // Aquí deberías tener código para verificar las credenciales.
            // Esto podría involucrar la comparación con una base de datos, un archivo de texto, etc.
            // Aquí tienes un ejemplo muy básico:

            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Inicio de sesión exitoso");

                Form1 ReviewsJuegos = new Form1();
                ReviewsJuegos.Show();
                this.Hide(); // Cierra el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
        }
    }
}
