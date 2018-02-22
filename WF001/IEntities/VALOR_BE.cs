using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEntities
{
    [Serializable]
    public class VALOR_BE
    {
        private int _ID = 0;
        private int _REQ_ID = 0;
        private int _FORM_ID = 0;
        private int _PROP_ID = 0;
        private string _VALOR = string.Empty;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public int REQ_ID
        {
            get { return _REQ_ID; }
            set { _REQ_ID = value; }
        }
        public int FORM_ID
        {
            get { return _FORM_ID; }
            set { _FORM_ID = value; }
        }
        public int PROP_ID
        {
            get { return _PROP_ID; }
            set { _PROP_ID = value; }
        }
        public string VALOR
        {
            get { return _VALOR; }
            set { _VALOR = value; }
        }
    }
}
