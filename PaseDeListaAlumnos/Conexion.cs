using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace PaseDeListaAlumnos
{
    internal class Conexion
    {
        MySqlConnection conexion;

        public MySqlConnection conectar()
        {
            try
            {
                string cadenaConexion = "server=localhost; database=pase_de_lista; user=root; password=1234;";
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
                return null;
            }
        }

        public void desconectar()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }

        public bool ejecutarComando(string consulta)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL (comando): " + ex.Message + "\n\nConsulta: " + consulta);
                return false;
            }
        }

        // Se modifico la funcion para poder usar comandos parametrizados y evitar inyeccion sql
        public bool ejecutarComando(MySqlCommand comando)
        {
            try
            {
                conectar();
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL (parametrizado): " + ex.Message);
                return false;
            }
        }

        public DataSet ejecutar(string cadena)
        {
            DataSet ds = new DataSet();
            try
            {
                conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(cadena, conexion);
                da.Fill(ds);
                desconectar();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL (consulta): " + ex.Message + "\n\nConsulta: " + cadena);
                return null;
            }
        }
    }
}