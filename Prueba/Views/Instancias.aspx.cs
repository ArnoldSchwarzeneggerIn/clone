using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                    //if (Session["token"] == null)
                    //{
                    //    Response.Redirect("Loggin.aspx");
                    //}
                    //scope("public_profile");
                    Cargar_instancias();
                    Cargar_cobertura(CoberturaIns);

                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Datos no cargados',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                }
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
        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Loggin.aspx");
        }


        protected void Cargar_instancias()
        {
            List<Instancia> model = JsonConvert.DeserializeObject<List<Instancia>>(ConsumirAppi.ConsumirGet(Rutas.Instancia, new RestRequest("ConsultarInstancia", Method.GET)).Content);
            Instancialista.DataSource = model;
            Instancialista.DataBind();
        }
        protected void Cargar_cobertura(DropDownList Listacober)
        {
            List<Cobertura> model = JsonConvert.DeserializeObject<List<Cobertura>>(ConsumirAppi.ConsumirGet(Rutas.Cobertura, new RestRequest("ConsultarCobertura", Method.GET)).Content);
            Listacober.DataSource = model;
            Listacober.DataTextField = "nombrecobertura";
            Listacober.DataValueField = "idCobertura";
            Listacober.DataBind();
            Listacober.Items.Insert(0, new ListItem("Seleccione", ""));
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
          /*  foreach (RepeaterItem item in Instanciaslista.Items)
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
            }*/
         //   ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal('Agregar_instancia');", true);
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
        protected void Instancialista_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            Instancialista.EditIndex = e.NewEditIndex;
            //Encontrando los elementos
            Label Estado = (Label) Instancialista.Items[e.NewEditIndex].FindControl("Estadolabel");
            Label cobertura = (Label)Instancialista.Items[e.NewEditIndex].FindControl("coberturaid");
            LinkButton Nombre = (LinkButton)Instancialista.Items[e.NewEditIndex].FindControl("LinkButton1");
            //Recargando elemento list
            Cargar_instancias();
            //Cargando valores y asignarlos en editables
            DropDownList drop = (DropDownList)Instancialista.Items[e.NewEditIndex].FindControl("EstadoInst");
            drop.SelectedValue = Estado.Text;
            drop = (DropDownList)Instancialista.Items[e.NewEditIndex].FindControl("COberItem");
            Cargar_cobertura(drop);
            drop.ClearSelection();
            drop.SelectedValue = drop.Items.FindByText(cobertura.Text).Value;
            TextBox Nombreeditable = (TextBox) Instancialista.Items[e.NewEditIndex].FindControl("nombre");
            Nombreeditable.Text = Nombre.Text;
        }
        protected void Instancialista_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            Instancialista.EditIndex = -1;
            Cargar_instancias();
        }
        protected void Instancialista_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {

            TextBox nombreInstancia = (TextBox) Instancialista.Items[e.ItemIndex].FindControl("nombre");
            DropDownList estadoInstancia = (DropDownList)Instancialista.Items[e.ItemIndex].FindControl("EstadoInst");
            DropDownList coberturaInstancia = (DropDownList)Instancialista.Items[e.ItemIndex].FindControl("COberItem");
            var Ins = new Instancia()
            {
                IdInstancia = Instancialista.DataKeys[e.ItemIndex].Values[0].ToString(),
                IdCobertura =coberturaInstancia.SelectedValue ,
                NombreInstancia = nombreInstancia.Text,
                EstadoInstancia = estadoInstancia.SelectedValue
            };
            var Response = ConsumirAppi.ConsumirPost(Rutas.Instancia, new RestRequest("ModificarInstancia", Method.POST), Ins);
            Instancialista.EditIndex = -1;
            Cargar_instancias();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Registro modificado',icon: 'icon-checkmark3', type: 'success'});}); ", true);
        }
        protected void Instancialista_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "ver":
                    Label Estado = (Label)e.Item.FindControl("Estadolabel");
                    Label cobertura = (Label)e.Item.FindControl("coberturaid");
                    LinkButton Nombre = (LinkButton)e.Item.FindControl("LinkButton1");
                    var Ins = new Instancia()
                    {
                        IdInstancia = e.CommandArgument.ToString(),
                        IdCobertura = cobertura.Text,
                        NombreInstancia = Nombre.Text,
                        EstadoInstancia = Estado.Text
                    };
                    Session["InstanciaDetalle"] = Ins;
                    Response.Redirect("instanciaDetalle.aspx");
                break;
            }
        }
    }
}