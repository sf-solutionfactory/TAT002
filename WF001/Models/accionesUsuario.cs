using IEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WF001.Models
{
    public class accionesUsuario
    {
        public bool existeUsuario(USUARIO_BE us, string u, string p)
        {
            Cryptography c = new Cryptography();
            string pass = c.Decrypt(us.PASS);
            if (u.Equals(us.ID))
                if (p.Equals(pass))
                    return true;
            return false;
        }
    }
}