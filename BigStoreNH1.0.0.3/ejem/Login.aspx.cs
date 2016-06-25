using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        
    }
    protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
    {
        string Usuario, Password;
        Usuario = LoginUser.UserName;
        Password = LoginUser.Password;

        ServNegocio.WebServiceSoapClient Servicio;
        Servicio = new ServNegocio.WebServiceSoapClient();
        bool val = Servicio.LoginCliente(Usuario, Password);
        if (val)
        {
            DataSet dt = Servicio.BuscarCliente(Usuario);
            Session["CodCliente"] = dt.Tables[0].Rows[0]["CodCliente"].ToString();
            FormsAuthentication.RedirectFromLoginPage(Usuario, false);
            e.Authenticated = true;
        }
        else
        {
            e.Authenticated = false;
            LoginUser.FailureText = "Error Login";
        }
    }
    protected void RememberMe_CheckedChanged(object sender, EventArgs e)
    {

    }
}