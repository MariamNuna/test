using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using tp_4.DSTableAdapters;
using System.Web.Services;

namespace tp_4.Service_Web
{
    /// <summary>
    /// Description résumée de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Pour autoriser l'appel de ce service Web depuis un script à l'aide d'ASP.NET AJAX, supprimez les marques de commentaire de la ligne suivante. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            int idg = new groupeTableAdapter().GetData().Count();
            return "le nombre de groupes est : "+idg;
        }

        [WebMethod]
        public void ajouter(string nom)
        {
            groupeTableAdapter a = new groupeTableAdapter();
            a.Insert(nom, DateTime.Now, DateTime.Now);
        }



        [WebMethod]
        public void supprimer(int id)
        {
            DS.groupeRow s = new groupeTableAdapter().GetData().FindByidg(id);
            s.Delete();
            new groupeTableAdapter().Update(s);
        }

        [WebMethod]
        public void modifier(string nom,int id)
        {
            DS.groupeRow s = new groupeTableAdapter().GetData().FindByidg(id);
            s.nomg = nom;
            s.datecreation = DateTime.Now;
            s.datemodification = DateTime.Now;
            new groupeTableAdapter().Update(s);
        }
    }
}
