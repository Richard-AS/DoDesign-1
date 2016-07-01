using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DoDesign.Service.Dominio
{
    
    public class Polo
    {
    
        public int IdPolo{ get; set; }
    
        public Design IdDesign { get; set; }
    
        public Color IdColor { get; set; }
    
        public string Talla  { get; set; }
    
        public double  Precio { get; set; }
    }
}