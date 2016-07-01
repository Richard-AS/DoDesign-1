using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DoDesign.Service.Dominio
{
    [DataContract]
    public class Pago
    {
        [DataMember]
        public int IdPago { get; set; }
        [DataMember]
        public string Tipo { get; set; }
    }
}