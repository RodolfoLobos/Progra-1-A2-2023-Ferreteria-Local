using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

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

        public String mtoProductos(String[]productos)
        {
            String sql = "";
                if (productos[0] == "n n uevo"); {
                sql = "INSERT INTO productos (IdProducto, Proveedor, Nombre, Precio_Producto, Stok_Producto, Id_Categoría, Estado_Producto) VALUES('" + productos[1] + "','" + productos[2]
                    + "', '" + productos[3] + "', '" + productos[4] + "', '" + productos[5] + "', '" + productos[6] + "', '" + productos[7] + "') ";
            }else if(productos[0] == "modificar"){
                sql = "UPDATE productos SET IdProducto='" + productos[1] + "', productos='" +  productos[2] + "' IdProducto='" + productos[3] + "' WHERE IdProducto='"+ productos[4]+ "')";
            }else if (productos[0] == "eliminar")
            {
                sql = "DELETE FROM productos WHERE IdProducto='" + productos[7] + "')";
            }
            return ejecutarSql (sql);
            }
        private String ejecutarSql(String sql)
        {
            try {
                miComando.Connection = miConexion;
                miComando.CommandText = sql;
                return miComando.ExecuteNonQuery().ToString();

            } catch (Exception e)
            {
                return e.Message;

            } 
        }
        }
    }

