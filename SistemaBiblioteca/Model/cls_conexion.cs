using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SistemaBiblioteca.Model
{
    class cls_conexion
    {
        public SqlConnection _conn;
        private DataSet ds = new DataSet();
        private SqlCommand _comando;
        private SqlDataReader _datos;
        public int i;
        private string cadena = @"data source=USUARIO-PC; initial catalog = bd_SistemaBiblioteca; integrated security = true";

        #region Singleton
        public static cls_conexion instance;
        public static cls_conexion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new cls_conexion();
                }
                return instance;
            }
        }
        #endregion
        public cls_conexion()
        {
            conexion();
        }
        public void conexion()
        {
            _conn = new SqlConnection(cadena);
            _conn.Open();
        }
        public DataTable met_consultar(string cadena)
        {
            if (_datos != null)
            {
                _datos.Close();
            }
            SqlDataAdapter ver = new SqlDataAdapter(cadena, _conn);
            DataTable tabla = new DataTable();
            ver.Fill(tabla);
            return tabla;
        }
        public bool met_acciones(string sql)
        {
            bool bandera = false;
            if (_datos != null)
            {
                _datos.Close();
            }
            _comando = new SqlCommand(sql, _conn);
            try
            {
                i = _comando.ExecuteNonQuery();
                if (i > 0)
                {
                    bandera = true;
                }
            }
            catch (Exception)
            {
            }
            return bandera;
        }
        public IDataReader met_busca(string sql)
        {
            if (_datos != null)
            {
                _datos.Close();
            }
            SqlCommand comando = new SqlCommand(sql, _conn);
            _datos = comando.ExecuteReader();
            return _datos;
        }
        public SqlDataReader met_consultDrig(string sql)
        {
            if (_datos != null)
            {
                _datos.Close();
            }
            _comando = new SqlCommand(sql, _conn);
            _datos = _comando.ExecuteReader();
            return _datos;
        }
    }
}
