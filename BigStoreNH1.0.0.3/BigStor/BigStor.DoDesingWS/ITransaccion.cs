using BigStore.DoDesignWS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BigStore.DoDesignWS
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ITransaccion" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ITransaccion
    {
        #region .LOGUEOS.
        [OperationContract]
        bool LoginCliente(string NombreUsuario, string Contrasenia);
        #endregion

        #region . PEDIDO .
        [OperationContract]
        Pedido CrearPedido(Pedido pedido);
        [OperationContract]
        IList<Pedido> ListarPedido();
        [OperationContract]
        Pedido ModificarPedido(Pedido pedido);
        [OperationContract]
        Pedido ObtenerPedido(int IdPedido);
        #endregion
        #region . CLIENTE .
        [OperationContract]
        Cliente obtenerCliente(string NombreUsuario);
        [OperationContract]
        Cliente CrearCliente(Cliente cliente);
        [OperationContract]
        IList<Cliente> ListarCliente();
        [OperationContract]
        Cliente ModificarPedido(Cliente cliente);
        [OperationContract]
        Cliente ObtenerCliente(int IdCliente);
        #endregion

        #region . COLOR .
        [OperationContract]
        Color CrearColor(Color color);
        [OperationContract]
        IList<Color> ListarColor();
        [OperationContract]
        Color ModificarColor(Color color);
        [OperationContract]
        Color ObtenerColor(int IdColor);
        #endregion

        #region . DESIGN .
        
        [OperationContract]
        Design CrearDesign(Design design);
        [OperationContract]
        IList<Design> ListarDesign();
        [OperationContract]
        Design ModificarDesign(Design design);
        [OperationContract]
        Design ObtenerDesign(int IdDesign);
        #endregion

        #region . DETALLEPEDIDO .

        [OperationContract]
        DetallePedido CrearDetallePedido(DetallePedido detallePedido);
        [OperationContract]
        IList<DetallePedido> ListarDetallePedido();
        [OperationContract]
        DetallePedido ModificarDetallePedido(DetallePedido detallePedido);
        [OperationContract]
        DetallePedido ObtenerDetallePedido(int IdDetallePedido);
        #endregion

        #region . PAGO .

        [OperationContract]
        Pago CrearPago(Pago pago);
        [OperationContract]
        IList<Pago> ListarPago();
        [OperationContract]
        Pago ModificarPago(Pago pago);
        [OperationContract]
        Pago ObtenerPago(int IdPago);
        #endregion

        #region . POLO .

        [OperationContract]
        Polo CrearPolo(Polo polo);
        [OperationContract]
        IList<Polo> ListarPolo();
        [OperationContract]
        Polo ModificarDesign(Polo polo);
        [OperationContract]
        Polo ObtenerPolo(int IdPolo);
        #endregion

        #region . TLOGIN .

        [OperationContract]
        TLogin CrearTLogin(TLogin tlogin);
        [OperationContract]
        IList<TLogin> ListarTLogin();
        [OperationContract]
        TLogin ModificarTlogin(TLogin tlogin);
        [OperationContract]
        TLogin ObtenerTLogin(int IdTLogin);
        #endregion



    }
}
