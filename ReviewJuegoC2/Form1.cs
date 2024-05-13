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

        private void ComboBoxJuego_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxJuego.Text == null)
                return;

            query = "SELECT * FROM VW_JuegoReview where nombrejuego='" + ComboBoxJuego.Text + "'";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string buscarTexto = TxtJuego.Text.Trim();
            string query = "SELECT * FROM VW_JuegoReview WHERE nombrejuego LIKE '%" + buscarTexto + "%'";
            DataTable dt = ConexionSQL.SelectQuery(query);
            DataGridView1.DataSource = dt;
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
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

        private void btnEliminarJuego_Click(object sender, EventArgs e)
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

        private void ActualizarDataGridView()
        {
            query = "SELECT * FROM VW_JuegoReview";
            DataGridView1.DataSource = ConexionSQL.SelectQuery(query);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}