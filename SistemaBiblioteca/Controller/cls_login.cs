using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Controller
{
    class cls_login
    {
        private View.Frm_login _frm_login;
        private Model.cls_dav_login _dav_login;
        private Model.cls_var _cls_var = new Model.cls_var();
        private Model.cls_vo_login _vo_login = new Model.cls_vo_login();
        private View.Frm_principal _principal = new View.Frm_principal();
        private bool _acc = false;
        private int _cont = 0;
        public cls_login(View.Frm_login _login) {
            _frm_login = _login;
            _dav_login = new Model.cls_dav_login(_vo_login);
            met_click();
        }
        private void met_click(){
            _frm_login.btn_acceder.Click += new EventHandler(met_click_acceser);
            _frm_login.timer1.Tick += new EventHandler(_met_progresbar);
            _frm_login.btn_cancelar.Click += new EventHandler(met_click_cancelar);
            _frm_login.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_validacion_textbox);
            _frm_login.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(_met_validacion_textbox);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void met_click_acceser(object sender, EventArgs e) {
            _vo_login.User = _frm_login.txt_user.Text;
            _vo_login.Password = _frm_login.txt_pass.Text;
            _dav_login._met_acceso();
            if (_dav_login.acc != false){
                _frm_login.lb_msm.Text = "  Cargando sistema ...";
                _frm_login.lb_msm.ForeColor = System.Drawing.Color.White;
                _frm_login.progressBar1.Visible = true;
                _frm_login.timer1.Interval = 40;
                _frm_login.timer1.Enabled = true;
                _acc = true;
            }else {
                _frm_login.lb_msm.Text = "--- Acceso denegado ---";
                _frm_login.lb_msm.ForeColor = System.Drawing.Color.Red;
            }
        }
        private void met_click_cancelar(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }
        private void _met_progresbar(object sender, EventArgs e) {
            if (_cont < 100){
                _frm_login.progressBar1.Value = _cont;
                _cont++;
            }else {
                if (_acc != false){
                    Controller.cls_principal con = new cls_principal(_principal);
                    if (_cls_var.Str_tipo_user == "Administrador                 ")
                    {
                    }else {
                        if (_cls_var.Str_tipo_user == "Usuario                       ")
                        {
                            _principal.alumnosToolStripMenuItem.Enabled = false;
                            _principal.librosToolStripMenuItem.Enabled = false;
                        }
                    }
                    _frm_login.timer1.Enabled = false;
                    _frm_login.Hide();
                    _principal.Show();
                }
            }
        }
        private void _met_validacion_textbox(object sender, System.Windows.Forms.KeyPressEventArgs e) {
            if (char.IsNumber(e.KeyChar) || char.IsLetter(e.KeyChar) || char.IsSeparator(e.KeyChar) || e.KeyChar == (char)System.Windows.Forms.Keys.Back){
                e.Handled = false;
            }else{
                e.Handled = true;
            }
        }
    }
}
