using Negocios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }


    [WebMethod(Description = "Login Cliente")]
    public bool LoginCliente(string usuario, string password)
    {
        Cliente cl = new Cliente();
        cl.Usuario = usuario;
        cl.Contrasena = password;
        return cl.Login();
    }

    [WebMethod(Description = "Listar Cliente")]
    public DataTable ListarCliente()
    {
        return new Cliente().Listar();
    }

    [WebMethod(Description = "Cambiar Password Cliente")]
    public bool CambiarPassword(string email, string actual, string nueva)
    {
        return new Cliente { Email = email, Contrasena = actual }.CambiarContrasena(nueva);
    }

    [WebMethod(Description = "Buscar Cliente Email")]
    public DataSet BuscarCliente(string email)
    {
        return new Cliente { Email = email }.BuscarPorEmail();
    }

    [WebMethod(Description = "Agregar Cliente")]
    public bool AgregarCliente(string Nombres,
        string Apellidos,
        string Sexo,
        string TipoDocumento,
        string NroDocumento,
        string Email,
        string Provincia,
        string Ciudad,
        string Distrito,
        string Direccion,
        string Usuario,
        string Contrasena,
        string RazonSocial,
        string RUC,
        DateTime FechaNac,
        string EstadoCivil,
        string Ocupacion,
        string Telefono,
        string CodPais)
    {
        Cliente cl = new Cliente();
        cl.Nombres = Nombres;
        cl.Apellidos = Apellidos;
        cl.Sexo = Sexo;
        cl.TipoDocumento = TipoDocumento;
        cl.NroDocumento = NroDocumento;
        cl.Email = Email;
        cl.Provincia = Provincia;
        cl.Ciudad = Ciudad;
        cl.Distrito = Distrito;
        cl.Direccion = Direccion;
        cl.Usuario = Usuario;
        cl.Contrasena = Contrasena;
        cl.RazonSocial = RazonSocial;
        cl.RUC = RUC;
        cl.FechaNac = FechaNac;
        cl.EstadoCivil = EstadoCivil;
        cl.Ocupacion = Ocupacion;
        cl.Telefono = Telefono;
        cl.CodPais = CodPais;
        return cl.Agregar();
    }
    [WebMethod(Description = "Agregar Cliente Pasarela")]
    public bool AgregarClientePasarela(int CodCliente,
        string Nombres,
        string Apellidos,
        string Ciudad,
        string Provincia,
        string Distrito,
        string Sexo,
        string Estado,
        string TipoDocumento,
        string DNI)
    {
        ClientePasarela  clp = new ClientePasarela();
        clp.CodCliente = CodCliente;
        clp.Nombres = Nombres;
        clp.Apellidos = Apellidos;
        clp.Ciudad = Ciudad;
        clp.Provincia = Provincia;
        clp.Distrito = Distrito;
        clp.Sexo = Sexo;
        clp.Estado = Estado;
        clp.TipoDocumento = TipoDocumento;
        clp.DNI = DNI;
        return clp.AgregarPasarela();
    }

    [WebMethod(Description = "Modificar Cliente")]
    public bool ModificarCliente(
        string Nombres,
        string Apellidos,
        string Sexo,
        string TipoDocumento,
        string NroDocumento,
        string Email,
        string Provincia,
        string Ciudad,
        string Distrito,
        string Direccion,
        string RazonSocial,
        string RUC,
        DateTime FechaNac,
        string EstadoCivil,
        string Ocupacion,
        string Telefono,
        string CodPais)
    {
        Cliente cl = new Cliente();
        cl.Nombres = Nombres;
        cl.Apellidos = Apellidos;
        cl.Sexo = Sexo;
        cl.TipoDocumento = TipoDocumento;
        cl.NroDocumento = NroDocumento;
        cl.Email = Email;
        cl.Provincia = Provincia;
        cl.Ciudad = Ciudad;
        cl.Distrito = Distrito;
        cl.Direccion = Direccion;
        cl.RazonSocial = RazonSocial;
        cl.RUC = RUC;
        cl.FechaNac = FechaNac;
        cl.EstadoCivil = EstadoCivil;
        cl.Ocupacion = Ocupacion;
        cl.Telefono = Telefono;
        cl.CodPais = CodPais;
        return cl.Midificar();
    }

    [WebMethod(Description = "Validar Tarjeta")]
    public bool ValidarTarjeta(string _NroTarjeta, string _Contrasena)
    {
        return new TarjetaPasarela { NroCuenta = _NroTarjeta, Contrasena = _Contrasena }.Validar();
    }

    [WebMethod(Description = "Agregar DetalleCompra")]
    public bool AgregarDetalleCompra(string _CodCompra, string _CodProducto, int _Cantidad, double _Precio)
    {
        return new DetalleCompras { CodCompra = _CodCompra, CodProducto = _CodProducto, Cantidad = _Cantidad, Precio = _Precio }.Agregar();
    }

    [WebMethod(Description = "Buscar MovimientoPasarela")]
    public DataSet BuscarMovimientoPasarela(string _NroTarjeta)
    {
        return new MovimientoPasarela { NroTarjeta = _NroTarjeta }.BuscarPorTarjeta();
    }
}
