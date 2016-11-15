using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prueba.Models;
using Prueba.Utileria;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Views
{
    public partial class Causaderetiro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Session["Token"]==null)
                //{
                //    Response.Redirect("Loggin.aspx");
                //}
                CargarCausa();
                //scope("public_profile");
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
        protected void CargarCausa()
        {
            try
            {
                List<CausaRetiro> cober = JsonConvert.DeserializeObject<List<CausaRetiro>>(ConsumirAppi.ConsumirGet(Rutas.CausaRetiro, new RestRequest("ConsultarCausaRetiro", Method.GET)).Content);
                CausaRet.DataSource = cober;
                NumeroR.Text = cober.Count.ToString();
                CausaRet.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
            }


        }

        protected void AgregarCausa_Click(object sender, EventArgs e)
        {
            try
            {
                CausaRetiro Caus = new CausaRetiro() { NombreCausaretiro = Causar.Value };
                var Response = ConsumirAppi.ConsumirPost(Rutas.CausaRetiro, new RestRequest("InsertarCausaRetiro", Method.POST), Caus);
                CargarCausa();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);


            }
            catch (Exception Ex)
            {
                //Comentario wqweqweqweqwe



                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
            }
        }

        protected void CausaRet_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            CausaRet.EditIndex = e.NewEditIndex;
            Label Nombre = (Label) CausaRet.Items[e.NewEditIndex].FindControl("NombreCausa");
            Label Estado = (Label)CausaRet.Items[e.NewEditIndex].FindControl("EstadoCausa");
            CargarCausa();
            DropDownList EstadoDrop = (DropDownList)CausaRet.Items[e.NewEditIndex].FindControl("EstadoCausa");
            EstadoDrop.SelectedValue = Estado.Text;
            TextBox EditNombre = (TextBox)CausaRet.Items[e.NewEditIndex].FindControl("nombre");
            EditNombre.Text = Nombre.Text;
        }

        protected void CausaRet_ItemUpdating(object sender, ListViewUpdateEventArgs e)
        {
            var EstadoDrop = (DropDownList)CausaRet.Items[e.ItemIndex].FindControl("EstadoCausa");
            var EditNombre = (TextBox)CausaRet.Items[e.ItemIndex].FindControl("nombre");

            var CausaRe = new CausaRetiro()
            {
                IdCausaretiro = CausaRet.DataKeys[e.ItemIndex].Value.ToString(),
                NombreCausaretiro = EditNombre.Text,
                EstadoCausaretiro = EstadoDrop.SelectedValue
            };

            var Response = ConsumirAppi.ConsumirPost(
                Rutas.CausaRetiro, 
                new RestRequest("ModificarCausaRetiro", 
                Method.POST),
                CausaRe
                );
        }
    }
}