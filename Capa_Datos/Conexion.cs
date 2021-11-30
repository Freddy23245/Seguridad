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

        //private SqlConnection cn = new SqlConnection("SERVER=BOCA_JUNIORS; database=Seguridad;integrated security=true");

        //public SqlConnection Abrir()
        //{
        //    if (cn.State == ConnectionState.Closed)

        //        cn.Open();
        //    return cn;


        //}

        //public SqlConnection Cerrar()
        //{
        //    if (cn.State == ConnectionState.Open)

        //        cn.Close();
        //    return cn;

        //}



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
