using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaBiblioteca.Controller
{
    class cls_clasificacion
    {
        View.Frm_clasificacion _form_clasif;
        Model.cls_dav_clasificacion _dav_clasif;
        private SqlDataReader _sqldataread;
        private int _cont = 0;
        private int _c = 0;
        private string _str_clasi = "";
        public cls_clasificacion(View.Frm_clasificacion _clasif) {
            _form_clasif = _clasif;
            _dav_clasif = new Model.cls_dav_clasificacion();
            _form_clasif.textBox1.Enabled = false;
            _met_click();
            _met_cargar_drig_view();
        }
        private void _met_click() {
            //_form_clasif.pictureBox1.Click += new EventHandler(_met_cerrar_form);
            _form_clasif.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_cell_click_datadrid_view);
            _form_clasif.btn_insert.Click += new EventHandler(_met_event_click_insert_clasi);
            _form_clasif.btn_update.Click += new EventHandler(_met_event_click_btn_updata);
            _form_clasif.btn_delete.Click += new EventHandler(_met_eventclick_btn_delete);
            _form_clasif.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypres_txt_clasifi);
        }
        private void _met_cerrar_form(object sender, EventArgs e) {
            _form_clasif.Close();
        }
        private void _met_cargar_drig_view() {
            _dav_clasif._met_cargar_drig_view();
            _sqldataread = _dav_clasif._SqlDataRead;
            _form_clasif.dataGridView1.Rows.Clear();
            while (_sqldataread.Read()) {
                _cont = _form_clasif.dataGridView1.Rows.Add();
                _form_clasif.dataGridView1.Rows[_cont].Cells["Column1"].Value = _sqldataread[0].ToString();
                _form_clasif.dataGridView1.Rows[_cont].Cells["Column2"].Value = _sqldataread.GetString(1);
            }
        }
        private void _met_cell_click_datadrid_view(object sender, EventArgs e) {
            if (Convert.ToString(_form_clasif.dataGridView1.CurrentRow.Cells[0].Value) != "") {
                _form_clasif.textBox1.Text = _form_clasif.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                _form_clasif.textBox2.Text = _form_clasif.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }
        private void _met_event_click_insert_clasi(object sender, EventArgs e) {
            _dav_clasif._met_insert_clasi(_form_clasif.textBox1.Text, _form_clasif.textBox2.Text);
            if (_dav_clasif._Action != false) {
                _form_clasif.textBox1.Text = "";
                _form_clasif.textBox2.Text ="";
                _met_cargar_drig_view();
                System.Windows.Forms.MessageBox.Show("El registro se ha guardado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        private void _met_event_click_btn_updata(object sender, EventArgs e) {
            _dav_clasif._met_update_clasifi(_form_clasif.textBox1.Text, _form_clasif.textBox2.Text);
            if (_dav_clasif._Action != false) {
                _form_clasif.textBox1.Text = "";
                _form_clasif.textBox2.Text = "";
                _met_cargar_drig_view();
            }
        }
        private void _met_eventclick_btn_delete(object sender, EventArgs e) {
            _dav_clasif._met_delete_clasificacion(_form_clasif.textBox1.Text);
            if (_dav_clasif._Action != false) {
                _form_clasif.textBox1.Text = "";
                _form_clasif.textBox2.Text = "";
                _met_cargar_drig_view();
            }
        }
        private void _met_keypres_txt_clasifi(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r'){
                _form_clasif.textBox1.Text = _form_clasif.textBox2.Text.Substring(0, 3).ToString();
            }
        }
    }
}

