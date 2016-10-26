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

namespace Prueba.Views
{
    public partial class ConvocatoriaDetalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              consultarConvocatoria();
            }
        }
        protected void consultarConvocatoria()
        {
           // Session["Convocatoria"].ToString();
            var Convo = new Convocatoria() { IdConvocatoria = 1.ToString()};
            List<Convocatoria> Convocatoria = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria,new RestRequest("ConsultarConvocatoriaPorNumero",Method.POST),Convo).Content);
            // organizar calendario
            string Eventos = "[{ title:'Inicio de inscripciones', start: '"+  Convert.ToDateTime(Convocatoria[0].Fechainicioinscripcion) +"', color: '#EF5350' }," +
                "{title:'Fin de inscripciones', start: '" + Convocatoria[0].Fechafininscripcion+ "', color: '#EF5350'},"+
                "{title:'Publicacion de candidatos habilitados', start: '" + Convocatoria[0].Fechapublicacionhabilitado+ "', color: '#EF5350'},"+
                "{title:'Publicacion de jurados', start: '" + Convocatoria[0].Fechapublicacionjurados + "', color: '#EF5350'},"+
                "{title:'Elecciones presenciales', start: '" + Convocatoria[0].Fechaeleccionespresenciales + "', color: '#EF5350'},"
                +"{title:'Elecciones distancia', start: '" + Convocatoria[0].Fechaeleccionesdistancia + "', color: '#EF5350'},"+
                "{title:'Publicacion resultados', start: '" + Convocatoria[0].Fechapublicacionresultados+ "', color: '#EF5350'}]";

            ScriptManager.RegisterStartupScript(this,this.GetType(),"Calenda", "Calendario('Clase'," + Eventos+",'"+String.Format("{0:yyyy-MM-dd}",DateTime.Now)+"');", true);
        }
    }
}