using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Controller
{
    class cls_reg_libro
    {
        View.Frm_reg_libros _form_libros;
        Model.cls_dav_libro _dav_libro;
        Model.cls_vo_libro _vo_libr = new Model.cls_vo_libro();
        private DataTable _DataTable;
        private SqlDataReader _sql_data_read;
        private string[] _array = new string[6];
        private int _cont = 0;
        private static string _clv_automatic;
        public cls_reg_libro(View.Frm_reg_libros _libros) {
            _form_libros = _libros;
            _dav_libro = new Model.cls_dav_libro(_vo_libr);
            _met_load_data();
            _met_click();
        }
        private void _met_click() {
            //_form_libros.pictureBox1.Click += new EventHandler(_met_click_cerrar);
            _form_libros.btn_new.Click += new EventHandler(_met_click_btn_new);
            _form_libros.btn_regis_libr.Click += new EventHandler(_met_click_btn_registar_libr);
            _form_libros.btn_cancelar.Click += new EventHandler(_met_event_btn_cancelar);
            _form_libros.cmb_clasi.SelectionChangeCommitted += new EventHandler(_met_click_cmb_clasi);
            _form_libros.txt_clav.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_clv);
            _form_libros.txt_nom_li.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_nom);
            _form_libros.txt_exis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_exis);
            _form_libros.cmb_estado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_cmb_esta);
            _form_libros.txt_editorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_editorial);
            _form_libros.txt_autor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_autor);
        }
        private void _met_load_data() {
            _met_carga_combo_box();
            _met_carg_clav_auto();
            //_met_load_datgridview();
            _met_enable_textbox("inic");
        }
        private void _met_carga_combo_box() {
            _dav_libro._met_carga_combo_box();
            _DataTable = _dav_libro._DataTable;
            _form_libros.cmb_clasi.DataSource = _DataTable;
            _form_libros.cmb_clasi.DisplayMember = "vch_clasificacion";
            _form_libros.cmb_clasi.ValueMember = "nch_idclasf";
        }
        private void _met_carg_clav_auto() {
            _dav_libro._met_carg_clv_automatic();
            _sql_data_read = _dav_libro._SqlDataReader;
            while(_sql_data_read.Read()){
                _clv_automatic = _sql_data_read[0].ToString();
            }
            if (_clv_automatic == "") {
                _clv_automatic = "1";
            }
        }
        private void _met_carg_data() {
            _vo_libr.Id =  Convert.ToInt32(_clv_automatic);
            _vo_libr.Clasi_li = Convert.ToString(_form_libros.cmb_clasi.SelectedValue);
            _vo_libr.Clv_li = _form_libros.txt_clav.Text;
            _vo_libr.Est_li = _form_libros.cmb_estado.Text;
            _vo_libr.Exis = int.Parse(_form_libros.txt_exis.Text);
            _vo_libr.Nom_li = _form_libros.txt_nom_li.Text;
            _vo_libr.Str_editorial = _form_libros.txt_editorial.Text;
            _vo_libr.Str_autors = _form_libros.txt_autor.Text;
        }
        private void _met_clean_textbox() {
            _form_libros.txt_clav.Text = "";
            _form_libros.txt_exis.Text = "";
            _form_libros.txt_nom_li.Text = "";
            _form_libros.txt_autor.Clear();
            _form_libros.txt_editorial.Clear();
        }
        private void _met_click_btn_new(object sender, EventArgs e){
            _met_enable_textbox("new");
        }
        private void _met_click_btn_registar_libr(object sender, EventArgs e) {
            _met_carg_data();
            if (_dav_libro._met_insert_li() == true){
                for (int x = 0; x < _form_libros.dataGridView1.RowCount - 1; x++){
                    _vo_libr.Clv_li = _form_libros.dataGridView1.Rows[x].Cells[0].Value.ToString();
                    _vo_libr.Est_li = _form_libros.dataGridView1.Rows[x].Cells[5].Value.ToString();
                    _dav_libro._met_insert_li_det();
                }
                System.Windows.Forms.MessageBox.Show("Registro guardado exitosamente", "Mensaje desd el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                //_met_load_data();
                _form_libros.dataGridView1.Rows.Clear();
                _met_carg_clav_auto();
                _met_enable_textbox("new");
                _met_clean_textbox();
            }else {
                System.Windows.Forms.MessageBox.Show("Error al registar los datos","Mensaje desd el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
        public void _met_load_datgridview() {
            _dav_libro._met_load_gridview();
            _sql_data_read = _dav_libro._SqlDataReader;
            _form_libros.dataGridView1.Rows.Clear();
            while (_sql_data_read.Read()) {
                _cont = _form_libros.dataGridView1.Rows.Add();
                _form_libros.dataGridView1.Rows[_cont].Cells[0].Value = _cont + 1;
                _form_libros.dataGridView1.Rows[_cont].Cells[1].Value = _sql_data_read.GetString(0);
                _form_libros.dataGridView1.Rows[_cont].Cells[2].Value = _sql_data_read.GetString(1);
                _form_libros.dataGridView1.Rows[_cont].Cells[3].Value = _sql_data_read.GetString(2);
                _form_libros.dataGridView1.Rows[_cont].Cells[4].Value = _sql_data_read.GetString(3);
                if (_sql_data_read.GetString(3) == "ACTIVO") {
                    _form_libros.dataGridView1.Rows[_cont].Cells[4].Style.BackColor = System.Drawing.Color.Lime;
                }else{
                    _form_libros.dataGridView1.Rows[_cont].Cells[4].Style.BackColor = System.Drawing.Color.Red;
                }
                _cont++;
            }
        }
        private void _met_enable_textbox(string op) { 
            switch(op){
                case "add":
                    _form_libros.txt_exis.Enabled = false;
                    _form_libros.txt_nom_li.Enabled = false;
                    _form_libros.cmb_estado.Enabled = false;
                    _form_libros.btn_regis_libr.Enabled = true;
                    _form_libros.btn_cancelar.Enabled = true;
                    break;
                case "new":
                    _form_libros.cmb_estado.Enabled = true;
                    _form_libros.txt_exis.Enabled = true;
                    _form_libros.txt_nom_li.Enabled = true;
                    _form_libros.cmb_estado.Enabled = true;
                    _form_libros.btn_regis_libr.Enabled = false;
                    _form_libros.btn_new.Enabled = false;
                    _form_libros.btn_cancelar.Enabled = true;
                    _form_libros.cmb_clasi.Enabled = true;
                    _form_libros.dataGridView1.Rows.Clear();
                    _cont = 0;
                    break;
                case "inic":
                    _form_libros.cmb_clasi.Enabled = false;
                    _form_libros.txt_exis.Enabled = false;
                    _form_libros.txt_nom_li.Enabled = false;
                    _form_libros.cmb_estado.Enabled = false;
                    _form_libros.btn_regis_libr.Enabled = false;
                    _form_libros.btn_new.Enabled = true;
                    _form_libros.btn_cancelar.Enabled = false;
                    break;
            }
        }
        private void _met_event_btn_cancelar(object sender, EventArgs e) {
            _met_enable_textbox("inic");
            _met_clean_textbox();
            _form_libros.dataGridView1.Rows.Clear();
        }
        private void _met_click_cerrar(object sender, EventArgs e) {
            _form_libros.Close();
        }
        private void _met_click_cmb_clasi(object sender, EventArgs e) {
            _form_libros.cmb_clasi.Enabled = false;
        }
        private void _met_keypress_txt_nom(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (e.KeyChar == '\r'){
                _form_libros.txt_editorial.Focus();
            }
        }
        private void _met_keypress_txt_editorial(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                _form_libros.txt_autor.Focus();
            }
        }
        private void _met_keypress_txt_autor(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (e.KeyChar == '\r') {
                _form_libros.txt_exis.Focus();
            }
        }
        private void _met_keypress_txt_exis(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (e.KeyChar == '\r'){
                _form_libros.cmb_estado.Focus();
            }
            if (char.IsNumber(e.KeyChar)) {
                e.Handled = false;
            }else {
                e.Handled = true;
            }
        }
        private void _met_keypress_cmb_esta(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (e.KeyChar == '\r'){
                _form_libros.txt_clav.Focus();
            }
        }
        private void _met_keypress_txt_clv(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (e.KeyChar == '\r'){
                if (_form_libros.txt_clav.Text != null && _form_libros.txt_nom_li.Text != null && _form_libros.txt_exis.Text != null){
                    _array[0] = _form_libros.txt_clav.Text;
                    _array[1] = _form_libros.txt_nom_li.Text;
                    _array[2] = _form_libros.txt_editorial.Text;
                    _array[3] = _form_libros.txt_autor.Text;
                    _array[4] = _form_libros.cmb_clasi.Text;
                    _array[5] = _form_libros.cmb_estado.Text;
                    _cont = _form_libros.dataGridView1.Rows.Add();
                    for (int x = 0; x < 6; x++)
                    {
                        _form_libros.dataGridView1.Rows[_cont].Cells[x].Value = _array[x];
                    }
                    _cont++;
                    _met_enable_textbox("add");
                    _form_libros.txt_clav.Clear();
                    _form_libros.txt_clav.Focus();
                    _form_libros.txt_clav.SelectAll();
                }
            }
        }
    }
}
