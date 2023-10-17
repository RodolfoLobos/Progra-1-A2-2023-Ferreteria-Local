using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Ferreteria
{
    public partial class Form1 : Form
    {
        Conexion objConexion = new Conexion();
        DataSet miDs = new DataSet();
        public int posicion = 0;
        String accion = "nuevo";

        private String Id, proveedor, nombre, precio, stok, Categoria, estado;

        public String pId
        {
            set
            {
                Id = value;
            }
        }

        public String pproveedor
        {
            set
            {
                proveedor = value;
            }
        }

        public String nNombre
        {
            set
            {
                nombre = value;
            }
        }

        public String Pprecio
        {
            set
            {
                precio = value;
            }
        }

        public String SStok
        {
            set
            {
                stok = value;
            }
        }

        public String ICategoria
        {
            set
            {
                Categoria = value;
            }
        }

        public String eEstado
        {
            set
            {
                estado = value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void form1_load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs ()
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            mostrarProductos();
        }

        private void mostrarProductos()
        {
            grdDatosProductos.DataSource = miDs.Tables["Productos"].DefaultView;
        } 

        private void mostrarDatosProductos()
        {
      
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void grdDatosProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnPrimeroProducto_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosProductos();
        }

        private void btnSiguienteProducto_Click(object sender, EventArgs e)
        {
            if (posicion < miDs.Tables["Productos"].Rows.Count)
            {
                posicion++;
                mostrarDatosProductos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro", "Registro de Producots");
            }
            
        }

        private void btnUltimoProducto_Click(object sender, EventArgs e)
        {
            posicion = miDs.Tables["Productos"].Rows.Count -1 ;
            mostrarDatosProductos();
        }

        private void btnAnteriorProducto_Click(object sender, EventArgs e)
        {
        if (posicion > 0)
        {
            posicion--;
            mostrarDatosProductos();
        }
        else
        {

        }
            }

        private void Form1_Load_1(object sender, EventArgs e)
        {
         
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.Visible = true;
            Visible = false;
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3();
            formulario.Visible = true;
            Visible = false;
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Visible = true;
            Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (btnNuevoProducto.Text == "Nuevo")
            {
                btnNuevoProducto.Text = "Guardar";
                btnModificarProducto.Text = "Cancelar";
                estadoControles(false);
                limpiarCajas();
                accion = "Nuevo";
            }
            else
            {
                String[] Productos = new string[]{
        accion, txtId.Text, txtProveedor.Text, txtNombre.Text, txtPrecio.Text, txtStok.Text, txtCategoria.Text, txtEstado.Text,
        miDs.Tables["Productos"].Rows[posicion].ItemArray[0].ToString()
    };
                String msg = objConexion.mtoProductos(Productos);
                actualizarDs();
                MessageBox.Show(msg);
                estadoControles(true);
                btnNuevoProducto.Text = "Nuevo";
                btnModificarProducto.Text = "Modificar";
            }
            }
            private void estadoControles(Boolean estado)
        {
            txtId.ReadOnly = estado;
            txtProveedor.ReadOnly = estado;
            txtNombre.ReadOnly = estado;
            txtPrecio.ReadOnly  = estado;
            txtStok.ReadOnly = estado;
            txtCategoria.ReadOnly = estado;
            txtEstado.ReadOnly = estado;

            grdDatosProductos.Enabled = estado;
            btnEliminarProducto.Enabled = estado;
            TxtBuscarProducto.ReadOnly = !estado;
        }
        private void limpiarCajas()
        {
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtProveedor.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStok.Text = "";
            txtCategoria.Text = "";
            txtEstado.Text = "";
        }

        private void grdDatosProductos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
    
    

