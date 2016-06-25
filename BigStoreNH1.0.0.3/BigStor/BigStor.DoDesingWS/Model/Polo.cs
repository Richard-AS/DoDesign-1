using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigStore.DoDesignWS.Model
{
    public class Polo
    {
        public int IdPolo{ get; set; }
        public Design Design { get; set; }
        public Color Color { get; set; }
        public string Talla  { get; set; }
        public double  Precio { get; set; }
    }
}