using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SistemaBiblioteca.Controller
{
    class cls_prestamo
    {
        View.Frm_prestamos _form_pres;
        private Model.cls_var _cls_var = new Model.cls_var();
        private Model.cls_dav_prestamo _dav_pres;
        private Model.cls_vo_prestamo _vo_pres = new Model.cls_vo_prestamo();
        private View.Frm_libros_prestados _frm_li_pre;
        private View.Frm_bus_libro_de _frm_bus_list_li;
        private SqlDataReader _sql_data_read;
        private string[] _array_data = new string[4];
        private int _cont = 0;
        private string _str_estado, _str_nom, _str_clasi;
        private bool _enc_li = false;
        private static string _clv_auto;
        public cls_prestamo(View.Frm_prestamos _pre) {
            _form_pres = _pre;
            _dav_pres = new Model.cls_dav_prestamo(_vo_pres);
            _met_click();
            _form_pres.txt_nom_li.Enabled = false;
            _form_pres.txt_clas_li.Enabled = false;
            _form_pres.txt_nom_alum.Enabled = false;
            _form_pres.txt_grado.Enabled = false;
        }
        private void _met_click() {
            //_form_pres.pictureBox1.Click += new EventHandler(_met_click_cerrarvent);
            _form_pres.rdb_inter.Checked = true;
            _form_pres.txt_grupo.Enabled = false;
            _form_pres.txt_cant.Enabled = true;
            _met_clv_auto_inc();
            //_form_pres.btn_clv_libr.Click += new EventHandler(_met_click_bus_li);
            _form_pres.btn_bus_list_li.Click += new EventHandler(_met_event_click_bus_list_li);
            _form_pres.txt_clv_li.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_clv_li);
            _form_pres.txt_matri.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_matri_alum);
            _form_pres.rdb_inter.CheckedChanged += new EventHandler(_met_check_chang_rb_inter);
            _form_pres.rdb_inter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_rb_inter);
            _form_pres.rdb_exter.CheckedChanged += new EventHandler(_met_check_chang_rb_exter);
            _form_pres.rdb_exter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_rb_exter);
            _form_pres.txt_cant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_keypress_txt_cant);
            _form_pres.btn_add_book.Click += new EventHandler(_met_click_btn_add_book);
            _form_pres.btn_real_prest.Click += new EventHandler(_met_click_btn_real_prest);
        }
        private void _met_env_data() {
            _vo_pres.Clv_li = _form_pres.txt_clv_li.Text;
            _vo_pres.Matri_alum = _form_pres.txt_matri.Text;
            _vo_pres.Str_clv_pre = Convert.ToString(_clv_auto);
            _vo_pres.Str_tipo_pres = "Interno";
            _vo_pres.Str_fecha_pres = Convert.ToString(_form_pres.dateTimePicker1.Value.Year) + "-" + Convert.ToString(_form_pres.dateTimePicker1.Value.Month) +'-'+Convert.ToString(_form_pres.dateTimePicker1.Value.Day) ;
            //_vo_pres.Str_fecha_dev = _form_pres.dateTimePicker2.Value.Date.ToString();
            _vo_pres.Int_cant_libro = _form_pres.dataGridView1.RowCount -1;
        }
        private void _met_clv_auto_inc() {
            _dav_pres._met_bus_clv_increment();
            _sql_data_read = _dav_pres._SqlDataReader;
            while (_sql_data_read.Read())
            {
                _clv_auto = _sql_data_read[0].ToString();
            }
            if (_clv_auto == "")
            {
                _clv_auto = "1";
            }
        }
        private void _met_update_data() {
            _met_clv_auto_inc();
            _form_pres.txt_cant.Text = "";
            _form_pres.txt_clas_li.Text = "";
            _form_pres.txt_clv_li.Text = "";
            _form_pres.txt_grado.Text = "";
            _form_pres.txt_matri.Text = "";
            _form_pres.txt_nom_alum.Text = "";
            _form_pres.txt_nom_li.Text = "";
            _form_pres.dataGridView1.Rows.Clear();
        }
        private void _met_keypress_txt_clv_li(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (_form_pres.txt_clv_li.Text != "")
                {
                    _met_env_data();
                    _dav_pres._met_bus_libr();
                    _sql_data_read = _dav_pres._SqlDataReader;
                    while (_sql_data_read.Read())
                    {
                        _str_estado = _sql_data_read[3].ToString();
                        _str_nom = _sql_data_read.GetString(1);
                        _str_clasi = _sql_data_read.GetString(2);
                    }
                    if (_str_estado != "PRESTADO  ")
                    {
                        _form_pres.txt_nom_li.Text = _str_nom;
                        _form_pres.txt_clas_li.Text = _str_clasi;
                    }
                    else
                    {
                        _cls_var._str_clv_li = _form_pres.txt_clv_li.Text;
                        _frm_li_pre = new View.Frm_libros_prestados();
                        Controller.cls_libros_prestados _con = new cls_libros_prestados(_frm_li_pre);
                        _frm_li_pre.ShowDialog();
                    }
                    _form_pres.txt_matri.Focus();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Error al buscar el libro! Campo vacio....Por favor introduce una clave", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
                }
            }
        }
        private void _met_event_click_bus_list_li(object sender, EventArgs e) {
            _frm_bus_list_li = new View.Frm_bus_libro_de();
            Controller.cls_busquedas_libros _cls_con_li = new cls_busquedas_libros(_frm_bus_list_li,_form_pres);
            _frm_bus_list_li.Show();
        }
        private void _met_click_btn_add_book(object sender, EventArgs e) {
            _array_data[0] = _form_pres.txt_clv_li.Text;
            _array_data[1] = _form_pres.txt_nom_li.Text;
            _array_data[2] = _form_pres.txt_clas_li.Text;
            _array_data[3] = _form_pres.txt_cant.Text;
            for (int x = 0; x < _form_pres.dataGridView1.RowCount -1; x++) {
                for (int y = 0; y < 4; y++) {
                    if (_form_pres.txt_clv_li.Text == _form_pres.dataGridView1.Rows[x].Cells[y].Value.ToString()) {
                        _enc_li = true;
                    }
                }
            }
            if (_enc_li != true){
                _cont = _form_pres.dataGridView1.Rows.Add();
                int _int_cont = 0;
                while (_int_cont < 4){
                    _form_pres.dataGridView1.Rows[_cont].Cells[_int_cont].Value = _array_data[_int_cont];
                    _int_cont++;
                }
                _cont++;
            }else {
                System.Windows.Forms.MessageBox.Show("EL LIBRO YA FUE AGREGADO!... ESCOJE OTRO ","MENSAJE DESDE EL SISTEMA",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
        private void _met_click_btn_real_prest(object sender, EventArgs e) {
            _met_env_data();
            _dav_pres._met_insert_prestamo();
            if (_dav_pres._action != false) {
                for (int x = 0; x < _form_pres.dataGridView1.RowCount -1; x++) {
                    for (int y = 0; y < 4; y++) {
                        _vo_pres.Clv_li = _form_pres.dataGridView1.Rows[x].Cells[0].Value.ToString();
                        _vo_pres.Int_cant = Convert.ToInt32(_form_pres.dataGridView1.Rows[x].Cells[3].Value.ToString());
                    }
                    _dav_pres._met_insert_prestamo_deta();
                }
                _met_update_data();
                System.Windows.Forms.MessageBox.Show("Prestamo realizado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
        //private void _met_keypress_txt_clv_li(object sender, System.Windows.Forms.KeyPressEventArgs e) {
        //    if (e.KeyChar == '\r') {
        //        _form_pres.btn_clv_libr.Focus();
        //    }
        //}
        private void _met_keypress_txt_matri_alum(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r'){
                _met_env_data();
                _dav_pres._met_bus_matr_alum();
                _sql_data_read = _dav_pres._SqlDataReader;
                while (_sql_data_read.Read()){
                    _form_pres.txt_nom_alum.Text = _sql_data_read.GetString(1);
                    _form_pres.txt_grado.Text = _sql_data_read.GetString(2);
                    _form_pres.txt_grupo.Text = _sql_data_read.GetString(3);
                }
            }
        }
        private void _met_check_chang_rb_inter(object sender, EventArgs e) {
            _form_pres.dateTimePicker2.Enabled = false;
        }
        private void _met_keypress_rb_inter(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (e.KeyChar == '\r') {
                _form_pres.txt_cant.Focus();
            }
        }
        private void _met_check_chang_rb_exter(object sender, EventArgs e) {
            _form_pres.dateTimePicker2.Enabled = true;
        }
        private void _met_keypress_rb_exter(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (e.KeyChar == '\r'){
                _form_pres.dateTimePicker2.Focus();
            }
        }
        private void _met_keypress_txt_cant(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsNumber(e.KeyChar)){
                e.Handled = false;
            }else {
                e.Handled = true;
            }
           if (e.KeyChar == '\r' ) {
               _form_pres.btn_add_book.Focus();
           }
        }
    }
}
