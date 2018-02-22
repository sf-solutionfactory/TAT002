using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IEntities;
using IPersistence;
using System.Configuration;

namespace IBusiness
{
    public class REQUISICION_BLL
    {
        public static int INSERT(REQUISICION_BE V)
        {
            return AbstractDataAccesLayerHelper.GetDataAccessLayer().REQUISICION_INSERT(V);
        }
        public static REQUISICION_BE GET()
        {
            return AbstractDataAccesLayerHelper.GetDataAccessLayer().REQUISICION_GET();
        }
        public static List<REQUISICION_BE> GET(int id)
        {
            return AbstractDataAccesLayerHelper.GetDataAccessLayer().REQUISICION_GET(id);
        }
        //public static List<ZEBAN_S_BE> GET(int banfn, string bnfpo)
        //{
        //    return AbstractDataAccesLayerHelper.GetDataAccessLayer().ZEBAN_S_GET(banfn,bnfpo);
        //}
        //public static int UPDATE(List<ZEBAN_S_BE> requisiciones)
        //{
        //    return AbstractDataAccesLayerHelper.GetDataAccessLayer().ZEBAN_S_UPDATE(requisiciones);
        //}
        //public static int DELETE(List<ZEBAN_S_BE> requisiciones)
        //{
        //    return AbstractDataAccesLayerHelper.GetDataAccessLayer().ZEBAN_S_DELETE(requisiciones);
        //}
    }
}
