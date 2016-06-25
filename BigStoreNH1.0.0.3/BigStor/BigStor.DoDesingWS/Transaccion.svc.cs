using BigStore.DoDesignWS.Data;
using BigStore.DoDesignWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BigStore.DoDesignWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Transaccion" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Transaccion.svc o Transaccion.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Transaccion : ITransaccion
    {
        #region . DAO .
        //PedidoDAO
        private PedidoDAO objPedido = null;
        private PedidoDAO ObjPedido
        {
            get
            {
                if (objPedido == null)
                    objPedido = new PedidoDAO();
                return objPedido;
            }
        }
        //ClienteDAO
        private ClienteDAO objCliente = null;
        private ClienteDAO ObjCliente
        {
            get
            {
                if (objCliente == null)
                    objCliente = new ClienteDAO();
                return objCliente;
            }
        }
        //ColorDAO
        private ColorDAO objColor = null;
        private ColorDAO ObjColor
        {
            get
            {
                if (objColor == null)
                    objColor = new ColorDAO();
                return objColor;
            }
        }
        //DesignDAO
        private DesignDAO objDesign = null;
        private DesignDAO ObjDesign
        {
            get
            {
                if (objDesign == null)
                    objDesign = new DesignDAO();
                return objDesign;
            }
        }
        //DetallePedido
        private DetallePedidoDAO objDetallePedido = null;
        private DetallePedidoDAO ObjDetallePedido
        {
            get
            {
                if (objDetallePedido == null)
                    objDetallePedido = new DetallePedidoDAO();
                return objDetallePedido;
            }
        }
        //PagoDAO 
        private PagoDAO objPago = null;
        private PagoDAO ObjPago
        {
            get
            {
                if (objPago == null)
                    objPago = new PagoDAO();
                return objPago;
            }
        }
        //PoloDAO
        private PoloDAO objPolo = null;
        private PoloDAO ObjPolo
        {
            get
            {
                if (objPolo == null)
                    objPolo = new PoloDAO();
                return objPolo;
            }
        }
        //TLoginDAO
        private TLoginDAO objTLogin = null;
        private TLoginDAO ObjTLogin
        {
            get
            {
                if (objTLogin == null)
                    objTLogin = new TLoginDAO();
                return objTLogin;
            }
        }
        #endregion

        #region .LOGUEOS.
        public bool LoginCliente(string NombreUsuario, string Contrasenia)
        {
            TLogin login = new TLogin();
            login.NombreUsuario = NombreUsuario;
            login.Contrasenia = Contrasenia;

            bool logueado=false;
            return logueado;
            //return TLoginDAO.LoginCli(login.NombreUsuario,login.Contrasenia); 
        }
        #endregion

        #region . PEDIDO .
        public Pedido CrearPedido(Pedido pedido)
        {
            return ObjPedido.Crear(pedido);
        }

        public IList<Pedido> ListarPedido()
        {
            return ObjPedido.ListarTodos();
        }
        public Pedido ModificarPedido(Pedido pedido)
        {
            return ObjPedido.Modificar(pedido);
        }

        public Pedido ObtenerPedido(int IdPedido)
        {
            return ObjPedido.Obtener(IdPedido);
        }
        #endregion

        #region . CLIENTE .
        public Cliente obtenerCliente(string NombreUsuario)
        {
            Cliente cliente= new Cliente();
            return cliente;
        }

        public Cliente CrearCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public IList<Cliente> ListarCliente()
        {
            throw new NotImplementedException();
        }

        public Cliente ModificarPedido(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Cliente ObtenerCliente(int IdCliente)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region . COLOR .
        public Color CrearColor(Color color)
        {
            throw new NotImplementedException();
        }

        public IList<Color> ListarColor()
        {
            throw new NotImplementedException();
        }

        public Color ModificarColor(Color color)
        {
            throw new NotImplementedException();
        }

        public Color ObtenerColor(int IdColor)
        {
            throw new NotImplementedException();
        }
        #endregion 

        #region . DESIGN . 
        public Design CrearDesign(Design design)
        {
            throw new NotImplementedException();
        }

        public IList<Design> ListarDesign()
        {
            throw new NotImplementedException();
        }

        public Design ModificarDesign(Design design)
        {
            throw new NotImplementedException();
        }

        public Design ObtenerDesign(int IdDesign)
        {
            throw new NotImplementedException();
        }
        #endregion 

        #region . DETALLEPEDIDO . 
        public DetallePedido CrearDetallePedido(DetallePedido detallePedido)
        {
            throw new NotImplementedException();
        }

        public IList<DetallePedido> ListarDetallePedido()
        {
            throw new NotImplementedException();
        }

        public DetallePedido ModificarDetallePedido(DetallePedido detallePedido)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerDetallePedido(int IdDetallePedido)
        {
            throw new NotImplementedException();
        }
        #endregion 

        #region . PAGO .

        public Pedido CrearPago(Pago pago)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> ListarPago()
        {
            throw new NotImplementedException();
        }

        public Pedido ModificarPago(Pago pago)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerPago(int IdPago)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region . POLO . 
        public Pedido CrearPolo(Polo polo)
        {
            throw new NotImplementedException();
        }

        public IList<Pedido> ListarPolo()
        {
            throw new NotImplementedException();
        }

        public Pedido ModificarDesign(Polo polo)
        {
            throw new NotImplementedException();
        }

        public Pedido ObtenerPolo(int IdPolo)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region . TLOGION .

        public TLogin CrearTLogin(TLogin tlogin)
        {
            return ObjTLogin.Crear(tlogin);
        }

        public IList<TLogin> ListarTLogin()
        {
            throw new NotImplementedException();
        }

        public TLogin ModificarTlogin(TLogin tlogin)
        {
            throw new NotImplementedException();
        }

        public TLogin ObtenerTLogin(int IdTLogin)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
