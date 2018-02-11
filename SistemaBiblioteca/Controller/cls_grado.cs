using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBiblioteca.Controller
{
    class cls_grado
    {
        private View.Frm_grados _frm_grados;
        private Model.cls_dav_grados _cls_dav_grad;
        private SqlDataReader _sqldataread;
        private int _int_cont;
        public cls_grado(View.Frm_grados _f_grad) {
            _frm_grados = _f_grad;
            _cls_dav_grad = new Model.cls_dav_grados();
            _met_event();
        }
        private void _met_event() {
            _met_load_datagridview();
            //_frm_grados.pictureBox1.Click += new EventHandler(_met_event_click_close_from);
            _frm_grados.btn_regis_libr.Click += new EventHandler(_met_event_btn_insert);
            _frm_grados.btn_update.Click += new EventHandler(_met_event_btn_update);
            _frm_grados.btn_delete.Click += new EventHandler(_met_event_btn_delete);
        }
        private void _met_event_click_close_from(object sender, EventArgs e) {
            _frm_grados.Close();
        }
        private void _met_load_datagridview() {
            _cls_dav_grad._met_load_datagrid();
            _sqldataread = _cls_dav_grad._SqlDataRead;
            _frm_grados.dataGridView1.Rows.Clear();
            while (_sqldataread.Read()) {
                _int_cont = _frm_grados.dataGridView1.Rows.Add();
                _frm_grados.dataGridView1.Rows[_int_cont].Cells[0].Value = _sqldataread[0].ToString();
                _frm_grados.dataGridView1.Rows[_int_cont].Cells[1].Value = _sqldataread[1].ToString();
                _int_cont++;
            }
        }
        public void _met_event_btn_insert(object sender, EventArgs e) {
            if ((bool)_cls_dav_grad._met_insert_data(_frm_grados.textBox1.Text, _frm_grados.textBox2.Text)) {
                _met_load_datagridview();
                _frm_grados.textBox2.Clear();
            }
        }
        public void _met_event_btn_update(object sender, EventArgs e) {
            if ((bool)_cls_dav_grad._met_update_data(_frm_grados.textBox1.Text, _frm_grados.textBox2.Text)) {
                _met_load_datagridview();
                _frm_grados.textBox2.Clear();
            }
        }
        public void _met_event_btn_delete(object sedner, EventArgs e) {
            if ((bool)_cls_dav_grad._met_delete_data(_frm_grados.textBox1.Text)) {
                _met_load_datagridview();
                _frm_grados.textBox2.Clear();
            }
        }
    }
}
