using IBusiness;
using IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF001.Models
{
    public class SideMenu
    {
        public string getUsuario(string u)
        {
            USUARIO_BE user = USUARIO_BLL.GET(u);

            string menu = "";
            menu += "<a href='#!name' style='padding: 0;'><span class='white-text name' style='margin: 0;'>" + user.NOMBRE + "</span></a>";
            menu += "<a href='#!email' style='padding: 0;'><span class='white-text email' style='padding: 0;'>" + user.EMAIL + "</span></a>";
            menu += "<a href='#!role' style='padding: 0;'><span class='white-text email' style='padding: 0;'>" + user.NOMBRE_ROL + "</span></a>";

            return menu;
        }

        public string getMenu(string u, string pg, int n, List<PAGINA_BE> pp, List<CARPETA_BE> cc)
        {
            string nivel = "";

            //--------------------------------PRODUCTIVO----------------------------------//
            //n = n - 2;//IIS
            n = n - 1;//Visual
            //--------------------------------PRODUCTIVO----------------------------------//

            while (n > 1)
            {
                nivel += "../";
                n--;
            }

            USUARIO_BE user = USUARIO_BLL.GET(u);
            //List<PAGINA_BE> pp = PAGINA_BLL.GET(u);
            //List<CARPETA_BE> cc = CARPETA_BLL.GET(u);
            string menu = "";

            pp = pp.OrderBy(o => o.PAG_ID).ToList();
            cc = cc.Distinct().ToList();

            menu += "<li class='no-padding'>";
            menu += "<ul class='collapsible collapsible-accordion'>";

            foreach (CARPETA_BE c in cc)
            {
                if (c.URL.Equals(""))
                {
                    foreach (PAGINA_BE p in pp)
                    {
                        if (c.ID.Equals(p.CAR_ID))
                        {
                            if (pg.Equals(p.URL.ToLower()))
                                menu += "<li class='bold'><a href='#'><i class='material-icons'>" + p.ICONO + "</i>" + p.TITULO + "</a></li>";
                            else
                                menu += "<li class='bold'><a href='" + nivel + p.URL + "'><i class='material-icons'>" + p.ICONO + "</i>" + p.TITULO + "</a></li>";
                        }
                    }
                }
                else
                {
                    menu += " <li class='bold'><a class='collapsible-header waves-effect waves-teal'><i class='material-icons'>" + c.ICONO + "</i>" + c.TITULO + "</a>";
                    menu += "<div class='collapsible-body'>";
                    menu += "<ul>";
                    foreach (PAGINA_BE p in pp)
                    {
                        if (c.ID.Equals(p.CAR_ID))
                        {
                            if (pg.Equals(c.URL.ToLower() + p.URL.ToLower()))
                                menu += "<li><a href='#'>" + p.TITULO + "</a></li> ";
                            else
                                menu += "<li><a href='" + nivel + c.URL + p.URL + "'>" + p.TITULO + "</a></li> ";
                        }
                    }
                    menu += "</ul>";
                    menu += "</div>";
                    menu += "</li>";
                }
            }

            //menu += "<li class='bold'><a class='collapsible-header waves-effect waves-teal'><i class='material-icons'>sync</i>Sincronización</a>";
            //menu += "<div class='collapsible-body'>";
            //menu += "<ul>";
            //menu += "<li><a href='autocomplete.html'>Autocomplete</a></li> ";
            //menu += "<li><a href='checkboxes.html'>Checkboxes</a></li>";
            //menu += "</ul>";
            //menu += "</div>";
            //menu += "</li>";

            //menu += "<li class='bold'><a class='collapsible-header waves-effect waves-teal'><i class='material-icons'>book</i>Catálogos</a>";
            //menu += "<div class='collapsible-body'>";
            //menu += "<ul>";
            //menu += "<li><a href='autocomplete.html'>Autocomplete</a></li> ";
            //menu += "<li><a href='checkboxes.html'>Checkboxes</a></li>";
            //menu += "</ul>";
            //menu += "</div>";
            //menu += "</li>";

            menu += "</ul>";
            menu += "</li>";
            return menu;
        }
    }
}