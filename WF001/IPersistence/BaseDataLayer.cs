using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using IEntities;

namespace IPersistence
{
    public class BaseDataLayer
    {

        /// <summary>
        /// Obtiene una lista de usuarios
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        /// 
        public List<FORMULARIO_BE> FORMULARIO_GET(IDataReader reader)
        {
            List<FORMULARIO_BE> zeban_p = new List<FORMULARIO_BE>();

            try
            {
                while (reader.Read())
                {
                    FORMULARIO_BE z = new FORMULARIO_BE();

                    z.ID = Int32.Parse(reader["FORM_ID"].ToString());
                    z.PROP_ID = Int32.Parse(reader["PROP_ID"].ToString());
                    z.ORD = Int32.Parse(reader["ORD"].ToString());
                    z.NOMBRE = reader["NOMBRE"].ToString();
                    z.TEXTO = reader["TEXTO"].ToString();
                    z.TIPO = reader["TIPO"].ToString();

                    zeban_p.Add(z);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return zeban_p;
        }


        public List<VALOR_BE> VALOR_GET(IDataReader reader)
        {
            List<VALOR_BE> zeban_p = new List<VALOR_BE>();

            try
            {
                while (reader.Read())
                {
                    VALOR_BE z = new VALOR_BE();

                    z.ID = Int32.Parse(reader["ID"].ToString());
                    z.FORM_ID = Int32.Parse(reader["FORM_ID"].ToString());
                    z.PROP_ID = Int32.Parse(reader["PROP_ID"].ToString());
                    z.VALOR = reader["VALOR"].ToString();

                    zeban_p.Add(z);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return zeban_p;
        }

        public List<REQUISICION_BE> REQUISICION_GET(IDataReader reader)
        {
            List<REQUISICION_BE> zeban_p = new List<REQUISICION_BE>();

            try
            {
                while (reader.Read())
                {
                    REQUISICION_BE z = new REQUISICION_BE();

                    z.ID = Int32.Parse(reader["ID"].ToString());
                    z.FECHA = DateTime.Parse(reader["FECHA_CREA"].ToString());
                    z.USUARIO = Int32.Parse(reader["USUARIO"].ToString());

                    zeban_p.Add(z);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return zeban_p;
        }
        public REQUISICION_BE REQUISICION_GET1(IDataReader reader)
        {
            REQUISICION_BE z = new REQUISICION_BE();
            try
            {
                while (reader.Read())
                {
                    z.ID = Int32.Parse(reader["ID"].ToString());
                    z.FECHA = DateTime.Parse(reader["FECHA_CREA"].ToString());
                    z.USUARIO = Int32.Parse(reader["USUARIO"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return z;
        }

        public USUARIO_BE USUARIO_GET(IDataReader reader)
        {
            USUARIO_BE z = new USUARIO_BE();
            try
            {
                while (reader.Read())
                {

                    z.ID = reader["ID"].ToString();
                    z.PASS = reader["PASS"].ToString();
                    z.ROL_ID = Int32.Parse(reader["ID_GR"].ToString());
                    z.NOMBRE_ROL = reader["NOMBRE_GR"].ToString();
                    z.NOMBRE = reader["NOMBRE"].ToString() + " "
                        + reader["APELLIDO_P"].ToString() + " "
                        + reader["APELLIDO_M"].ToString();
                    z.EMAIL = reader["EMAIL"].ToString();
                    z.ACTIVO = bool.Parse(reader["ACTIVO"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return z;
        }
        public List<PAGINA_BE> PERMISO_GET(IDataReader reader)
        {
            List<PAGINA_BE> zz = new List<PAGINA_BE>();
            try
            {
                while (reader.Read())
                {
                    PAGINA_BE z = new PAGINA_BE();
                    z.ID = reader["ID"].ToString();
                    z.URL = reader["URL"].ToString();
                    z.PAG_ID = Int32.Parse(reader["ID_PAG"].ToString());
                    z.CAR_URL = reader["CAR_URL"].ToString();
                    z.CAR_ID = Int32.Parse(reader["CAR_ID"].ToString());
                    z.TITULO = reader["TITULO"].ToString();
                    z.ICONO = reader["ICONO"].ToString();
                    zz.Add(z);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return zz;
        }

        public List<CARPETA_BE> CARPETA_GET(IDataReader reader)
        {
            List<CARPETA_BE> zz = new List<CARPETA_BE>();
            try
            {
                while (reader.Read())
                {
                    CARPETA_BE z = new CARPETA_BE();
                    z.ID = Int32.Parse( reader["car_ID"].ToString());
                    z.URL = reader["car_URL"].ToString();
                    z.TITULO = reader["car_TIT"].ToString();
                    z.ICONO = reader["ICONO"].ToString();
                    zz.Add(z);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
            }
            return zz;
        }
    }
}
