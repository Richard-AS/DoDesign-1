using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigStore.DoDesignWS.Model
{
    public class TLogin
    {
        public int IdTLogin { get; set; }
        public string  NombreUsuario { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }
    }
}