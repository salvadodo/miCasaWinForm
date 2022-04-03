using CD_miCasa.Models;
using CD_miCasa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows;

namespace CN_miCasa
{
    public class NegCasas
    {
        public static DataTable mostrarCasas()
        {
            CasasData dataCasa = new CasasData();
            return dataCasa.registrosCasas();
        }
        public static Casas selectCasa(string idCasa)
        {
            CasasData dataCasa = new CasasData();
            return dataCasa.selectCasa(Convert.ToInt32(idCasa));
        }
        public static void insertarCasas(string tipodeCasa, string ubicacion, string descripcion, string dueño)
        {
            if(tipodeCasa!="" && ubicacion!="" && descripcion!="" && dueño != "")
            {
                Casas newCasa = new Casas();
                CasasData dataCasa = new CasasData();
                newCasa.TipodeCasa = tipodeCasa;
                newCasa.Ubicacion = ubicacion;
                newCasa.Descripcion = descripcion;
                newCasa.Dueño = Convert.ToInt32(dueño);
                dataCasa.insertarCasa(newCasa);
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Datos de Casas", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public static void editarCasas(string idCasa, string tipodeCasa, string ubicacion, string descripcion, string dueño)
        {
            if(tipodeCasa!="" && ubicacion != "" && descripcion != "" && dueño!= "")
            {
                Casas newCasa = new Casas();
                CasasData dataCasa = new CasasData();
                newCasa.IdCasa = Convert.ToInt32(idCasa);
                newCasa.TipodeCasa = tipodeCasa;
                newCasa.Ubicacion = ubicacion;
                newCasa.Descripcion = descripcion;
                newCasa.Dueño = Convert.ToInt32(dueño);
                dataCasa.modificarCasas(newCasa);
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar", "Datos de Casas", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public static void eliminarCasas(string idCasa)
        {
            if (idCasa != "")
            {
                //Casas newCasa = new Casas();
                CasasData dataCasa = new CasasData();
                //newCasa.IdCasa = Convert.ToInt32(idCasa);
                dataCasa.eliminarCasa(Convert.ToInt32(idCasa));
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Datos de Casas", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public static DataTable buscarUbicacion(string ubicacion)
        {
            if(ubicacion != "")
            {
                //Casas newCasa=new Casas();
                CasasData dataCasa = new CasasData();
                //newCasa.Ubicacion = ubicacion;
                return dataCasa.buscarPorUbicacion(ubicacion);
            }
            else
            {
                MessageBox.Show("Ingrese la ubicación a buscar", "Datos de Casas", MessageBoxButton.OK, MessageBoxImage.Information);
                return null;
            }
        }
    }
}
