using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEntities
{
    [Serializable]
    public class CARPETA_BE
    {
        private int _ID = 0;
        private string _URL = string.Empty;
        private string _TITULO = string.Empty;
        private string _ICONO = string.Empty;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }
        public string TITULO
        {
            get { return _TITULO; }
            set { _TITULO = value; }
        }
        public string ICONO
        {
            get { return _ICONO; }
            set { _ICONO = value; }
        }
    }
}
