using System;
using System.Collections.Generic;
using System.Linq;
using tp_4.DSTableAdapters;

using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_4
{
    public partial class WebFormManipulation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Stag_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = new stagiaireTableAdapter().GetDataByStag().Take(2);
            GridView1.DataBind();
        }

        protected void Grp_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = new groupeTableAdapter().GetDataByGrp().Take(2);
            GridView2.DataBind();
        }
    }
}