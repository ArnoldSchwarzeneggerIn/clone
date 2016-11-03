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
    public partial class instanciaDetalle : System.Web.UI.Page
    {
        private Instancia Inst;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Token"]==null)
                {
                    Response.Redirect("Loggin.aspx");
                }
                getInstancia();
                scope("public_profile");
            }
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
        protected void getInstancia()
        {
            if (Session["InstanciaDetalle"] != null)
            {
                Inst = (Instancia)Session["InstanciaDetalle"];
                Session.Remove("InstanciaDetalle");
                nombreInstancia.Text = Inst.NombreInstancia;
                EstadoInstancia.Text = Inst.EstadoInstancia;
                cargosInstancia();

            }
            else
            {
                Response.Redirect("Instancias.aspx");
            }
        }

        protected void cargosInstancia()
        {
            try
            {
                var instDetall = new InstanciaDetalle() { IdInstancia = Inst.IdInstancia };
                List<InstanciaDetalle> detall = JsonConvert.DeserializeObject<List<InstanciaDetalle>>(ConsumirAppi.ConsumirPost(Rutas.InstaciaDetalle, new RestRequest("ConsultarCargosInstancia", Method.POST), instDetall).Content);
                cargosInsta.DataSource = detall;
                cargosInsta.DataBind();
            }
            catch(Exception ex)
            {

            }
           
        }
        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Loggin.aspx");
        }
    }
}