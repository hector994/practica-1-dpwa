using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica_1_dpwa
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string product_name = TextBox1.Text;
            string unidades = TextBox2.Text;
            string precio = TextBox3.Text;

            Label4.Visible = true;

            Label4.Text = "Nombre: " + product_name + " Precio: " + precio;
            limpiarcampos();
        }

        private void limpiarcampos()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }   
    }
}