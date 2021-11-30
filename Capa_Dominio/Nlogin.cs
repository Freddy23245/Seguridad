using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_Datos;
namespace Capa_Dominio
{
    public class Nlogin
    {
        Flogin log = new Flogin();

        public bool LoginUser(string user, string pass)
        {
            return log.Login(user, pass);
        }

        public DataTable npermisos(string usu)
        {
            return log.validar_permisos(usu);
        }

        public DataTable nbotones(string usu)
        {
            return log.validar_botones(usu);
        }

        public void intento_pass(string usuario,string pass)
        {
            log.intento_pass(usuario,pass);
        }
    }
}
