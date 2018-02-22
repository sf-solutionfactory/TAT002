using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEntities
{
    [Serializable]
    public class REQUISICION_BE
    {
        private int _ID = 0;
        private DateTime _FECHA = DateTime.Now;
        private int _USUARIO = 0;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public DateTime FECHA
        {
            get { return _FECHA; }
            set { _FECHA = value; }
        }
        public int USUARIO
        {
            get { return _USUARIO; }
            set { _USUARIO = value; }
        }
    }
}
