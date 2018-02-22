using IBusiness;
using IEntities;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web.Security;
using WF001.Models;

namespace WF001
{
    public partial class Login : System.Web.UI.Page
    {
        public string lang;
        public Language idioma = new Language();
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = Request.Form["user_name"];
            string pass = Request.Form["user_pass"];

            lang = "ES";
            string json = File.ReadAllText(Server.MapPath("~\\lang\\" + lang + ".json"));
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer ser = new DataContractJsonSerializer(idioma.GetType());
            idioma = ser.ReadObject(ms) as Language;
            ms.Close();

            btn_login.Text = idioma.enter;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user = user_name.Value;
            string pass = user_pass.Value;

            try
            {
                if (!user.Equals(null) && !pass.Equals(null))
                {
                    USUARIO_BE u = USUARIO_BLL.GET(user);
                    //u.ID = "admin";
                    //u.PASS = "8K4LMN4Q1LKv/FUvbck3QA==";
                    accionesUsuario aU = new accionesUsuario();
                    if (aU.existeUsuario(u, user, pass))
                        FormsAuthentication.RedirectFromLoginPage(user, true);
                    else
                        lblError.Text = idioma.user_error;
                }
            }
            catch
            {
                lblError.Text = "";
            }
        }
    }
}