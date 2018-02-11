using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Controller
{
    class cls_alumno
    {
        private View.Frm_alumnos _form_alumn;
        private Model.cls_dav_alumno _cls_dav_alumn;
        private Model.cls_vo_alumnos _cls_vo_alumn = new Model.cls_vo_alumnos();
        private SqlDataReader _sqldataread;
        private int _cont = 0;
        private string[] _str_array;
        public cls_alumno(View.Frm_alumnos _alumn) {
            _form_alumn = _alumn;
            _cls_dav_alumn = new Model.cls_dav_alumno(_cls_vo_alumn);
            _met_clicks();
            _met_load_data();
        }
        private void _met_clicks() {
            //_form_alumn.pictureBox1.Click += new EventHandler(_met_click_close_form);
            _form_alumn.btn_insert.Click += new EventHandler(_met_event_btn_insert);
            _form_alumn.btn_update.Click += new EventHandler(_met_event_click_btn_update);
            _form_alumn.btn_delete.Click += new EventHandler(_met_event_click_btn_delete);
            _form_alumn.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(_met_event_click_datagridview);
        }
        private void _met_click_close_form(object sender, EventArgs e) {
            _form_alumn.Close();
        }
        private void _met_load_data() {
            _met_update_datadrigview();
            _met_load_combo_box();
        }
        private void _met_load_combo_box() {
            _cls_dav_alumn._met_load_combo_box1();
            _form_alumn.cmb_grado.DataSource = _cls_dav_alumn._DataTable;
            _form_alumn.cmb_grado.DisplayMember = "Grados";
            _form_alumn.cmb_grado.ValueMember = "int_Id_grados";

            _cls_dav_alumn._met_load_combo_box2();
            _form_alumn.cmb_grupo.DataSource = _cls_dav_alumn._DataTable;
            _form_alumn.cmb_grupo.DisplayMember = "vch_grupo";
            _form_alumn.cmb_grupo.ValueMember = "int_Id_grupo";
        }
        private void _met_update_datadrigview() {
            _cls_dav_alumn._met_update_drig_view();
            _sqldataread = _cls_dav_alumn._SqlDataRead;
            _form_alumn.dataGridView1.Rows.Clear();
            while(_sqldataread.Read()){
                _cont = _form_alumn.dataGridView1.Rows.Add();
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column1"].Value = _cont + 1;
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column2"].Value = _sqldataread.GetString(0);
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column3"].Value = _sqldataread.GetString(1);
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column4"].Value = _sqldataread.GetString(2);
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column5"].Value = _sqldataread.GetString(3);
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column6"].Value = _sqldataread.GetString(4);
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column7"].Value = _sqldataread.GetString(5);
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column8"].Value = _sqldataread.GetString(6);
                _form_alumn.dataGridView1.Rows[_cont].Cells["Column9"].Value = _sqldataread.GetString(7);
                if (_sqldataread.GetString(7) == "ACTIVO") {
                    _form_alumn.dataGridView1.Rows[_cont].Cells["Column9"].Style.BackColor = System.Drawing.Color.Lime;
                }else{
                    _form_alumn.dataGridView1.Rows[_cont].Cells["Column9"].Style.BackColor =  System.Drawing.Color.Red;
                }
                _cont++;
            }
        }
        private void _met_clear_textbox() {
            _form_alumn.txt_matricula.Text = "";
            _form_alumn.txt_nombre.Text = "";
            _form_alumn.txt_ap.Text = "";
            _form_alumn.txt_am.Text = "";
            _form_alumn.txt_sexo.Text = "";
            _form_alumn.txt_tutor.Text = "";
        }
        private void _met_send_data() {
            _cls_vo_alumn.Str_matricula = _form_alumn.txt_matricula.Text;
            _cls_vo_alumn.Str_nombre = _form_alumn.txt_nombre.Text;
            _cls_vo_alumn.Str_ap = _form_alumn.txt_ap.Text;
            _cls_vo_alumn.Str_am = _form_alumn.txt_am.Text;
            if (_form_alumn.txt_sexo.Text == "masculino" || _form_alumn.txt_sexo.Text == "Masculino" || _form_alumn.txt_sexo.Text == "MASCULINO")
            {
                _cls_vo_alumn.Str_sexo = "h";
            }
            if (_form_alumn.txt_sexo.Text == "femenino" || _form_alumn.txt_sexo.Text == "Femenino" || _form_alumn.txt_sexo.Text == "FEMENINO")
            {
                _cls_vo_alumn.Str_sexo = "m";
            }
            _cls_vo_alumn.Str_fecha_naci = _form_alumn.dtp_fecha_naci.Text;
            _cls_vo_alumn.Str_id_grad = _form_alumn.cmb_grado.SelectedValue.ToString();
            _cls_vo_alumn.Str_id_grup = _form_alumn.cmb_grupo.SelectedValue.ToString();
            _cls_vo_alumn.Str_ciclo_escolar = _form_alumn.dtp_ciclo1.Text + "-" + _form_alumn.dtp_ciclo2.Text;
            _cls_vo_alumn.Str_tutor = _form_alumn.txt_tutor.Text;
            if (_form_alumn.cmb_estado.SelectedIndex == 0) {
                _cls_vo_alumn.Str_estado = "act";
            }else{
                _cls_vo_alumn.Str_estado ="inac";
            }
        }
        private void _met_event_btn_insert(object sender, EventArgs e) {
            _met_send_data();
            _cls_dav_alumn._met_insert_alumno();
            if ((bool)_cls_dav_alumn._Action) {
                _met_clear_textbox();
                _met_update_datadrigview();
            }
            _met_clear_textbox();
            _met_update_datadrigview();
        }
        private void _met_event_click_btn_update(object sender, EventArgs e) {
            _met_send_data();
            _cls_dav_alumn._met_update_alumno();
            if (_cls_dav_alumn._Action != false) {
                _met_clear_textbox();
                _met_update_datadrigview(); ;
            }
        }
        private void _met_event_click_btn_delete(object sender, EventArgs e) {
            _met_send_data();
            _cls_dav_alumn._met_delete_alumno();
            if (_cls_dav_alumn._Action != false){
                _met_clear_textbox();
                _met_update_datadrigview();
            }
        }
        private void _met_event_click_datagridview(object sender, System.Windows.Forms.DataGridViewCellEventArgs e) {
            if (Convert.ToInt32(_form_alumn.dataGridView1.CurrentRow.Cells[0].Value) > 0) {
                _cls_dav_alumn._met_busca_alumno(_form_alumn.dataGridView1.CurrentRow.Cells[1].Value.ToString());
                _sqldataread = _cls_dav_alumn._SqlDataRead;
                while (_sqldataread.Read()) {
                    _form_alumn.txt_matricula.Text = _sqldataread[0].ToString();
                    _form_alumn.txt_nombre.Text = _sqldataread[1].ToString();
                    _form_alumn.txt_ap.Text = _sqldataread[2].ToString();
                    _form_alumn.txt_am.Text = _sqldataread[3].ToString();
                    _form_alumn.txt_sexo.Text = _sqldataread[4].ToString();
                    _form_alumn.dtp_fecha_naci.Text = _sqldataread[5].ToString();
                    _form_alumn.cmb_grado.Text = _sqldataread[6].ToString();
                    _form_alumn.cmb_grupo.Text = _sqldataread[7].ToString();
                    _form_alumn.dtp_ciclo1.Text = _sqldataread[8].ToString();
                    //_form_alumn.dtp_ciclo2.Value = _sqldataread[8].ToString().Substring(6, 4);
                    _form_alumn.txt_tutor.Text = _sqldataread[9].ToString();
                    _form_alumn.cmb_estado.Text = _sqldataread[10].ToString();
                }
            }
        }
    }
}

