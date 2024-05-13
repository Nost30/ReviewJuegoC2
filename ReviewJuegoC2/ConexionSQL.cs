using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewJuegoC2
{
    internal class ConexionSQL
    {
        private static SqlConnection cnx = new SqlConnection();

        private static void Connect()
        {
            try
            {
                cnx.ConnectionString = "Data Source=localhost; Initial Catalog=ReviewJuego;Integrated Security=True";
                cnx.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private static void Disconect()
        {
            try
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al desconectar de la base de datos: " + ex.Message);
            }
        }

        // Create a method to excecute a Selection query
        public static DataTable SelectQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
            return dt;
        }

        // Método para ejecutar un procedimiento almacenado
        public static void ExecuteStoredProcedure(string procedureName, SqlParameter[] parameters = null)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(procedureName, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al ejecutar el procedimiento almacenado: " + ex.Message);
            }
            finally
            {
                Disconect();
            }
        }
    }
}
