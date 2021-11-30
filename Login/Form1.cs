using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Dominio;
using Soporte.Cache;
namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Nlogin log2 = new Nlogin();

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            var login_1 = log2.LoginUser(txt_usuario.Text, txt_contraseña.Text);


            //-------------

       
                if (login_1 == true)
                {
                    /*
                        Aca primero se ejecutaria el procedimiento almacenado SP_ingreso_usuario
                     */




                    if (cache_usuario.habilitado==0)
                    {
                        MessageBox.Show("Usuario Bloqueado");
                    }else
                    {
                        log2.ingreso_usuario(cache_usuario.usuario);
                         MessageBox.Show("Bienvenido" + cache_usuario.nombre);
                                            Inicio ini = new Inicio();
                                            ini.Show();
                    }


                   

                    lbl_estado.Text = Convert.ToString(cache_usuario.habilitado);

                }
                else
                {
                    MessageBox.Show("Usuario O Contraseña Incorrectos");

                    /*
                        Aca mismo se Ejecutaria el procedimiento almacenado SP_intento_pass
                 
                 
                     */


                   log2.intento_pass(txt_usuario.Text,txt_contraseña.Text);


                }

            
            //-------------

             


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
