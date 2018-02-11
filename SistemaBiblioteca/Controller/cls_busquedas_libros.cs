using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Controller
{
    class cls_busquedas_libros
    {
        private Model.cls_var _cls_var = new Model.cls_var();
        private Model.cls_conexion _cls_con = Model.cls_conexion.Instance;
        private View.Frm_bus_libro_de _frm_bus_li;
        private View.Frm_libros_prestados _frm_li_pre;
        private View.Frm_prestamos _frm_pres;
        private SqlDataReader _sqldataread;
        private string _str_tipo_bus;
        private int _int_cont;
        public cls_busquedas_libros(View.Frm_bus_libro_de _frm_bus, View.Frm_prestamos _f_pre){
            _frm_bus_li = _frm_bus;
            _frm_pres = _f_pre;
            _met_event();
        }
        private void _met_event(){
            _met_load_datagridview();
            //_frm_bus_li.pictureBox1.Click += new EventHandler(_met_event_click_cose_from);
            _frm_bus_li.cmb_tipo_bus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_cmb_tipo);
            _frm_bus_li.txt_texto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_event_keypres_bus_li);
            _frm_bus_li.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_cell_datagridview);
        }
        private void _met_event_click_cose_from(object sender, EventArgs e){
            _frm_bus_li.Close();
        }
        private void _met_load_datagridview(){
            _sqldataread = _cls_con.met_consultDrig("exec _SP_busqueda_libros '1',''");
            _frm_bus_li.dataGridView1.Rows.Clear();
            while (_sqldataread.Read()){
                _int_cont = _frm_bus_li.dataGridView1.Rows.Add();
                _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[0].Value = _sqldataread[0].ToString().ToUpper();
                _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[1].Value = _sqldataread[1].ToString().ToUpper();
                _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[2].Value = _sqldataread[2].ToString().ToUpper();
                _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[3].Value = _sqldataread[3].ToString().ToUpper();
                if (_sqldataread.GetString(3) == "ACTIVO    " || _sqldataread.GetString(3) == "DISPONIBLE")
                {
                    _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[3].Style.BackColor = System.Drawing.Color.Lime;
                } else{
                    _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[3].Style.BackColor = System.Drawing.Color.Red;
                }
                _int_cont++;
            }
        }
        private void _met_define_tipo_bus(){
            if (_frm_bus_li.cmb_tipo_bus.Text == "Por clave"){
                _str_tipo_bus = "xcl";
            }
            if (_frm_bus_li.cmb_tipo_bus.Text == "Por nombre"){
                _str_tipo_bus = "xno";
            }
            if (_frm_bus_li.cmb_tipo_bus.Text == "Por clasificacion"){
                _str_tipo_bus = "xcla";
            }
        }
        private void _met_event_keypres_bus_li(object sender, System.Windows.Forms.KeyPressEventArgs e){
            if (_frm_bus_li.cmb_tipo_bus.Text != ""){
                _frm_bus_li.dataGridView1.Rows.Clear();
                _met_define_tipo_bus();
                _sqldataread = _cls_con.met_consultDrig("exec _procedure_tipo_bus_li '" + _str_tipo_bus + "','" + _frm_bus_li.txt_texto.Text + "'");
                while (_sqldataread.Read()){
                    _int_cont = _frm_bus_li.dataGridView1.Rows.Add();
                    _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[0].Value = _sqldataread[0].ToString().ToUpper();
                    _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[1].Value = _sqldataread[1].ToString().ToUpper();
                    _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[2].Value = _sqldataread[2].ToString().ToUpper();
                    _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[3].Value = _sqldataread[3].ToString().ToUpper();
                    if (_sqldataread.GetString(3) == "ACTIVO"){
                        _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[3].Style.BackColor = System.Drawing.Color.Lime;
                    }else{
                        _frm_bus_li.dataGridView1.Rows[_int_cont].Cells[3].Style.BackColor = System.Drawing.Color.Red;
                    }
                    _int_cont++;
                }
            }else{
                System.Windows.Forms.MessageBox.Show("Por favor seleccione el tipo de busqueda", "Mensaje desde el sistema", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }
        private void _met_event_keypres_cmb_tipo(object sender, System.Windows.Forms.KeyPressEventArgs e){
            e.Handled = true;
        }
        private void _met_event_click_cell_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e){
            if (Convert.ToString(_frm_bus_li.dataGridView1.CurrentRow.Cells[0].Value) != ""){
                if (_frm_bus_li.dataGridView1.CurrentRow.Cells[3].Value.ToString() != "PRESTADO  ")
                {
                    _frm_pres.txt_clv_li.Text = _frm_bus_li.dataGridView1.CurrentRow.Cells[0].Value.ToString().ToUpper();
                    _frm_pres.txt_nom_li.Text = _frm_bus_li.dataGridView1.CurrentRow.Cells[1].Value.ToString().ToUpper();
                    _frm_pres.txt_clas_li.Text = _frm_bus_li.dataGridView1.CurrentRow.Cells[2].Value.ToString().ToUpper();
                    _frm_bus_li.Hide();
                }else {
                    _cls_var._str_clv_li = _frm_bus_li.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    _frm_li_pre = new View.Frm_libros_prestados();
                    Controller.cls_libros_prestados _con = new cls_libros_prestados(_frm_li_pre);
                    _frm_li_pre.ShowDialog();
                }
            }
        }
    }
}

