using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.View
{
    public partial class Frm_prestamos : Form
    {
        public Frm_prestamos()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Enabled = false;
        }

        private void Frm_prestamos_Load(object sender, EventArgs e)
        {

        }

        private void btn_bus_list_li_Click(object sender, EventArgs e)
        {

        }
    }
}
