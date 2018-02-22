using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEntities
{
    [Serializable]
    public class USUARIO_BE
    {
        private string  _ID= string.Empty;
        private string  _PASS = string.Empty;
        private int _GRUPO_ID = 0;
        private string _NOMBRE_ROL = string.Empty;
        private string  _NOMBRE = string.Empty;
        private string  _EMAIL = string.Empty;
        private bool    _ACTIVO = false;
            
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string PASS
        {
            get { return _PASS; }
            set { _PASS = value; }
        }
        public int ROL_ID
        {
            get { return _GRUPO_ID; }
            set { _GRUPO_ID = value; }
        }
        public string NOMBRE_ROL
        {
            get { return _NOMBRE_ROL; }
            set { _NOMBRE_ROL = value; }
        }
        public string NOMBRE
        {
            get { return _NOMBRE; }
            set { _NOMBRE = value; }
        }
        public string EMAIL
        {
            get { return _EMAIL; }
            set { _EMAIL = value; }
        }
        public bool ACTIVO
        {
            get { return _ACTIVO; }
            set { _ACTIVO = value; }
        }
    }
}
