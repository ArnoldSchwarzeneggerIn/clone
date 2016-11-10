using Oracle.ManagedDataAccess.Client;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Conexions
{
    public class Conexion
    {

        public string stringConnection = ConfigurationManager.ConnectionStrings["oracleConexion"].ConnectionString;

        public OracleConnection ConexionOracle()
        {
            OracleConnection Conexion = new OracleConnection(stringConnection);
            try
            {
                Conexion.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("No se realizo la conexion a la base de datos: " + ex.Message);
            }
            return Conexion;
        }

        public DataTable realizarConsulta(string Procedure, string Cursor, Parametro[] Parameters)
        {
            DataTable data = new DataTable();
            OracleConnection conn = new OracleConnection();
            conn = ConexionOracle();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = Procedure;
            cmd.CommandType = CommandType.StoredProcedure;

            if (Parameters != null)
            {
                for (int i = 0; i < Parameters.Length; i++)
                {
                    cmd.Parameters.Add(Parameters[i].Nombre, Parameters[i].Value).Direction = ParameterDirection.Input;
                }
            }
            cmd.Parameters.Add(Cursor, OracleDbType.RefCursor).Direction = ParameterDirection.Output;

            try
            {
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(data);
                return data;
            }
            catch (Exception e)
            {
                throw new Exception("Sentencia de consulta invalida " + e.Message);
            }
        }

        public bool realizarTransaccion(Transacion[] list)
        {
            bool state = false;
            OracleConnection conn = new OracleConnection();
            OracleCommand cmd = null;
            conn = ConexionOracle();

            OracleTransaction Transa = conn.BeginTransaction();

            try
            {
                for (int i = 0; i < list.Length; i++)
                {
                    if (list[i] != null)
                    {
                        cmd = new OracleCommand(list[i].Procedure, conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        foreach (Parametro obj in list[i].Parameters)
                        {
                            if (obj.Value.Equals("null"))
                            {

                                cmd.Parameters.Add(obj.Nombre, OracleDbType.Blob, obj.ValueBit, ParameterDirection.Input);

                            }
                            else
                            {
                                cmd.Parameters.Add(obj.Nombre, obj.Value);
                            }
                            
                        }

                        cmd.Transaction = Transa;
                        cmd.ExecuteNonQuery();
                    }
                }
                Transa.Commit();
                conn.Close();
                conn.Dispose();
                Transa.Dispose();
                state = true;
            }
            catch
            {
                Transa.Rollback();
                conn.Close();
                conn.Dispose();
                state = false;
            }
            finally
            {
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
            return state;
        }
    }
}