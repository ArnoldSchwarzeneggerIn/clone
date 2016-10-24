using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using RestSharp;

namespace Prueba.Views
{
    public partial class ConvocatoriaDetalle : System.Web.UI.Page
    {
        private Convocatoria conv;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                consultarConvocatoria();
            }
        }
        protected void consultarConvocatoria()
        {

            var Convo = new Convocatoria() { IdConvocatoria = Session["Convocatoria"].ToString() };
            conv = JsonConvert.DeserializeObject<Convocatoria>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria,new RestRequest("ConsultarConvocatoriaPorNumero",Method.POST),Convo).Content);


        }



    }
}