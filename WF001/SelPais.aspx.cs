using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WF001
{
    public partial class SelPais : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void mx_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton b = (ImageButton)sender;
            Session["pais"] = b.ID;

            Response.Redirect("Default.aspx");
        }
    }
}