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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            botones();
        }
        Nlogin LogB = new Nlogin();
        private void botones()
        {



            DataTable tabla;
            tabla = LogB.nbotones(cache_usuario.usuario);


            btn_alta.Enabled = false;
            btn_baja.Enabled = false;
            btn_modifica.Enabled = false;






            for (int i = 0; i < tabla.Rows.Count; i++)
            {



                if (tabla.Rows[i]["nombre"].ToString().Equals("Productos"))
                {

                    if (tabla.Rows[i]["alta"].ToString().Equals("True"))
                    {
                        btn_alta.Enabled = true;
                    }
                    if (tabla.Rows[i]["baja"].ToString().Equals("True"))
                    {
                        btn_baja.Enabled = true;
                    }
                    if (tabla.Rows[i]["modifica"].ToString().Equals("True"))
                    {
                        btn_modifica.Enabled = true;
                    }


                }


            }


        }
    }
}
