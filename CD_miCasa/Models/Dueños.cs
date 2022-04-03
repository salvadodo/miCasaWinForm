using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_miCasa.Models
{
    public class Dueños
    {
        private int _idDueño;
        private string _Nombre;
        private int _Edad;
        private string _Direccion;

        public int IdDueño { get => _idDueño; set => _idDueño = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Edad { get => _Edad; set => _Edad = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }

        public Dueños()
        {
        }

        public Dueños(int idDueño, string nombre, int edad, string direccion)
        {
            IdDueño = idDueño;
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }
    }
}
