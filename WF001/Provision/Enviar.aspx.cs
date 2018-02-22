using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WF001.Provision
{
    public partial class Enviar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] oo = Request.Form.AllKeys;
            Object o = Request.Form["table"];
            o.ToString();
        }

    }
}