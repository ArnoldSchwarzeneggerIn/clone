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
                try
                {
                    if (Session["token"] != null) Response.Redirect("https://simuladortokenlogin.herokuapp.com/users/open?id=232&redirect=localhost:25597/Views/pruebajulian.aspx");
                    Cargar_instancias();
                    Cargar_cobertura();
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Datos no cargados',icon: 'icon-checkmark3', type: 'warning'});}); ", true);

                }

            }
        }

        protected void Cargar_instancias()
        {
            List<Instancia> model = JsonConvert.DeserializeObject<List<Instancia>>(ConsumirAppi.ConsumirGet(Rutas.Instancia, new RestRequest("ConsultarInstancia", Method.GET)).Content);
            Instanciaslista.DataSource = model;
            Instanciaslista.DataBind();
        }
        protected void Cargar_cobertura()
        {
            List<Cobertura> model = JsonConvert.DeserializeObject<List<Cobertura>>(ConsumirAppi.ConsumirGet(Rutas.Cobertura, new RestRequest("ConsultarCobertura", Method.GET)).Content);
            CoberturaIns.DataSource = model;
            CoberturaIns.DataTextField = "nombrecobertura";
            CoberturaIns.DataValueField = "idCobertura";
            CoberturaIns.DataBind();
            CoberturaIns.Items.Insert(0, new ListItem("Seleccione", ""));
        }
 
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            foreach (RepeaterItem item in Instanciaslista.Items)
            {
                LinkButton link = (LinkButton)item.FindControl("Agregarcargo");
                if (link.CommandArgument == e.CommandArgument.ToString())
                {
                    Agregar_Modif.CommandArgument = e.CommandArgument.ToString();
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

        protected void Agregar_Inst_Click(object sender, EventArgs e)
        {
            var name = ((Button)sender).CommandName;
      
            try
            {
                switch (name.ToString())
                {
                case "Insertar":
                        var Inst = new Instancia() { IdCobertura = CoberturaIns.SelectedIndex.ToString(), NombreInstancia = NombreIns.Value };
                        var REsponse = ConsumirAppi.ConsumirPost(Rutas.Instancia, new RestRequest("InsertarInstancia", Method.GET), Inst);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
                        break;
                case "Modificar":
                        var Ins = new Instancia() { IdInstancia = ((Button)sender).CommandArgument,
                            IdCobertura=CoberturaIns.Text,
                            NombreInstancia=NombreIns.Value,
                            EstadoInstancia=InsEstadi.SelectedIndex.ToString()
                        };
                        var Response = ConsumirAppi.ConsumirPost(Rutas.Instancia, new RestRequest("ModificarInstancia", Method.POST), Ins);
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Registro modificado',icon: 'icon-checkmark3', type: 'success'});}); ", true);
                        ((Button)sender).CommandName = "Insertar";
                        break; 
                 }
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                CoberturaIns.SelectedIndex = 0;
                Ins.Value = "";
            }



            CoberturaIns.SelectedIndex = 0;
            Ins.Value = "";
        }

        protected void EditarInstancia_Command(object sender, CommandEventArgs e)
        {
            foreach (RepeaterItem item in Instanciaslista.Items)
            {
                LinkButton link = (LinkButton)item.FindControl("Agregarcargo");
                if (link.CommandArgument == e.CommandArgument.ToString())
                {

                    Agregar_Inst.CommandArgument = e.CommandArgument.ToString();
                    Agregar_Inst.CommandName = "Modificar";
                    Label labe =(Label) item.FindControl("Label1");
                    NombreIns.Value = labe.Text;
                    labe = (Label)item.FindControl("Cobertura");
                    CoberturaIns.ClearSelection();
                    CoberturaIns.Items.FindByText(labe.Text).Selected = true;
                    labe = (Label)item.FindControl("Estado");
                    InsEstadi.ClearSelection();
                    InsEstadi.Items.FindByText(labe.Text).Selected = true;

               
                }
            }
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal('Agregar_instancia');", true);
        }

        protected void Agregar_Modif_Command(object sender, CommandEventArgs e)
        {
            var insd = new InstanciaDetalle()
            {
                NombreInstanciadetalle = Ins.Value,
                TipoDeElector = TipoE.SelectedValue,
                VotacionInstanciadetalle = TipoV.SelectedValue,
                CupoInstanciadetalle = Cupos.SelectedValue,
                PeriodoInstranciadetalle = Perido.SelectedValue,
                IdInstancia = e.CommandArgument.ToString()
            };
            switch (e.CommandName)
            {
                case "Insertar":
                   var response = ConsumirAppi.ConsumirPost(Rutas.InstaciaDetalle, new RestRequest("insertarInstanciaDetalle", Method.POST), insd);
                break;
                case "Modificar":
                    var respose = ConsumirAppi.ConsumirPost(Rutas.InstaciaDetalle, new RestRequest("", Method.POST), insd);
                break;
            }
        }
    }
}