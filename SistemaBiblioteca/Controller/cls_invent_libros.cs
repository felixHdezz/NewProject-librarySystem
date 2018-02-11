using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaBiblioteca.Controller
{
    class cls_invent_libros
    {
        private View.Frm_libros _frm_invent;
        private Model.cls_dav_invent _cls_dav_invent;
        private SqlDataReader _SqlDataRead;
        private int _int_cont = 0;
        public cls_invent_libros(View.Frm_libros _frm_inv) {
            _frm_invent = _frm_inv;
            _cls_dav_invent = new Model.cls_dav_invent();
            _met_event();
        }
        private void _met_event() {
            _met_load_datagrid();
            _frm_invent.textBox1.KeyPress += new KeyPressEventHandler(_met_event_keypress);
            _frm_invent.radioButton1.CheckedChanged += new EventHandler(_met_event_checkedRadioButton1);
            _frm_invent.radioButton2.CheckedChanged += new EventHandler(_met_event_checkedRadioButton2);
            _frm_invent.radioButton3.CheckedChanged += new EventHandler(_met_event_checkedRadioButton3);
            _frm_invent.radioButton4.CheckedChanged += new EventHandler(_met_event_checkedRadioButton4);
        }
        private void _met_load_datagrid() {
            _cls_dav_invent._met_load_datagrid();
            _SqlDataRead = _cls_dav_invent._SqlDataRead;
            _frm_invent.dataGridView1.Rows.Clear();
            while (_SqlDataRead.Read()) {
                _int_cont = _frm_invent.dataGridView1.Rows.Add();
                _frm_invent.dataGridView1.Rows[_int_cont].Cells[0].Value = _SqlDataRead[0].ToString();
                _frm_invent.dataGridView1.Rows[_int_cont].Cells[1].Value = _SqlDataRead[1].ToString();
                _frm_invent.dataGridView1.Rows[_int_cont].Cells[2].Value = _SqlDataRead[2].ToString();
                _frm_invent.dataGridView1.Rows[_int_cont].Cells[3].Value = _SqlDataRead[3].ToString();
                _frm_invent.dataGridView1.Rows[_int_cont].Cells[4].Value = _SqlDataRead[4].ToString();
                _frm_invent.dataGridView1.Rows[_int_cont].Cells[5].Value = _SqlDataRead[5].ToString();
                _int_cont++;
            }
            _frm_invent.lbl_total_libros.Text = "Total de libros: "+_int_cont;
        }
        public void _met_event_keypress(object sedner, KeyPressEventArgs e){
            
        }
        public void _met_event_checkedRadioButton1(object sender, EventArgs e) {
            
        }
        public void _met_event_checkedRadioButton2(object sender, EventArgs e){

        }
        public void _met_event_checkedRadioButton3(object sender, EventArgs e){

        }
        public void _met_event_checkedRadioButton4(object sender, EventArgs e){

        }
    }
}
