using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using tp_4.DSTableAdapters;
using System.Web.UI.WebControls;

namespace tp_4
{
    public partial class WebFormstag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // if (!IsPostBack)
                GridView1.DataSource = new stagiaireTableAdapter().GetData().ToList();
            GridView1.DataBind();
        }


        private void ChargerStagiare(DS.stagiaireRow s)
            {
                if (s != null)
                {
                    this.lblID.Text = s.id.ToString();
                    this.TextBoxNom.Text = s.nom;
                    this.TextBoxPrenom.Text = s.prenom;
                    this.lbldatecreat.Text = s.date_creation.ToShortTimeString();
                   this.lbldatemodi.Text = s.date_modification.ToShortTimeString();
                   this.DropDownListGr.SelectedValue = Convert.ToString(s.idg.ToString()); 
                }      
            }
            private void actualiser()
            {
                DS ds = new DS();
                GridView1.DataSource = new stagiaireTableAdapter().GetData().ToList<DS.stagiaireRow>();
                GridView1.DataBind();
                
            }
        
        
      

        protected void Butenreg_Click(object sender, EventArgs e)
        {
            stagiaireTableAdapter a = new stagiaireTableAdapter();
            a.Insert(TextBoxNom.Text, TextBoxPrenom.Text, DateTime.Now, DateTime.Now, Convert.ToInt32(DropDownListGr.SelectedValue));
           actualiser();
        }

        protected void Butsup_Click(object sender, EventArgs e)
        {
            DS.stagiaireRow s = new stagiaireTableAdapter().GetData().FindByid(Convert.ToInt32(lblID.Text));
            s.Delete();
            new stagiaireTableAdapter().Update(s);
            this.actualiser();
        }


        public void MiseAjour(int id)
        {
            DropDownListGr.DataSource = new groupeTableAdapter().GetData();

            DS.stagiaireRow s = new stagiaireTableAdapter().GetData().FindByid(id);
            lblID.Text = s.id + "";
            TextBoxNom.Text = s.nom;
            TextBoxPrenom.Text = s.prenom;
            DropDownListGr.SelectedValue = s.idg + "";
        }


        protected void Butmod_Click(object sender, EventArgs e)
        {
              DS.stagiaireRow g = new stagiaireTableAdapter().GetData().FindByid(Convert.ToInt32(lblID.Text));
            g.nom = TextBoxNom.Text;
            g.prenom = TextBoxPrenom.Text;
            g.idg = Convert.ToInt32(DropDownListGr.SelectedValue);
            //MiseAjour((Convert.ToInt32(lblID.Text)));
            new stagiaireTableAdapter().Update(g);
            actualiser();
        }

        protected void aj_Click(object sender, EventArgs e)
        {
            TextBoxNom.Text = "";
            TextBoxPrenom.Text = "";
            lbldatecreat.Text = DateTime.Now+"";
            lbldatemodi.Text = DateTime.Now + "";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

        }

        protected void Navigation_Click(object sender, EventArgs e)
        {
            int page_index = 0;
            Button b = sender as Button;
            DS.stagiaireDataTable stg = new stagiaireTableAdapter().GetData();
            switch (b.CommandName)
            {
                    //getdata katruturni l'objet u fill katfetech
                case "Debut":
                    ViewState["PageIndex"] = 0;
                    this.ChargerStagiare(stg.First());
                    break;

                case "Suivant":
                    page_index = (int)ViewState["PageIndex"];
                        page_index = Math.Min(stg.Count - 1, ++page_index);
                        ViewState["PageIndex"] = page_index;
                    this.ChargerStagiare((DS.stagiaireRow)stg.Rows[page_index]);
                    break;

                case "Precedent":
                    page_index = (int)ViewState["PageIndex"];
                    page_index = Math.Max(0, --page_index);
                    ViewState["PageIndex"] = page_index;
                    this.ChargerStagiare((DS.stagiaireRow)stg.Rows[page_index]);
                    break;

                case "Fin":
                    ViewState["PageIndex"] = stg.Count - 1;
                    this.ChargerStagiare(stg.Last());
                    break;


            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListGr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}