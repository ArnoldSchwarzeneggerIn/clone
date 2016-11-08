using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    public partial class VJurados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //if (Session["Token"] == null)
                //{
                //    Response.Redirect("Loggin.aspx");
                //}
                cargarJurados();
                //scope("public_profile");
            }
        }
        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Loggin.aspx");
        }
        protected void scope(string Scope)
        {
            var respose = ConsumirAppi.Scope(Rutas.Autenticacion, new RestRequest("oauth2/resource.asmx/scope", Method.POST), Scope);
            JToken Tokens = JsonConvert.DeserializeObject(respose);
            JArray scope = JArray.Parse(Tokens.SelectToken("description").ToString());
            imagen_Perfil.Attributes.Add("src", scope[0]["FOTO"].ToString());
            Imagen_perfil2.Attributes.Add("src", scope[0]["FOTO"].ToString());
            Nombre2.Text = scope[0]["NOMBRES"].ToString();
            Nombre1.Text = scope[0]["NOMBRES"].ToString() + " " + scope[0]["APELLIDOS"].ToString();
            Ubicacion.Text = scope[0]["MUNICIPIO"].ToString() + "-" + scope[0]["DEPARTAMENTO"].ToString();
        }


        protected void cargarJurados()
        {
            try
            {
                List<Persona> jura = JsonConvert.DeserializeObject<List<Persona>>(ConsumirAppi.ConsumirGet(Rutas.Persona, new RestRequest("Consultarpersona", Method.GET)).Content);
                JuradosView.DataSource = jura;
                NumeroR.Text = jura.Count.ToString();
                JuradosView.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
            }


        }
    }
}