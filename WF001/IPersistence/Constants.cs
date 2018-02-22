using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPersistence
{
   public static class Constants
   {
       #region Constantes Store Procedure
        
       public const string CSP_FORMULARIO = "CSP_FORMULARIO";
       public const string CSP_VALOR = "CSP_VALOR";
       public const string CSP_REQUISICION = "CSP_REQUISICION";
        public const string CSP_USUARIO = "CSP_USUARIO";
        public const string CSP_PERMISO = "CSP_PERMISO";
        public const string CSP_CARPETA = "CSP_CARPETA";

        #endregion

        #region Enumeracion de las Acciones en los Store Procedure


        public enum AccionesTabla
       { 
           NONE = 0,
           ADD = 1,
           GET = 2,
           GET_B = 22,
           GET_C = 23,
           UPDATE = 3,
           DELETE = 4
       }

       public enum AccionesUsuario
       { 
          NONE = 0,
          GET_ROL = 1
       }
       public enum AccionesZEBAN
       { 
          GET_USER_HISTORICAL = 21
       }
       public enum AccionesZVARIABLES
       { 
          GET_USER_VARIABLES = 21
       }
       #endregion
   }
}
