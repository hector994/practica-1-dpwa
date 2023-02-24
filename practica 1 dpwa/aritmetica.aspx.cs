using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practica_1_dpwa
{
    public partial class aritmetica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Visible = false;
            RadioButton1.Checked = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int dato1 = int.Parse(TextBox1.Text);
            int dato2 = int.Parse(TextBox2.Text);
            int resultado;
            if (RadioButton1.Checked)
            {
                Label4.Visible = true;
                resultado = dato1 + dato2;
                Label4.Text = resultado.ToString();
            }
            if (RadioButton2.Checked)
            {
                Label4.Visible = true;
                resultado = dato1 - dato2;
                Label4.Text = resultado.ToString();
            }
            if (RadioButton3.Checked)
            {
                Label4.Visible = true;
                resultado = dato1 * dato2;
                Label4.Text = resultado.ToString();
            }
            if (RadioButton4.Checked)
            {
                Label4.Visible = true;
                resultado = dato1 / dato2;
                Label4.Text = resultado.ToString();
            }

            limpiarcampos();
        }

        private void limpiarcampos()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}