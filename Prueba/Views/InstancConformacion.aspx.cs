using Newtonsoft.Json;
using Prueba.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Views
{
    public partial class InstancConformacion : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarConform();
            }

       }

        protected void CargarConform()
        {
            try
            {
                List<Cobertura> cober = JsonConvert.DeserializeObject<List<Cobertura>>(ConsumirAppi.ConsumirGet(Rutas.Cobertura, new RestRequest("ConsultarCobertura", Method.GET)).Content);
                Instancia_tabla.DataSource = cober;
                Instancia_tabla.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','" + "No se cargaron datos" + "');", true);
            }

        }
    }
}