using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class Cliente : Models.mdl_Cliente
    {
        private cDatos oDatos = new cDatosSQL();
        public byte Error { set; get; }
        public string Mensaje { set; get; }
        public bool Login()
        {
            DataRow dSet = oDatos.TraerDataRow("uspAutenticarCliente", Usuario, Contrasena);
            Error = Convert.ToByte(dSet["CodError"]);
            Mensaje = Convert.ToString(dSet["Mensaje"]);
            if (Error == 0x00)
                return true;
            return false;
        }

        public bool VerificarEmail()
        {
            DataRow dSet = oDatos.TraerDataRow("uspVerificarEmail", Email);
            Error = Convert.ToByte(dSet["CodError"]);
            Mensaje = Convert.ToString(dSet["Mensaje"]);
            if (Error == 0x00)
                return true;
            return false;
        }

        public bool CambiarContrasena(string Contra)
        {
            DataRow dSet = oDatos.TraerDataRow("uspCambiarContrasenaCliente", Email, Contrasena, Contra);
            Error = Convert.ToByte(dSet["CodError"]);
            Mensaje = Convert.ToString(dSet["Mensaje"]);
            if (Error == 0x00)
                return true;
            return false;
        }

        public DataTable Listar()
        {
            return oDatos.TraerDataTable("uspListarCliente");
        }

        public DataTable ListarDatos()
        {
            return oDatos.TraerDataTable("uspListarDatosCliente");
        }

        public bool Agregar()
        {
            DataRow dSet = oDatos.TraerDataRow("uspAgregarCliente", CodCliente, Nombres, Apellidos, Sexo, TipoDocumento, NroDocumento, Email, Provincia, Ciudad, Distrito, Direccion, Usuario, Contrasena, RazonSocial, RUC, FechaNac, EstadoCivil, Ocupacion, Telefono, CodPais);
            Error = Convert.ToByte(dSet["CodError"]);
            Mensaje = Convert.ToString(dSet["Mensaje"]);
            if (Error == 0x00)
                return true;
            return false;
        }

        public bool Midificar()
        {
            DataRow dSet = oDatos.TraerDataRow("uspModificarCliente", Nombres,
                                                                        Apellidos,
                                                                        Sexo,
                                                                        TipoDocumento,
                                                                        NroDocumento,
                                                                        Email,
                                                                        Provincia,
                                                                        Ciudad,
                                                                        Distrito,
                                                                        Direccion,
                                                                        RazonSocial,
                                                                        RUC,
                                                                        FechaNac,
                                                                        EstadoCivil,
                                                                        Ocupacion,
                                                                        Telefono,
                                                                        CodPais);
            Error = Convert.ToByte(dSet["CodError"]);
            Mensaje = Convert.ToString(dSet["Mensaje"]);
            if (Error == 0x00)
                return true;
            return false;
        }

        public DataSet BuscarPorEmail()
        {
            return oDatos.TraerDataSet("usp_BuscarClienteEmail", Email);
        }
    }
}
