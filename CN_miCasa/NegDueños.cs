using CD_miCasa.Data;
using CD_miCasa.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CN_miCasa
{
    public class NegDueños
    {
        public static string DueñoSeleccionado { get; set; }

        public static DataTable mostrarDueños()
        {
            DueñosData dataDueño = new DueñosData();
            return dataDueño.registrosDueños();
        }
        public static DueñosMod selectDueño(string idDueño)
        {
            DueñosData dataDueño = new DueñosData();
            DueñosMod newDueñosMod = new DueñosMod();
            Dueños newDueño= dataDueño.selectDueño(Convert.ToInt32(idDueño));
            newDueñosMod.IdDueño = newDueño.IdDueño;
            newDueñosMod.Nombre = newDueño.Nombre;
            newDueñosMod.Edad = newDueño.Edad;
            newDueñosMod.Direccion = newDueño.Direccion;
            return newDueñosMod;
            //DueñoSeleccionado = Convert.ToString(newDueño.IdDueño);
        }
        public static void insertarDueño(string nombre, string edad, string direccion)
        {
            if(nombre !="" && edad != "" && direccion != "")
            {
                Dueños newDueño = new Dueños();
                DueñosData dataDueño = new DueñosData();
                newDueño.Nombre = nombre;
                newDueño.Edad = Convert.ToInt32(edad);
                newDueño.Direccion = direccion;
                dataDueño.insertarDueños(newDueño);
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Datos de Dueños", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public static void editarDueños(string idDueño, string nombre, string edad, string direccion)
        {
            if(nombre!="" && edad !="" && direccion != "")
            {
                Dueños newDueño = new Dueños();
                DueñosData dataDueño = new DueñosData();
                newDueño.IdDueño = Convert.ToInt32(idDueño);
                newDueño.Nombre = nombre;
                newDueño.Edad = Convert.ToInt32(edad);
                newDueño.Direccion = direccion;
                dataDueño.modificarDueño(newDueño);
            }
            else
            {
                MessageBox.Show("Seleccione la fila a editar", "Datos de Dueños", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        public static void eliminarDueños(string idDueño)
        {
            if (idDueño != "")
            {
                //Dueños newDueño = new Dueños();
                DueñosData dataDueño = new DueñosData();
                //newDueño.IdDueño = Convert.ToInt32(idDueño);
                dataDueño.eliminarDueño(Convert.ToInt32(idDueño));
            }
            else
            {
                MessageBox.Show("Seleccione la fila a eliminar", "Datos de Dueños", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        public static DataTable buscarDireccion(string direccion)
        {
            if (direccion != "")
            {
                //Dueños newDueño = new Dueños();
                DueñosData dataDueño = new DueñosData();
                //newDueño.Direccion = direccion;
                return dataDueño.buscarDireccionDueños(direccion);
            }
            else
            {
                MessageBox.Show("Ingrese la dirección a buscar", "Datos de Dueños", MessageBoxButton.OK, MessageBoxImage.Information);
                return null;
            }
        }
    }
}
