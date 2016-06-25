using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigStore.DoDesignWS.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            //return "Server=(local); database=DoDesign; user=sa; password=BaseDeDatos2015";
            return "Server=(local); database=DoDesign; integrated security=true";
        }
    }
}