using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prueba.Models;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prueba.Utileria;

namespace Prueba.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //if ( Session["Token"]!=null)
                //{
                //  scope("public_profile");
                //}
                //else
                //{
                // Session["Code"] = Request.QueryString["code"].ToString();
                 Autenticacion();
                //}
            }
            catch (Exception ex)
            {
                Response.Redirect("Loggin.aspx");
            }
        }
        protected void Autenticacion()
        {
            var respose = ConsumirAppi.Autenticacion(Rutas.Autenticacion, new RestRequest("oauth2/authorize.asmx/token", Method.POST), Session["Code"].ToString()) ;
            Session.Remove("Code");
            JToken Tokens = JsonConvert.DeserializeObject(respose);
            Session["Token"] = (string)Tokens.SelectToken("access_token");
            Session["Refresh_tokem"] = (string)Tokens.SelectToken("refresh_token");
            JArray scope = JArray.Parse(Tokens.SelectToken("scope").ToString());
            
            imagen_Perfil.Attributes.Add("src", scope[0]["FOTO"].ToString());
            Imagen_perfil2.Attributes.Add("src", scope[0]["FOTO"].ToString());
            Nombre2.Text = scope[0]["NOMBRES"].ToString();
            Nombre1.Text = scope[0]["NOMBRES"].ToString()+ " "+ scope[0]["APELLIDOS"].ToString();
            Ubicacion.Text = scope[0]["MUNICIPIO"].ToString() + "-" + scope[0]["DEPARTAMENTO"].ToString();

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

        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Loggin.aspx");
        }
    }
}