using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WF001.Models;

namespace WF001.Provision
{
    public partial class Nuevo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region PAÍS
            string pais = "";
            accionesPais ap = new accionesPais();
            if (ap.paisSeleccionado(Session["pais"]))
                pais = ap.getPais(Session["pais"]);
            else
                Response.Redirect("../SelPais.aspx");
            #endregion PAÍS
        }
    }
}