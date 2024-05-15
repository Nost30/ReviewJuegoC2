using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReviewJuegoC2
{
    public partial class FormularioActualizar : Form
    {
        private string query;
        private bool auto;
        public FormularioActualizar()
        {
            auto = true;
            InitializeComponent();
            query = "SELECT Id,Genero FROM Genero";
            ComboBoxGenero.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxGenero.DisplayMember = "Genero";
            ComboBoxGenero.ValueMember = "id";
            auto = false;
            query = "SELECT Id,Desarrolladora FROM Desarrolladora";
            ComboBoxDesarrolladora.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxDesarrolladora.DisplayMember = "Desarrolladora";
            ComboBoxDesarrolladora.ValueMember = "id";
            auto = false;
            query = "SELECT Id,NombrePlataforma FROM Plataforma";
            ComboBoxPlataforma.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxPlataforma.DisplayMember = "NombrePlataforma";
            ComboBoxPlataforma.ValueMember = "id";
            auto = false;
        }

        private void FormularioActualizar_Load(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SP_ActualizarJuego", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    // Parámetros del procedimiento almacenado
                    command.Parameters.AddWithValue("@IdJuego", txtIdJuego.Text);
                    command.Parameters.AddWithValue("@NombreJuego", txtNombreJuego.Text);
                    command.Parameters.AddWithValue("@IdGenero", ComboBoxGenero.SelectedValue);
                    command.Parameters.AddWithValue("@IdDesarrolladora", ComboBoxDesarrolladora.SelectedValue);
                    command.Parameters.AddWithValue("@IdPlataforma", ComboBoxPlataforma.SelectedValue);
                    command.Parameters.AddWithValue("@FechaLanzamiento", DTTFechaLanzamiento.Value);
                    command.Parameters.AddWithValue("@NumeroJugadores", TxtNumJugadores.Text);
                    command.Parameters.AddWithValue("@Metascore", txtMetascore.Text);
                    command.Parameters.AddWithValue("@PuntajeUsuario", txtPuntajeUsuario.Text);
                    command.Parameters.AddWithValue("@IdUsuarioModifica", 1);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Juego actualizado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar el juego: " + ex.Message);
                }
            }

            }
        }
    }
