using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prueba.Models;
using Newtonsoft.Json;
using Prueba.Utileria;
using RestSharp;

namespace Prueba.Views
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Convocatoria> Convocatoria = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvtE", Method.POST), new Convocatoria { Estado = "BORRADOR" }).Content);
            ListView1.DataSource = Convocatoria;
            ListView1.DataBind();
        
    }

        protected void CCnvtE(Convocatoria c, ListView l)
        {
            try
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alerta", "Alerta('Registro','El registro se ha guardado satisfactoriamente','icon-check2','success','true');", true);

                List<Convocatoria> Convocatoria = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvtE", Method.POST), c).Content);
                l.DataSource = Convocatoria;
                l.DataBind();
            }
            catch (Exception Ex)
            {
                throw new Exception("Servicio web fuera de servicio, porfavor intente mas tarde", Ex);
            }
        }

    }
}