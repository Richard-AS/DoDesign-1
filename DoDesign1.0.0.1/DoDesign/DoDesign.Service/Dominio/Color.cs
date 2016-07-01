using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoDesign.Service.Dominio
{
    [DataContract]
    public class Color
    {
        [DataMember]
        public int IdColor{ get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public bool Estado { get; set; }
    }
}