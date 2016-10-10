using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Prueba.Models;
using Newtonsoft.Json;

namespace Prueba.Views
{
    public partial class VConvocatoria : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ConsultarConvocatoria();
            }
        }
        protected void ConsultarConvocatoria()
        {
            try
            {

                List<Convocatoria> Convocatoria = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirGet(Rutas.Convocatoria, new RestRequest("ConsultarConvocatoria", Method.GET)).Content);
                Convocatoria_tabla.DataSource =Convocatoria;
                Convocatoria_tabla.DataBind();
            }
            catch (Exception Ex)
            {

            }
        }


        protected void Agregar_Click(object sender, EventArgs e)
        {
            try
            {    
              /*  var Conv = new Convocatoria(Numero.Value,Observacion.Value, Convert.ToDateTime(FechaEdis.Value).ToString("dd/MM/yyy"),
                    Convert.ToDateTime(FechaFin.Value).ToString("dd/MM/yyy"),
                    Convert.ToDateTime(fechaCandidatos.Value).ToString("dd/MM/yyy"),
                    Convert.ToDateTime(Fechajuradoa.Value).ToString("dd/MM/yyy"),
                    Convert.ToDateTime(FechaEdis.Value).ToString("dd/MM/yyy"),
                    Convert.ToDateTime(Fecharesulta.Value).ToString("dd/MM/yyy")
                    );*/
                
                Numero.Value = "";
                Observacion.Value = "";
                FechaEdis.Value = "";
                FechaFin.Value = "";
                fechaCandidatos.Value = "";
                Fechajuradoa.Value = "";
                FechaE.Value = "";
                FechaEdis.Value = "";
                Fecharesulta.Value = "";

              //  var Response = ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("InsertarConvocatoria", Method.POST), Conv);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','" + "Registro Exitoso" + "');", true);
            }
            catch (Exception Ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','" + "No ha sido registrado" + "');", true);
            }
        }

        protected void Convocatoria_tabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Convocatoria_tabla.PageIndex = e.NewPageIndex;
            ConsultarConvocatoria();
        }
    }
}