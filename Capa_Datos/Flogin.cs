using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Soporte.Cache;
namespace Capa_Datos
{
   public class Flogin:Conexion
    {

       
        SqlCommand cmd = new SqlCommand();

       public bool Login(string user, string pass)
       {
           using (var connection = GetConnection())
           {
               connection.Open();
               using (var command = new SqlCommand())
               {


                   command.Connection = connection;
                   command.CommandText = "SP_login";
                   command.Parameters.AddWithValue("@usuario", user);
                   command.Parameters.AddWithValue("@pass", pass);

                   command.CommandType = CommandType.StoredProcedure;
                   SqlDataReader reader = command.ExecuteReader();


                   if (reader.HasRows)
                   {
                       while (reader.Read())
                       {
                           cache_usuario.habilitado = reader.GetInt32(5);
                           cache_usuario.Id_usuario = reader.GetInt32(0);
                           cache_usuario.nombre = reader.GetString(1);
                           cache_usuario.usuario = reader.GetString(2);
                           cache_usuario.contraseña = reader.GetString(3);
                           cache_usuario.intentopass = reader.GetInt32(4);


                       }
                       return true;
                   }
                   else
                       return false;
               }
           }
          
          






               }









       public DataTable validar_permisos(string usu)
       {
         

           using(var conetion=GetConnection())
           {

               conetion.Open();
               using(var cmd=new SqlCommand())
               {
                   cmd.Connection = conetion;
                   cmd.CommandText = "validar_permisos";
                   cmd.CommandType = CommandType.StoredProcedure;

                   cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;

                   SqlDataReader dr;
                   dr = cmd.ExecuteReader();
                   DataTable dt = new DataTable();
                   dt.Load(dr);
                   return dt;


               }



           }




       }



       public DataTable validar_botones(string usu)
       {
          

           using (var conection=GetConnection())
           {
               conection.Open();
                using(var cmd=new SqlCommand())
                {
                    cmd.Connection = conection;
                    cmd.CommandText = "validar_botones";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu;

                    SqlDataReader dr;

                    dr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    return dt;




                }

           }



       }


       public void intento_pass(string usuario,string pass)
       {
           using (var conection=GetConnection())
           {

               conection.Open();

               using(var cmd=new SqlCommand())
                {

                    cmd.Connection = conection;
                    cmd.CommandText = "SP_intentos_pass";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.ExecuteNonQuery();



                    
                }


           }


       }






       public void ingreso_usuario(string usuario)
       {
           using (var conection = GetConnection())
           {

               conection.Open();

               using (var cmd = new SqlCommand())
               {

                   cmd.Connection = conection;
                   cmd.CommandText = "SP_ingreso_usuario";
                   cmd.CommandType = CommandType.StoredProcedure;

                   cmd.Parameters.AddWithValue("@usuario", usuario);
                   
                   cmd.ExecuteNonQuery();




               }


           }


       }














           }
       }

