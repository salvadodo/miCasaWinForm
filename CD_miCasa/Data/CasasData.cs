using CD_miCasa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_miCasa.Data
{
    public class CasasData
    {
        public DataTable registrosCasas()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadCon))
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conBDmiCasa4"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_selectAllCasas";
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
        public Casas selectCasa(int idCasa)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadCon))
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conBDmiCasa4"].ConnectionString))
            {
                try
                {
                    Casas newCasa = new Casas();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_selectOneCasas";
                    cmd.Parameters.AddWithValue("@idCasa", idCasa);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.Default);
                    while (dr.Read())
                    {
                        newCasa.IdCasa = dr.GetInt32(0);
                        newCasa.TipodeCasa = dr.GetString(1);
                        newCasa.Ubicacion = dr.GetString(2);
                        newCasa.Descripcion = dr.GetString(3);
                        newCasa.Dueño = dr.GetInt32(4);
                    }
                    return newCasa;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    //dr.close();
                    if (con.State != ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
        public void insertarCasa(Casas insCasa)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadCon))
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conBDmiCasa4"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_insertCasas";
                    cmd.Parameters.AddWithValue("@tipodecasa", insCasa.TipodeCasa);
                    cmd.Parameters.AddWithValue("@Ubicacion", insCasa.Ubicacion);
                    cmd.Parameters.AddWithValue("@Descripcion", insCasa.Descripcion);
                    cmd.Parameters.AddWithValue("@Dueño", insCasa.Dueño);
                    con.Open();
                    cmd.ExecuteNonQuery();
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
        public void modificarCasas(Casas modCasas)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadCon))
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conBDmiCasa4"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_updateCasas";
                    cmd.Parameters.AddWithValue("@idCasa", modCasas.IdCasa);
                    cmd.Parameters.AddWithValue("@tipodecasa", modCasas.TipodeCasa);
                    cmd.Parameters.AddWithValue("@Ubicacion", modCasas.Ubicacion);
                    cmd.Parameters.AddWithValue("@Descripcion", modCasas.Descripcion);
                    cmd.Parameters.AddWithValue("@Dueño", modCasas.Dueño);
                    con.Open();
                    cmd.ExecuteNonQuery();
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
        public void eliminarCasa(int eliCasa)
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadCon))
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conBDmiCasa4"].ConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_deleteCasas";
                    cmd.Parameters.AddWithValue("@idCasa", eliCasa);
                    con.Open();
                    cmd.ExecuteNonQuery();
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
        public DataTable buscarPorUbicacion(string ubicacionCasa)
        {
            using(SqlConnection con = new SqlConnection(Conexion.cadCon))
            {
                try
                {
                    SqlCommand cmd=new SqlCommand();
                    cmd.Connection=con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_buscarUbicacionCasas";
                    cmd.Parameters.AddWithValue("@Ubicacion", ubicacionCasa);
                    con.Open();
                    SqlDataAdapter da=new SqlDataAdapter(cmd);
                    DataTable tbl=new DataTable();
                    da.Fill(tbl);
                    return tbl;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (con.State!=ConnectionState.Closed)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
}
