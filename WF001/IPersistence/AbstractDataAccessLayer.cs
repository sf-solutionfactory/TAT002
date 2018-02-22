using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Web.Profile;
using System.Data.Common;
using IEntities;
using System.Data.SqlClient;


namespace IPersistence
{
    public abstract partial class AbstractDataAccessLayer : BaseDataLayer
    {

        protected delegate List<object> GenerateListFromReader(IDataAdapter reader);

        #region FORMULARIO
        public abstract List<FORMULARIO_BE> FORMULARIO_GET(int id);
        #endregion

        #region VALOR
        public abstract List<VALOR_BE> VALOR_GET(int id);
        public abstract int VALOR_INSERT(VALOR_BE V);
        #endregion
        #region REQUISICION
        public abstract REQUISICION_BE REQUISICION_GET();
        public abstract List<REQUISICION_BE> REQUISICION_GET(int id);
        public abstract int REQUISICION_INSERT(REQUISICION_BE V);
        #endregion
        #region USUARIO
        public abstract USUARIO_BE USUARIO_GET(string id);
        #endregion
        #region PERMISO
        public abstract List<PAGINA_BE> PERMISO_GET(string id);
        #endregion
        #region CARPETA
        public abstract List<CARPETA_BE> CARPETA_GET(string id);
        #endregion
    }
}
