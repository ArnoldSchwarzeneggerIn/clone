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



namespace Prueba.Views
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ( Session["Token"]!=null)
                {
                    scope("public_profile");
                }
                else
                {
                    Session["Code"] = Request.QueryString["code"].ToString();
                    Autenticacion();
                }
               
            }
            catch (Exception ex)
            {
                Response.Redirect("Loggin.aspx");
            }
        }
        protected void Autenticacion()
        {
            JObject datos = new JObject();
            datos.Add("grant_type", "authorization_code");
            datos.Add("code", Session["code"].ToString());
            datos.Add("redirect_uri", "http://191.102.85.226/electoral/views/index.aspx");
            datos.Add("client_id", "503998150027");
            datos.Add("client_secret", "xlo1nmj9e5pldnq7g89rzdvw8q7r4g");
            datos.Add("state", "cyz");
            var respose = ConsumirAppi.Autenticacion(Rutas.Autenticacion, new RestRequest("oauth2/authorize.asmx/token", Method.POST), datos) ;
            JToken Tokens = JsonConvert.DeserializeObject(respose);
            Session["Token"] = (string)Tokens.SelectToken("access_token");
            Session["Refresh_tokem"] = (string)Tokens.SelectToken("refresh_token");
            JArray scope = JArray.Parse(Tokens.SelectToken("scope").ToString());
            string a = scope[0]["FOTO"].ToString();
            imagen_Perfil.Attributes.Add("src", scope[0]["FOTO"].ToString());
            Imagen_perfil2.Attributes.Add("src", scope[0]["FOTO"].ToString());
            Nombre2.Text = scope[0]["NOMBRES"].ToString();
            Nombre1.Text = scope[0]["NOMBRES"].ToString()+ " "+ scope[0]["APELLIDOS"].ToString();
            Ubicacion.Text = scope[0]["MUNICIPIO"].ToString() + "-" + scope[0]["DEPARTAMENTO"].ToString();
        }
        protected void scope(string scope)
        {
            JObject datos = new JObject();
            datos.Add("access_token", Session["Token"].ToString());
            datos.Add("scope", scope);
            var respose = ConsumirAppi.Autenticacion(Rutas.Autenticacion, new RestRequest("oauth2/resource.asmx/scope", Method.POST), datos);
            JToken Tokens = JsonConvert.DeserializeObject(respose);
            imagen_Perfil.Attributes.Add("src", Tokens.SelectToken("FOTO").ToString());
            Imagen_perfil2.Attributes.Add("src", Tokens.SelectToken("FOTO").ToString());
            Nombre2.Text = Tokens.SelectToken("NOMBRES").ToString();
            Nombre1.Text = Tokens.SelectToken("NOMBRES").ToString() + " " + Tokens.SelectToken("APELLIDOS").ToString();
            Ubicacion.Text = Tokens.SelectToken("MUNICIPIO").ToString() + "-" + Tokens.SelectToken("DEPARTAMENTO").ToString();
        }

    }
}