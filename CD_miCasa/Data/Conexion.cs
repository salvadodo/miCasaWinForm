using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD_miCasa.Data
{
    public class Conexion
    {
        public static string cadCon = ConfigurationManager.ConnectionStrings["conBDmiCasa4"].ConnectionString;
        //public static string cadCon = "data source=DESKTOP-7NJ0RL5;initial catalog=miCasa4;integrated security=True";
    }
}
