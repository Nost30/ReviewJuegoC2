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
    public partial class Form1 : Form
    {
        private string query;
        private bool auto;

        // Constructor
        public Form1()
        {
            auto = true;
            InitializeComponent();
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            query = "SELECT Id,NombreJuego FROM Juego";
            ComboBoxJuego.DataSource = ConexionSQL.SelectQuery(query);
            ComboBoxJuego.DisplayMember = "NombreJuego";
            ComboBoxJuego.ValueMember = "id";
            auto = false;
            DataGridView1.ReadOnly = true;

            query = "SELECT * FROM VW_JuegoReview";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);
        }


        

        private void ActualizarDataGridView()
        {
            query = "SELECT * FROM VW_JuegoReview";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);
        }

       
        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del formulario destino
            FormularioAgregar formularioAgregar = new FormularioAgregar();

            // Mostrar el formulario destino
            formularioAgregar.Show();
        }

        private void BtnActualizar_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia del formulario destino
            FormularioActualizar formularioActualizar = new FormularioActualizar();

            // Mostrar el formulario destino
            formularioActualizar.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=ReviewJuego;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SP_EliminarJuego", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdJuego", TxtId.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Juego eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el juego: " + ex.Message);
                }
            }
        }

        private void TxtId_TextChanged_1(object sender, EventArgs e)
        {
            int buscarId;
            if (int.TryParse(TxtId.Text.Trim(), out buscarId))
            {
                foreach (DataGridViewRow row in DataGridView1.Rows)
                {
                    if (Convert.ToInt32(row.Cells["IdJuego"].Value) == buscarId)
                    {
                        DataGridView1.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }
            else
            {
                DataGridView1.ClearSelection();
            }
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            string buscarTexto = TxtJuego.Text.Trim();
            string query = "SELECT * FROM VW_JuegoReview WHERE nombrejuego LIKE '%" + buscarTexto + "%'";
            DataTable dt = ConexionSQL.SelectQuery(query);
            DataGridView1.DataSource = dt;
        }

        private void ComboBoxJuego_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ComboBoxJuego.Text == null)
                return;

            query = "SELECT * FROM VW_JuegoReview where nombrejuego='" + ComboBoxJuego.Text + "'";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);
        }

        private void BtnRefrescar_Click_1(object sender, EventArgs e)
        {
            this.Refresh();

        }
    }
}