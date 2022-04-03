using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_miCasa.Models
{
    public class Casas
    {
        private int _idCasa;
        private string _tipodeCasa;
        private string _Ubicacion;
        private string _Descripcion;
        private int _Dueño;

        public int IdCasa { get => _idCasa; set => _idCasa = value; }
        public string TipodeCasa { get => _tipodeCasa; set => _tipodeCasa = value; }
        public string Ubicacion { get => _Ubicacion; set => _Ubicacion = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int Dueño { get => _Dueño; set => _Dueño = value; }

        public Casas()
        {
        }

        public Casas(int idCasa, string tipodeCasa, string ubicacion, string descripcion, int dueño)
        {
            IdCasa = idCasa;
            TipodeCasa = tipodeCasa;
            Ubicacion = ubicacion;
            Descripcion = descripcion;
            Dueño = dueño;
        }
    }
}
