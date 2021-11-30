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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            permisos();
        }
        Nlogin logD = new Nlogin();

        private void permisos()
        {


       
            DataTable tabla;
            tabla = logD.npermisos(cache_usuario.usuario);
           

            btn_clientes.Enabled = false;
            btn_productos.Enabled = false;
            btn_ventas.Enabled = false;



     


            for (int i = 0; i < tabla.Rows.Count ; i++)
            {
                

                if (tabla.Rows[i]["Permisos"].ToString().Equals("Productos"))
                {
                    btn_productos.Enabled = true;
                }
                if (tabla.Rows[i]["Permisos"].ToString().Equals("Ventas"))
                {
                    btn_ventas.Enabled = true;
                }
                if (tabla.Rows[i]["Permisos"].ToString().Equals("Clientes"))
                {
                    btn_clientes.Enabled = true;
                }


            }









        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            Clientes cli = new Clientes();
            cli.Show();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Ventas vent = new Ventas();
            vent.Show();
        }


    }
}
