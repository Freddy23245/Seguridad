using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Capa_Datos
{
    public abstract class Conexion
    {

       


        private readonly string con;
        public Conexion()
        {
            con = "Server=BOCA_JUNIORS;DataBase= Seguridad; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(con);
        }








    }
}
