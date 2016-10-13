using Newtonsoft.Json;
using Prueba.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.views
{
    public partial class Instancias : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["token"] != null) Response.Redirect("https://simuladortokenlogin.herokuapp.com/users/open?id=232&redirect=localhost:25597/Views/pruebajulian.aspx");
                Cargar_instancias();
              //  Cargar_cobertura();
            }
        }

        protected void Cargar_instancias()
        {
            List<Instancia> model = JsonConvert.DeserializeObject<List<Instancia>>(ConsumirAppi.ConsumirGet(Rutas.Instancia, new RestRequest("ConsultarInstancia", Method.GET)).Content);
            Instanciaslista.DataSource = model;
            Instanciaslista.DataBind();
           // NumeroR.Text = model.Count.ToString();
        }
        protected void Cargar_cobertura()
        {
            List<Cobertura> model = JsonConvert.DeserializeObject<List<Cobertura>>(ConsumirAppi.ConsumirGet(Rutas.Cobertura, new RestRequest("ConsultarCobertura", Method.GET)).Content);
        /*    Estado.DataSource = model;
            Estado.DataTextField = "nombrecobertura";
            Estado.DataValueField = "idCobertura";
            Estado.DataBind();
            Estado.Items.Insert(0, new ListItem("Seleccione", ""));*/
        }
        protected void Agregar()
        {
           /* try
            {
                Instancia Inst = new Instancia() { IdCobertura = Estado.SelectedIndex.ToString(), NombreInstancia = Ins.Value };
                var REsponse = ConsumirAppi.ConsumirPost(Rutas.Instancia, new RestRequest("InsertarInstancia", Method.GET), Inst);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
            }
            catch (Exception e)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                Estado.SelectedIndex = 0;
                Ins.Value = "";
            }
            */

    }

    protected void Button1_Click(object sender, EventArgs e)
        {
            Agregar();
            // Estado.SelectedIndex = 0;
            Ins.Value = "";
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            foreach (RepeaterItem item in Instanciaslista.Items)
            {
                LinkButton link = (LinkButton)item.FindControl("Agregarcargo");
                if (link.CommandArgument == e.CommandArgument.ToString())
                {
                    Button1.CommandArgument = e.CommandArgument.ToString();
                    break;
                }
            }
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "Pop", "openModal('modal_form_vertical');", true);
        }

        protected void Instanciaslista_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            var inst =(Instancia)e.Item.DataItem ;
            var instDetall = new InstanciaDetalle() { IdInstancia = inst.IdInstancia };
            Repeater Repeate = (Repeater)e.Item.FindControl("InstanCargos");
            List<InstanciaDetalle> detall = JsonConvert.DeserializeObject<List<InstanciaDetalle>>(ConsumirAppi.ConsumirPost(Rutas.InstaciaDetalle, new RestRequest("ConsultarCargosInstancia", Method.POST), instDetall).Content);
            Repeate.DataSource = detall;
            Repeate.DataBind();
        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            var insd = new InstanciaDetalle() {NombreInstanciadetalle=Ins.Value,
                TipoDeElector=TipoE.SelectedValue,
                VotacionInstanciadetalle= TipoV.SelectedValue,
                CupoInstanciadetalle=Cupos.SelectedValue,
                PeriodoInstranciadetalle=Perido.SelectedValue,
                IdInstancia=e.CommandArgument.ToString()
            };
            var response = ConsumirAppi.ConsumirPost(Rutas.InstaciaDetalle,new RestRequest("",Method.POST),insd);
        }
    }
}