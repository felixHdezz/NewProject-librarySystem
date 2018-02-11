using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaBiblioteca.Controller
{
    class cls_devolucion
    {
        View.Frm_devolucion _frm_devolucion;
        private Model.cls_vo_devolucion _cls_vo_devolucion = new Model.cls_vo_devolucion();
        private Model.cls_dav_devolucion _cls_dav_devol;
        private SqlDataReader _slq_data_read;
        private static string _clv_auto;
        string _clv, _str_Idprest;
        int int_cant;
        public cls_devolucion(View.Frm_devolucion _f_devolucion) {
            _frm_devolucion = _f_devolucion;
            _cls_dav_devol = new Model.cls_dav_devolucion(_cls_vo_devolucion);
            _met_event();
        }
        private void _met_event() {
            _met_clv_auto_inc();
            //_frm_devolucion.pictureBox1.Click += new EventHandler(_met_event_click_ptb);
            _frm_devolucion.btn_clv_matri.Click += new EventHandler(_met_event_click_btn_buscar);
            _frm_devolucion.btn_real_devol.Click += new EventHandler(_met_event_click_btn_realizar_devol);
        }
        private void _met_clv_auto_inc(){
            _cls_dav_devol._met_bus_clv_increment();
            _slq_data_read = _cls_dav_devol._SqlDataRead;
            while (_slq_data_read.Read()){
                _clv_auto = _slq_data_read[0].ToString();
            }
            if (_clv_auto == ""){
                _clv_auto = "1";
            }
        }
        private void _met_event_click_ptb(object sender, EventArgs e) {
            _frm_devolucion.Close();
        }
        private void _met_clean_textbox() {
            _frm_devolucion.txt_cant_pre.Text = "";
            _frm_devolucion.txt_fe_pres.Text = "";
            _frm_devolucion.txt_grado.Text = "";
            _frm_devolucion.txt_grupo.Text = "";
            _frm_devolucion.txt_matri.Text = "";
            _frm_devolucion.txt_nom_alum.Text = "";
            _frm_devolucion.txt_tip_pre.Text = "";
        }
        private void _met_event_click_btn_buscar(object sender, EventArgs e) {
            int _int_co = 0;
             _cls_vo_devolucion.Str_mat = _frm_devolucion.txt_matri.Text;
             _cls_dav_devol._met_bus_matri_alum();
             _slq_data_read = _cls_dav_devol._SqlDataRead;
             while(_slq_data_read.Read()){
                 _int_co = _frm_devolucion.dgv_devol.Rows.Add();
                 _str_Idprest = _slq_data_read[0].ToString();
                 _frm_devolucion.txt_nom_alum.Text = _slq_data_read[9].ToString().ToUpper();
                 _frm_devolucion.txt_grado.Text = _slq_data_read[10].ToString().ToUpper();
                 _frm_devolucion.txt_grupo.Text = _slq_data_read[11].ToString().ToUpper();
                 _frm_devolucion.txt_fe_pres.Text = _slq_data_read[1].ToString().ToUpper();
                 _frm_devolucion.txt_tip_pre.Text = _slq_data_read[2].ToString().ToUpper();
                 _frm_devolucion.txt_cant_pre.Text = _slq_data_read[3].ToString().ToUpper();
                 for (int x = 0; x < 3; x++ ) {
                     _frm_devolucion.dgv_devol.Rows[_int_co].Cells[0].Value = _slq_data_read[4].ToString().ToUpper();
                     _frm_devolucion.dgv_devol.Rows[_int_co].Cells[1].Value = _slq_data_read[5].ToString().ToUpper();
                     _frm_devolucion.dgv_devol.Rows[_int_co].Cells[2].Value = _slq_data_read[6].ToString().ToUpper();
                     _frm_devolucion.dgv_devol.Rows[_int_co].Cells[3].Value = _slq_data_read[7].ToString().ToUpper();
                 }
                 _int_co++;
             }
        }
        private void _met_event_click_btn_realizar_devol(object sender, EventArgs e) {
            string _f_devol = Convert.ToString(System.DateTime.Now).Substring(0,10);
            _cls_dav_devol._met_insert_devol(_clv_auto.ToString(), _str_Idprest, _f_devol, Convert.ToInt32(_frm_devolucion.txt_cant_pre.Text), _frm_devolucion.txt_matri.Text);
            if (_cls_dav_devol._action != false) {
                for (int x = 0; x < _frm_devolucion.dgv_devol.RowCount - 1; x++){
                    for (int y = 0; y < 4; y++){
                        _clv = _frm_devolucion.dgv_devol.Rows[x].Cells[0].Value.ToString();
                        int_cant = Convert.ToInt32(_frm_devolucion.dgv_devol.Rows[x].Cells[3].Value.ToString());
                    }
                    _cls_dav_devol._met_insert_devol_detalle(_clv_auto, _clv, int_cant);
                }
                _met_clean_textbox();
                _frm_devolucion.dgv_devol.Rows.Clear();
                System.Windows.Forms.MessageBox.Show("La devolucion se ha realizado con exito","Mensaje desde el sistema",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
