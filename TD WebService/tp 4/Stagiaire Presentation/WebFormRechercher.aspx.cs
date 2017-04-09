using System;
using System.Collections.Generic;
using System.Linq;
using tp_4.DSTableAdapters;
using System.Web;

using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_4
{
    public partial class WebFormRechercher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void butrech_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            DS d = new DS();
            new groupeTableAdapter().Fill(d.groupe);
            new stagiaireTableAdapter().FillByNom(d.stagiaire, TextBox1.Text,Convert.ToInt32(DropDownList1.SelectedValue));
            GridView1.DataSource = d.stagiaire.ToList<DS.stagiaireRow>();
            GridView1.DataBind();
        }

        private void ChargerStagiare(DS.stagiaireRow s)
        {
            if (s != null)
            {
                this.TextBox1.Text = s.nom;
               // this.DropDownGrp.SelectedValue = Convert.ToString(s.groupeRow.idg);
            }
        }
        


        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
           // DropDownGrp.SelectedValue = null; 
        }
    }
}