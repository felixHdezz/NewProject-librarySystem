using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Controller
{
    class cls_grupo
    {
        View.Frm_grupos _form_grupos;
        Model.cls_dav_grupo _cls_dav_grup;
        private SqlDataReader _sqldataread;
        private int _cont = 0;
        private string _clv_auto;
        public cls_grupo(View.Frm_grupos _grupos) {
            _form_grupos = _grupos;
            _cls_dav_grup = new Model.cls_dav_grupo();
            _met_update_datagridview();
            _met_clv_auto_inc();
            _met_click();
        }
        private void _met_click() {
            //_form_grupos.pictureBox1.Click += new EventHandler(_met_click_close_form);
            _form_grupos.btn_regis_libr.Click += new EventHandler(_met_event_btn_insert);
        }
        private void _met_clv_auto_inc(){
            _cls_dav_grup._met_autoincrement();
            _sqldataread = _cls_dav_grup._SqlDataRead;
            while (_sqldataread.Read()){
                _clv_auto = _sqldataread[0].ToString();
            }
            if (_clv_auto == ""){
                _clv_auto = "1";
            }
            _form_grupos.textBox1.Text = _clv_auto;
        }
        private void _met_update_datagridview() {
            _cls_dav_grup._met_update_DataGridView();
            _sqldataread = _cls_dav_grup._SqlDataRead;
            _form_grupos.dataGridView1.Rows.Clear();
            while (_sqldataread.Read()){
                _cont = _form_grupos.dataGridView1.Rows.Add();
                _form_grupos.dataGridView1.Rows[_cont].Cells["Column1"].Value = _sqldataread.GetInt32(0);
                _form_grupos.dataGridView1.Rows[_cont].Cells["Column2"].Value = _sqldataread.GetString(1);
                _cont++;
            }
        }
        private void _met_event_btn_insert(object sender, EventArgs e) {
            _cls_dav_grup._met_insert_data(_form_grupos.textBox1.Text, _form_grupos.textBox2.Text);
            if ((bool)_cls_dav_grup._Action) {
                _form_grupos.textBox2.Clear();
                _met_clv_auto_inc();
                _met_update_datagridview();
            }
        }
        private void _met_event_btn_update(object sender, EventArgs e)
        {
            _cls_dav_grup._met_update_data(_form_grupos.textBox1.Text, _form_grupos.textBox2.Text);
            if ((bool)_cls_dav_grup._Action)
            {
                _form_grupos.textBox2.Clear();
                _met_clv_auto_inc();
                _met_update_datagridview();
            }
        }
        private void _met_event_btn_delete(object sender, EventArgs e)
        {
            _cls_dav_grup._met_delete_data(_form_grupos.textBox1.Text);
            if ((bool)_cls_dav_grup._Action)
            {
                _form_grupos.textBox2.Clear();
                _met_clv_auto_inc();
                _met_update_datagridview();
            }
        }
    }
}
