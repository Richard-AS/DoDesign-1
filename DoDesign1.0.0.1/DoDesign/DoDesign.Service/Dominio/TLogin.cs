using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace DoDesign.Service.Dominio
{
    [DataContract]
    public class TLogin
    {
        [DataMember]
        public int IdTLogin { get; set; }
        [DataMember]
        public string  NombreUsuario { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Contrasenia { get; set; }
    }
}