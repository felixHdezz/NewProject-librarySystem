using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Controller
{
    class cls_principal
    {
        View.Frm_principal _principal;
        public cls_principal(View.Frm_principal _prin) {
            _principal = _prin;
            _principal.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            _met_click();
        }
        private void _met_click() {
            _principal.salirToolStripMenuItem.Click += new EventHandler(_met_click_cerrar);
            _principal.registroDeGruposToolStripMenuItem.Click += new EventHandler(_met_carg_form_grup);
            _principal.registroDeGradosToolStripMenuItem.Click += new EventHandler(_met_event_carg_frm_grado);
            _principal.registroAlumnosToolStripMenuItem.Click += new EventHandler(_met_carg_form_alumn);
            _principal.registroDeClasificacionesToolStripMenuItem.Click += new EventHandler(_met_cargar_form_clasif);
            _principal.registroDeLibrosToolStripMenuItem.Click += new EventHandler(_met_cargar_form_libros);
            _principal.catalogoDeLibrosToolStripMenuItem.Click += new EventHandler(_met_carga_from_invent_libros);
            _principal.prestamosToolStripMenuItem.Click += new EventHandler(_met_cargar_from_prestamos);
            _principal.devolucionesToolStripMenuItem.Click += new EventHandler(_met_load_frm_devolucion);
        }
        private void _met_click_cerrar(object sender, EventArgs e) {
            System.Windows.Forms.Application.Exit();
        }
        private void _met_carg_form_grup(object sender, EventArgs e) {
            View.Frm_grupos _form_grup = new View.Frm_grupos();
            Controller.cls_grupo _contro_grup = new cls_grupo(_form_grup);
            _form_grup.MdiParent = _principal;
            _form_grup.Show();
        }
        private void _met_event_carg_frm_grado(object sender, EventArgs e) {
            View.Frm_grados _frm_gra = new View.Frm_grados();
            Controller.cls_grado _cls_on = new cls_grado(_frm_gra);
            _frm_gra.MdiParent = _principal;
            _frm_gra.Show();
        }
        private void _met_carg_form_alumn(object sender, EventArgs e) {
            View.Frm_alumnos _form_alumn = new View.Frm_alumnos();
            Controller.cls_alumno _cont_alumn = new cls_alumno(_form_alumn);
            _form_alumn.MdiParent = _principal;
            _form_alumn.Show();
        }
        public void _met_carga_from_invent_libros(object sender, EventArgs e) {
            View.Frm_libros _form_libro = new View.Frm_libros();
            Controller.cls_invent_libros _cls_invet_li = new cls_invent_libros(_form_libro);
            _form_libro.MdiParent = _principal;
            _form_libro.Show();
        }
        public void _met_cargar_form_libros(object sender, EventArgs e) {
            View.Frm_reg_libros _libro = new View.Frm_reg_libros();
            Controller.cls_reg_libro _cont = new cls_reg_libro(_libro);
            _libro.MdiParent = _principal;
            _libro.Show();
        }
        public void _met_cargar_form_clasif(object sender, EventArgs e)
        { 
            View.Frm_clasificacion _clasi = new View.Frm_clasificacion();
            Controller.cls_clasificacion _con = new cls_clasificacion(_clasi);
            _clasi.MdiParent = _principal;
            _clasi.Show();
        }
        public void _met_cargar_from_prestamos(object sender, EventArgs e) {
            View.Frm_prestamos _pres = new View.Frm_prestamos();
            Controller.cls_prestamo _con = new cls_prestamo(_pres);
            _pres.MdiParent = _principal;
            _pres.Show();
            View.Frm_bus_libro_de _frm_bus_li = new View.Frm_bus_libro_de();
            Controller.cls_busquedas_libros _cls_con_bu_li = new cls_busquedas_libros(_frm_bus_li,_pres);
            _frm_bus_li.Show();
        }
        private void _met_load_frm_devolucion(object sender, EventArgs e) {
            View.Frm_devolucion _frm_devoluc = new View.Frm_devolucion();
            Controller.cls_devolucion _cls_con_de = new cls_devolucion(_frm_devoluc);
            _frm_devoluc.MdiParent = _principal;
            _frm_devoluc.Show();
        }
    }
}
