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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
                Form2 formulario = new Form2();
                formulario.Visible = true;
                Visible = false;
            
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
    }
}
