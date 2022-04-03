using CD_miCasa.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_miCasa.Data
{
    public class DueñosData
    {
        public DataTable registrosDueños()
        {
            using(SqlConnection con=new SqlConnection(Conexion.cadCon))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_selectAllDueños";
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
        public Dueños selectDueño(int idDueño)
        {
            using(SqlConnection con= new SqlConnection(Conexion.cadCon))
            {
                try
                {
                    Dueños newDueño = new Dueños();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_selectOneDueños";
                    cmd.Parameters.AddWithValue("idDueño", idDueño);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        newDueño.IdDueño = dr.GetInt32(0);
                        newDueño.Nombre = dr.GetString(1);
                        newDueño.Edad = dr.GetInt32(2);
                        newDueño.Direccion = dr.GetString(3);
                    }
                    return newDueño;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    //dr.Close();
                    if (con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
        public void insertarDueños(Dueños insDueño)
        {
            using(SqlConnection con=new SqlConnection(Conexion.cadCon))
            {
                try
                {
                    SqlCommand cmd=new SqlCommand();
                    cmd.Connection=con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_insertDueños";
                    cmd.Parameters.AddWithValue("@Nombre", insDueño.Nombre);
                    cmd.Parameters.AddWithValue("@Edad", insDueño.Edad);
                    cmd.Parameters.AddWithValue("@Direccion", insDueño.Direccion);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if(con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
        public void modificarDueño(Dueños modDueño)
        {
            using( SqlConnection con=new SqlConnection(Conexion.cadCon))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_updateDueños";
                    cmd.Parameters.AddWithValue("@idDueño", modDueño.IdDueño);
                    cmd.Parameters.AddWithValue("@Nombre", modDueño.Nombre);
                    cmd.Parameters.AddWithValue("@Edad", modDueño.Edad);
                    cmd.Parameters.AddWithValue("@Direccion", modDueño.Direccion);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch(Exception)
                {
                    throw;
                }
                finally
                {
                    if(con.State!= ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
        public void eliminarDueño(int eliDueño)
        {
            using(SqlConnection con=new SqlConnection(Conexion.cadCon))
            {
                try
                {
                    SqlCommand cmd=new SqlCommand();
                    cmd.Connection=con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_deleteDueños";
                    cmd.Parameters.AddWithValue("@idDueño", eliDueño);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if(con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
        public DataTable buscarDireccionDueños(string direccionDueño)
        {
            using(SqlConnection con=new SqlConnection(Conexion.cadCon))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_buscarDireccionDueños";
                    cmd.Parameters.AddWithValue("@Direccion", direccionDueño);
                    con.Open();
                    SqlDataAdapter da=new SqlDataAdapter(cmd);
                    DataTable tbl = new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if(con.State!= ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
