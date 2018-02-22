using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEntities
{
    [Serializable]
    public class FORMULARIO_BE
    {
        private int     _ID= 0;
        private int     _PROP_ID = 0;
        private int     _ORD = 0;
        private string _NOMBRE = string.Empty;
        private string  _TEXTO = string.Empty;
        private string _TIPO = string.Empty;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public int PROP_ID
        {
            get { return _PROP_ID; }
            set { _PROP_ID = value; }
        }
        public int ORD
        {
            get { return _ORD; }
            set { _ORD = value; }
        }
        public string NOMBRE
        {
            get{ return _NOMBRE;}
            set{ _NOMBRE = value;}
        }
        public string TEXTO
        {
            get { return _TEXTO; }
            set { _TEXTO = value; }
        }
        public string TIPO
        {
            get { return _TIPO; }
            set { _TIPO = value; }
        }
    }
}
