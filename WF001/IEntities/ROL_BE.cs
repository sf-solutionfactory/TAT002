using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEntities
{
    [Serializable]
    public class ROL_BE
    {
        private string  _ID= string.Empty;
        private string  _PASS = string.Empty;
        private int     _ROL_ID = 0;
        private string  _NOMBRE = string.Empty;
        private string  _MAIL = string.Empty;
        private bool    _ACTIVE = false;
            
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
            get { return _ROL_ID; }
            set { _ROL_ID = value; }
        }
        public string NOMBRE
        {
            get{ return _NOMBRE;}
            set{ _NOMBRE = value;}
        }
        public string MAIL
        {
            get { return _MAIL; }
            set { _MAIL = value; }
        }
        public bool ACTIVE
        {
            get { return _ACTIVE; }
            set { _ACTIVE = value; }
        }
    }
}
