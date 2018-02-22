using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEntities
{
    [Serializable]
    public class PAGINA_BE
    {
        private string _ID = string.Empty;
        private string _URL = string.Empty;
        private int _PAG_ID = 0;
        private int _CAR_ID = 0;
        private string _CAR_URL = string.Empty;
        private string _TITULO = string.Empty;
        private string _ICONO = string.Empty;

        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string URL
        {
            get { return _URL; }
            set { _URL = value; }
        }
        public int PAG_ID
        {
            get { return _PAG_ID; }
            set { _PAG_ID = value; }
        }
        public string CAR_URL
        {
            get { return _CAR_URL; }
            set { _CAR_URL = value; }
        }
        public int CAR_ID
        {
            get { return _CAR_ID; }
            set { _CAR_ID = value; }
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
