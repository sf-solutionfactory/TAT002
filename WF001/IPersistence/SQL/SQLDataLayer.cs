using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IEntities;
using System.Data;
using System.Collections;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using System.Data.Common;
using System.Transactions;
using System.Data.Odbc;
using System.Data.SqlClient;


namespace IPersistence.SQL
{
    public class SQLDataLayer : AbstractDataAccessLayer
    {

        #region FORMUARIO

        public override List<FORMULARIO_BE> FORMULARIO_GET(int id)
        {
            DbCommand Command = null;
            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                Command = DB.GetStoredProcCommand(Constants.CSP_FORMULARIO);

                DB.AddInParameter(Command, "@ID", DbType.String, id);
                DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.GET);

                return FORMULARIO_GET(DB.ExecuteReader(Command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Dispose();
            }
        }
        #endregion
        #region VALOR
        public override int VALOR_INSERT(VALOR_BE z)
        {
            DbCommand Command = null;
            int returnValue = 0;

            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                using (TransactionScope MyTranasaccion = new TransactionScope())
                {

                    Command = DB.GetStoredProcCommand(Constants.CSP_VALOR);

                    DB.AddInParameter(Command, "@ID", DbType.String, string.Empty);
                    DB.AddInParameter(Command, "@REQ_ID", DbType.String, z.REQ_ID);
                    DB.AddInParameter(Command, "@FORM_ID", DbType.Int32, z.FORM_ID);
                    DB.AddInParameter(Command, "@PROP_ID", DbType.Int32, z.PROP_ID);
                    DB.AddInParameter(Command, "@VALOR", DbType.String, z.VALOR);
                    DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.ADD);

                    returnValue = DB.ExecuteNonQuery(Command);

                    MyTranasaccion.Complete();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message.ToString();
                return 0;
            }
            finally
            {
                Command.Dispose();
            }
        }

        public override List<VALOR_BE> VALOR_GET(int id)
        {
            DbCommand Command = null;
            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                Command = DB.GetStoredProcCommand(Constants.CSP_VALOR);

                DB.AddInParameter(Command, "@ID", DbType.String, id);
                DB.AddInParameter(Command, "@REQ_ID", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@FORM_ID", DbType.Int32, string.Empty);
                DB.AddInParameter(Command, "@PROP_ID", DbType.Int32, string.Empty);
                DB.AddInParameter(Command, "@VALOR", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.GET);

                return VALOR_GET(DB.ExecuteReader(Command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Dispose();
            }
        }
        #endregion
        #region REQUISICION
        public override int REQUISICION_INSERT(REQUISICION_BE z)
        {
            DbCommand Command = null;
            int returnValue = 0;

            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                using (TransactionScope MyTranasaccion = new TransactionScope())
                {

                    Command = DB.GetStoredProcCommand(Constants.CSP_REQUISICION);

                    DB.AddInParameter(Command, "@ID", DbType.String, string.Empty);
                    DB.AddInParameter(Command, "@FECHA", DbType.Date, z.FECHA);
                    DB.AddInParameter(Command, "@USUARIO", DbType.Int32, z.USUARIO);
                    DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.ADD);

                    returnValue = DB.ExecuteNonQuery(Command);

                    MyTranasaccion.Complete();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                string strError = ex.Message.ToString();
                return 0;
            }
            finally
            {
                Command.Dispose();
            }
        }

        public override REQUISICION_BE REQUISICION_GET()
        {
            DbCommand Command = null;
            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                Command = DB.GetStoredProcCommand(Constants.CSP_REQUISICION);

                DB.AddInParameter(Command, "@ID", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@FECHA", DbType.Date, DateTime.Now);
                DB.AddInParameter(Command, "@USUARIO", DbType.Int32, 0);
                DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.GET);

                return REQUISICION_GET1(DB.ExecuteReader(Command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Dispose();
            }
        }
        public override List<REQUISICION_BE> REQUISICION_GET(int id)
        {
            DbCommand Command = null;
            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                Command = DB.GetStoredProcCommand(Constants.CSP_REQUISICION);

                DB.AddInParameter(Command, "@ID", DbType.String, id);
                DB.AddInParameter(Command, "@FECHA", DbType.Date, DateTime.Now);
                DB.AddInParameter(Command, "@USUARIO", DbType.Int32, string.Empty);
                DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.GET_B);

                return REQUISICION_GET(DB.ExecuteReader(Command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Dispose();
            }
        }
        #endregion
        #region USUARIO

        public override USUARIO_BE USUARIO_GET(string id)
        {
            DbCommand Command = null;
            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                Command = DB.GetStoredProcCommand(Constants.CSP_USUARIO);

                DB.AddInParameter(Command, "@ID", DbType.String, id);
                DB.AddInParameter(Command, "@PASS", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@NOMBRE", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@APELLIDO_P", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@APELLIDO_M", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@EMAIL", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@SPRAS_ID", DbType.String, string.Empty);
                DB.AddInParameter(Command, "@ACTIVO", DbType.Boolean, false);
                DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.GET);

                return USUARIO_GET(DB.ExecuteReader(Command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Dispose();
            }
        }
        #endregion
        #region PERMISO

        public override List<PAGINA_BE> PERMISO_GET(string id)
        {
            DbCommand Command = null;
            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                Command = DB.GetStoredProcCommand(Constants.CSP_PERMISO);

                DB.AddInParameter(Command, "@ID", DbType.String, id);
                DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.GET);

                return PERMISO_GET(DB.ExecuteReader(Command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Dispose();
            }
        }
        #endregion

        #region PERMISO

        public override List<CARPETA_BE> CARPETA_GET(string id)
        {
            DbCommand Command = null;
            try
            {
                Database DB = DatabaseFactory.CreateDatabase();
                Command = DB.GetStoredProcCommand(Constants.CSP_CARPETA);

                DB.AddInParameter(Command, "@ID", DbType.String, id);
                DB.AddInParameter(Command, "@ACCION", DbType.Int32, Constants.AccionesTabla.GET);

                return CARPETA_GET(DB.ExecuteReader(Command));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Command.Dispose();
            }
        }
        #endregion
    }

}
