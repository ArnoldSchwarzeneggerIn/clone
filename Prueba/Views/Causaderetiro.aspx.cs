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
    public partial class Causaderetiro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarCausa();
            }
        }

        protected void CargarCausa()
        {
            try
            {
                List<CausaRetiro> cober = JsonConvert.DeserializeObject<List<CausaRetiro>>(ConsumirAppi.ConsumirGet(Rutas.CausaRetiro, new RestRequest("ConsultarCausaRetiro", Method.GET)).Content);
                Causaretiro.DataSource = cober;
                NumeroR.Text = cober.Count.ToString();
                Causaretiro.DataBind();
            }
            catch (Exception ex)
            {
               // ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','" + "Datos no cargados" + "');", true);
            }
        

        }

        protected void AgregarCausa_Click(object sender, EventArgs e)
        {
            try
            {
                /*   CausaRetiro Caus = new CausaRetiro() { NombreCausaretiro = Causar.Value };
                   var Response = ConsumirAppi.ConsumirPost(Rutas.CausaRetiro, new RestRequest("InsertarCausaRetiro", Method.POST), Caus);
                   CargarCausa();*/

                //  ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);


            }
            catch (Exception Ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
            }
        }


    }
}