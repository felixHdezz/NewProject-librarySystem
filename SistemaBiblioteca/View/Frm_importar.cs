using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace SistemaBiblioteca.View
{
    public partial class Frm_importar : Form
    {
        public Frm_importar()
        {
            InitializeComponent();
        }
        OleDbConnection _con;
        OleDbDataAdapter _dataadapter;
        DataTable _td;
        static string _rutaarchivo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openfile = new OpenFileDialog();
            _openfile.Filter = "Excel File | *.xlsx";
            _openfile.Title = "Selecciona el archivo de Excel";
            if (_openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                if (_openfile.FileName.Equals("") == false) {
                    _rutaarchivo = _openfile.FileName;
                }
            }
        }

        private void Frm_importar_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.15.0; data source="+_rutaarchivo+"; Extended Properties ='Excel 15.0 xml;HDR=Yes'");
            _dataadapter = new OleDbDataAdapter("Select * from [" + textBox1.Text + "$]", _con);
            _td = new System.Data.DataTable();
            _dataadapter.Fill(_td);
            dataGridView1.DataSource = _td;
        }
    }
}
