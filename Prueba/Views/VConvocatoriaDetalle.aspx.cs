using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using RestSharp;
using System.Globalization;
using Newtonsoft.Json.Linq;
using Prueba.Utileria;

namespace Prueba.Views
{
    public partial class VConvocatoriaDetalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Session["Token"]==null)
                //{
                //    Response.Redirect("Loggin.aspx");
                //}
                //scope("public_profile");

              consultarConvocatoria();
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

        protected void consultarConvocatoria()
        {
            // Session["Convocatoria"].ToString();
            var Convo = new Convocatoria() { IdConvocatoria = 1.ToString() };
            List<Convocatoria> Convocatoria = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("ConsultarConvocatoriaPorNumero", Method.POST), Convo).Content);
            // organizar calendario
            tituloconvo.Value = Convocatoria[0].TituloConvocatoria;
            finscripcionconvo.Value = Convocatoria[0].Fechainicioinscripcion;
            ffindeinscripcion.Value =Convocatoria[0].Fechafininscripcion;
            candidatoshconvo.Value = Convocatoria[0].Fechapublicacionhabilitado;
            juradosconvoca.Value = Convocatoria[0].Fechapublicacionjurados;
            resultadosconvo.Value = Convocatoria[0].Fechapublicacionresultados;
            epresenciaconvo.Value = Convocatoria[0].Fechaeleccionespresenciales;
            edistanciaconvo.Value = Convocatoria[0].Fechaeleccionesdistancia;
            observacionconvo.Value = Convocatoria[0].DescripcionConvocatoria;


            string Eventos = "[{ title:'Inicio de inscripciones', start: '"+  Convert.ToDateTime(Convocatoria[0].Fechainicioinscripcion) +"', color: '#EF5350' }," +
                "{title:'Fin de inscripciones', start: '" + Convocatoria[0].Fechafininscripcion+ "', color: '#EF5350'},"+
                "{title:'Publicacion de candidatos habilitados', start: '" + Convocatoria[0].Fechapublicacionhabilitado+ "', color: '#EF5350'},"+
                "{title:'Publicacion de jurados', start: '" + Convocatoria[0].Fechapublicacionjurados + "', color: '#EF5350'},"+
                "{title:'Elecciones presenciales', start: '" + Convocatoria[0].Fechaeleccionespresenciales + "', color: '#EF5350'},"
                +"{title:'Elecciones distancia', start: '" + Convocatoria[0].Fechaeleccionesdistancia + "', color: '#EF5350'},"+
                "{title:'Publicacion resultados', start: '" + Convocatoria[0].Fechapublicacionresultados+ "', color: '#EF5350'}]";

            //Cargar fechas en Calendario
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Calenda", "Calendario('Clase'," + Eventos + ",'" + String.Format("{0:yyyy-MM-dd}", DateTime.Now) + "');", true);
        }

        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Loggin.aspx");
        }
        protected void guardar_Click(object sender, EventArgs e)
        {

        }
    }
}