using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tp_4.DSTableAdapters;
using System.Web.UI;


using System.Web.UI.WebControls;

namespace tp_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
          //  if (!IsPostBack)
                GridView1.DataSource = new groupeTableAdapter().GetData().ToList();
            GridView1.DataBind();
        }



        private void actualiser()
        {
            DS ds = new DS();
         //   new groupeTableAdapter().Fill(ds.groupe);
            GridView1.DataSource = ds.groupe; //new groupeTableAdapter().GetData().ToList<DS.groupeRow>(); //  = ds.groupe;
            GridView1.DataBind();
            
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButNv_Click(object sender, EventArgs e)
        {
            TextNom.Text = "";
            lbldateCreation.Text = DateTime.Now.ToString();
            lblDateModification.Text = "";
        }
         
        protected void Butenreg_Click(object sender, EventArgs e)
        {
            groupeTableAdapter q = new groupeTableAdapter();
            q.Insert( TextNom.Text, DateTime.Now, DateTime.Now);
            actualiser();
        }



        private void ChargerGroupe(DS.groupeRow g)
        {
            if (g != null)
            {
               // ViewState["idg"] = g.idg.ToString();
                 this.LabelId.Text = g.idg.ToString();
                this.TextNom.Text = g.nomg;
                this.lbldateCreation.Text = g.datecreation.ToString();
                this.lblDateModification.Text = g.datemodification.ToShortTimeString();//.ToShortTimeString();
            }
        }


        protected void Butsup_Click(object sender, EventArgs e)
        {
            if (LabelId.Text != null)
            {
                DS.groupeRow s = new groupeTableAdapter().GetData().FindByidg(Convert.ToInt32(LabelId.Text));
                s.Delete();
                new groupeTableAdapter().Update(s);
                this.actualiser();
            }
            else { Response.Write("<script> alert(aucune stagiaire selectionnée )</script>"); }
        }

       

        protected void Butmodi_Click(object sender, EventArgs e)
        {
            
          // NB : int.Parse(ViewState["idg"].ToString()) = LabelId.Text
            DS.groupeRow g = new groupeTableAdapter().GetData().FindByidg(Convert.ToInt32(LabelId.Text));
            g.nomg = TextNom.Text;
            g.datecreation = DateTime.Now;
            g.datemodification = DateTime.Now;
            new groupeTableAdapter().Update(g);
            this.actualiser();
        }

        protected void ButFirst_Click(object sender, EventArgs e)
        {

        }

        protected void Navigation_Click(object sender, EventArgs e)
        {
            int page_index = 0;
            Button b = sender as Button;
            DS.groupeDataTable grp = new groupeTableAdapter().GetData();
            switch (b.CommandName)
            {
                case "Fin":
                    ViewState["PageIndex"] = 0;
                    this.ChargerGroupe(grp.First());
                    break;

                case "Suivant":
                   page_index = (int)ViewState["PageIndex"];
                    
                        page_index = Math.Min(grp.Count - 1, ++page_index);
                        ViewState["PageIndex"] = page_index;
                    
                        this.ChargerGroupe((DS.groupeRow)grp.Rows[page_index]);
                        break;
                    
                case "Precedent":
                   page_index = (int)ViewState["PageIndex"];
                    page_index = Math.Max(0, --page_index);
                    ViewState["PageIndex"] = page_index;
                    this.ChargerGroupe((DS.groupeRow)grp.Rows[page_index]);
                    break;

                case "Debut":
                    ViewState["PageIndex"] = grp.Count - 1;
                    this.ChargerGroupe(grp.Last());
                    break;

            }
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}