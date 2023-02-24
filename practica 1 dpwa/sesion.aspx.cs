using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica_1_dpwa
{
    public partial class sesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string usuario = TextBox1.Text;
            string password = TextBox2.Text;

            
            if (usuario == "hector" && password == "12345")
            {
                Label4.Visible = true;        
                Label4.Text = "Iniciando sesion...";
                limpiarcampos();
            }
            else
            {
                Label4.Visible = true;
                Label4.Text = "usuario o contraseña incorrectos";
                limpiarcampos();
            }


        }

        private void limpiarcampos()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}