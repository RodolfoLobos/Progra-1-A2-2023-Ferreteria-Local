using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{

    public partial class Form2 : Form
    {
        Form2 agregar = new Form2();
        private string Id;
        private string pproveedor;
        private string nNombre;
        private string Pprecio;
        private string SStok;
        private string ICategoria;
        public string eEstado;

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 formulario = new Form1();
            formulario.Visible = true;
            Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form3 formulario = new Form3();
            formulario.Visible = true;
            Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 formulario = new Form2();
            formulario.Visible = true;
            Visible = false;
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            agregar.Id = txtIdAgregar.Text;
            agregar.pproveedor = txtProveedorAgregar.Text;
            agregar.nNombre = txtNombreAgregar.Text;
            agregar.Pprecio = txtPrecioAgregar.Text;
            agregar.SStok = txtStokAgregar.Text;
            agregar.ICategoria = txtCategoriaAgregar.Text;
            agregar.eEstado = txtEstadoAgregar.Text;

            agregar.Show();
        }
    }
    }

