using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca.Model
{
    class cls_vo_login
    {
        public cls_vo_login _instance;
        public cls_vo_login _Instance {
            get {
                if (_instance == null) {
                    _instance = new cls_vo_login();
                }
                return _instance;
            }
        }
        string user, password;

        public string User
        {
            get { return user; }
            set { user = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
