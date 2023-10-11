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

        public Form1()
        {
            InitializeComponent();
        }
        private void form1_load(object sender, EventArgs e)
        {
            miDs.Clear();
            miDs = objConexion.obtenerDatos();
            mostrarProductos();
        }

        private void mostrarProductos()
        {
            productosDataGridView.DataSource = miDs.Tables["Productos"].DefaultView;
        } 

        private void mostrarDatosProductos()
        {
            txtId.Text = miDs.Tables["Productos"].Rows[posicion].ItemArray[1].ToString();
            txtProveedor.Text = miDs.Tables["Productos"].Rows[posicion].ItemArray[2].ToString();
            txtNombre.Text = miDs.Tables["Productos"].Rows[posicion].ItemArray[3].ToString();
            txtPrecio.Text = miDs.Tables["Productos"].Rows[posicion].ItemArray[4].ToString();
            txtStok.Text = miDs.Tables["Productos"].Rows[posicion].ItemArray[5].ToString();
            txtCategoria.Text = miDs.Tables["Productos"].Rows[posicion].ItemArray[6].ToString();
            txtEstado.Text = miDs.Tables["Productos"].Rows[posicion].ItemArray[7].ToString();

            lblRegistroProducto.Text = (posicion + 1) + " de " + (miDs.Tables["Productos"].Rows.Count - 1);
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
    }
    }

