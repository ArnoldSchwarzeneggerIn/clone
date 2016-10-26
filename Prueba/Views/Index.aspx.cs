using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prueba.Models;
using RestSharp;


namespace Prueba.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //Session["Token"] = Request.QueryString["code"].ToString();
                Autenticacion();
                //Token.Text = Session["Token"].ToString();
                // ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: Token asignado '"+Token.Text+"',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
            }
            catch (Exception ex)
            {
                //  Token.Text = "Token no valido";
            }
        }

        protected void Autenticacion()
        {
            var datos=new {grant_type = "authorization_code", code = "94u1e06a1516495298", redirect_uri = "http=//191.102.85.226/electoral/views/index.aspx", client_id = "503998150027", client_secret = "xlo1nmj9e5pldnq7g89rzdvw8q7r4g", state = "cyz" };

          var respose = ConsumirAppi.Autenticacion(Rutas.Autenticacion, new RestRequest("oauth2/authorize.asmx/token", Method.POST),datos );
        }
    }
}