using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_4
{
    public partial class WebFormConnecter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {

        }

        protected void Conx_Click(object sender, EventArgs e)
        {
            string login = TextBox1.Text;
            string password = TextBox2.Text;
            if (TextBox1.Text == "mimou" && TextBox2.Text == "mimita")
            {
                Response.Redirect("WebFormManipulation.aspx");
            }
            else { Label3.Text = "les infos sont incorrectes"; }
        }
    }
}