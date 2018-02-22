using IBusiness;
using IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WF001.Models;

namespace WF001
{
    public partial class Site_2n : System.Web.UI.MasterPage
    {
        public string pais = "";
        protected void Page_Load(object sender, EventArgs e)
        {

            string user_name = Context.User.Identity.Name;

            List<PAGINA_BE> pp = PAGINA_BLL.GET(user_name);
            List<CARPETA_BE> cc = CARPETA_BLL.GET(user_name);

            SideMenu m = new SideMenu();
            string[] thisURLs = Request.Url.Segments;
            string thisURL = "";
            for (int i = 0; i < thisURLs.Length; i++)
                thisURL += thisURLs[i];
            thisURL = thisURL.ToLower();
            int nivel = thisURLs.Length;

            lblUser.Text = m.getUsuario(user_name);
            if (!thisURLs[thisURLs.Length - 1].Equals("SelPais.aspx"))
            {
                int cont = 0;
                foreach (CARPETA_BE c in cc)
                {
                    foreach (PAGINA_BE p in pp)
                    {
                        if (c.URL.Equals(""))
                        {
                            if (p.URL.ToLower().Equals(thisURL))
                                cont++;
                        }
                        else
                        {
                            if ((c.URL.ToLower() + p.URL.ToLower()).Equals(thisURL))
                                cont++;
                        }
                    }
                }
                if (cont == 0)
                {
                    Response.Redirect("../Default.aspx");
                }
            }
            lblMenu.Text = m.getMenu(user_name, thisURL, nivel, pp, cc);
            
            if (thisURLs[thisURLs.Length - 1].Equals("SelPais.aspx"))
            {
                nav_mobile.Visible = false;
            }
            else
            {
                accionesPais ap = new accionesPais();
                if (ap.paisSeleccionado(Session["pais"]))
                {
                    pais = ap.getPais(Session["pais"]);
                    //imgPais.Src = "/images/flags/4x3/" + pais + ".svg";
                }
                else
                    Response.Redirect("../SelPais.aspx");
            }
        }

    }
}