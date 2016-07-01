using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DoDesign.Service.Dominio
{
    [DataContract]
    public class Design
    {
        [DataMember]
        public int IdDesign{ get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public string Descripcion { get; set; }
    }
}