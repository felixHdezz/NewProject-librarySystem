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
using Microsoft.Office.Interop.Excel;

namespace SistemaBiblioteca.View
{
    public partial class Frm_libros : Form
    {
        public Frm_libros()
        {
            InitializeComponent();
        }
        int _int_columna = 0;
        int _int_fila = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Application.Workbooks.Add(true);
            foreach(DataGridViewColumn col in dataGridView1.Columns){
                _int_columna++;
                Excel.Cells[1, _int_columna] = col.HeaderText;
            }
            foreach (DataGridViewRow rows in dataGridView1.Rows){
                _int_fila++;
                _int_columna = 0;
                foreach (DataGridViewColumn col in dataGridView1.Columns) {
                    _int_columna++;
                    Excel.Cells[_int_fila + 1, _int_columna] = rows.Cells[col.Name].Value;
                }
            }
            Excel.WindowState = XlWindowState.xlMaximized;
            Excel.Visible = true;
        }
    }
}
