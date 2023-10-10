using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ferreteria
{
    internal class Conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miComando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet miDs = new DataSet();

        public Conexion()
        {
            String cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\db_ferreteria.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();

        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.CommandText = "select * from Productos";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "Productos");

            return miDs;
        }
    }
}
