using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF001.Models
{
    public class accionesPais
    {
        public string getPais(object p)
        {
            return p.ToString();
        }
        public bool paisSeleccionado(object p)
        {
            if (p != null)
                if (p.ToString() != "")
                    return true;
            return false;
        }
    }
}