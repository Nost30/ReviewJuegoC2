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
    public partial class FormularioAgregar : Form
    {
        private string query;
        private bool auto;
        public FormularioAgregar()
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

        private void BtnAgregarJuego_Click(object sender, EventArgs e)
        {
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("@NombreJuego", TxtJuego.Text);
            parametros[1] = new SqlParameter("@IdGenero", ComboBoxGenero.SelectedValue);
            parametros[2] = new SqlParameter("@IdDesarrolladora", ComboBoxDesarrolladora.SelectedValue);
            parametros[3] = new SqlParameter("@IdPlataforma", ComboBoxPlataforma.SelectedValue);
            parametros[4] = new SqlParameter("@FechaLanzamiento", DTTFechaLanzamiento.Value);
            parametros[5] = new SqlParameter("@NumeroJugadores", TxtNumJugadores.Text);
            parametros[6] = new SqlParameter("@Metascore", TxtMetascore.Text);
            parametros[7] = new SqlParameter("@PuntajeUsuario", TxtPuntajeUsuario.Text);
            parametros[8] = new SqlParameter("@IdUsuarioCrea", 1);

            ConexionSQL.ExecuteStoredProcedure("SP_AgregarJuego", parametros);
            MessageBox.Show("Registro exitoso");
        }

        private string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";

        private int GetNextAvailableGameId()
        {
            int nextId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MAX(Id) + 1 FROM Juego";
                    SqlCommand command = new SqlCommand(query, connection);
                    nextId = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener la próxima ID disponible: " + ex.Message);
                }
            }

            return nextId;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int nextId = GetNextAvailableGameId();
            TxtId.Text = nextId.ToString();
            TxtId.ReadOnly = true;
        }

        private void FormularioAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
