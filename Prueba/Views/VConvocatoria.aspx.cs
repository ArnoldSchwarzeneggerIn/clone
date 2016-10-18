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
                 ListaConvocatoria.DataSource =Convocatoria;
                ListaConvocatoria.DataBind();
            }
            catch (Exception Ex)
            {

            }
        }


        protected void Agregar_Click(object sender, EventArgs e)
        {
            try
            {
               var Conv = new Convocatoria() {TituloCovocatoria= Numero.Value,
                   DescripcionConvocatoria =Observacion.Value,
                   Fechainicioinscripcion =  Convert.ToDateTime(Fechai.Value).ToString("dd/MM/yyy"),
                   Fechafininscripcion =Convert.ToDateTime(FechaFin.Value).ToString("dd/MM/yyy"),
                   Fechapublicacionhabilitado =Convert.ToDateTime(fechaCandidatos.Value).ToString("dd/MM/yyy"),
                   Fechapublicacionjurados=  Convert.ToDateTime(Fechajuradoa.Value).ToString("dd/MM/yyy"),
                   Fechaeleccionesdistancia = Convert.ToDateTime(FechaEdis.Value).ToString("dd/MM/yyy"),
                   Fechaeleccionespresenciales = Convert.ToDateTime(FechaE.Value).ToString("dd/MM/yyy"),
                   Fechapublicacionresultados= Convert.ToDateTime(Fecharesulta.Value).ToString("dd/MM/yyy")
               };

                Numero.Value = "";
                Observacion.Value = "";
                FechaEdis.Value = "";
                FechaFin.Value = "";
                fechaCandidatos.Value = "";
                Fechajuradoa.Value = "";
                FechaE.Value = "";
                FechaEdis.Value = "";
                Fecharesulta.Value = "";
                var Response = ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("InsertarConvocatoria", Method.POST), Conv);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
            }
            catch (Exception Ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
            }
        }

        protected void Convocatoria_tabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          
        }
    }
}