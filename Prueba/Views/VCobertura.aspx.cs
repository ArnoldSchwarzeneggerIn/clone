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
    public partial class VCobertura : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Session["Token"]==null)
                //{
                //    Response.Redirect("Loggin.aspx");
                //}
                Cargarcobertura();
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
        protected void Cargarcobertura()
        {
            try
            {
            List<Cobertura> cober = JsonConvert.DeserializeObject<List<Cobertura>>(ConsumirAppi.ConsumirGet(Rutas.Cobertura, new RestRequest("ConsultarCobertura", Method.GET)).Content);
            Cobertura_t.DataSource = cober;
            NumeroR.Text = cober.Count.ToString();
            Cobertura_t.DataBind();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Alerta", "Alerta();", true);

            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
            }

        }

        protected void AgregarCober_Click(object sender, EventArgs e)
        {
           
            try
            {
               var Cober = new Cobertura() { NombreCobertura = cober.Value};
               var Response = ConsumirAppi.ConsumirPost(Rutas.Cobertura,new RestRequest("InsertarCobertura", Method.POST),Cober);
               ScriptManager.RegisterStartupScript(this, this.GetType(), "Alerta", "Alerta('Registro','El registro se ha guardado satisfactoriamente','icon-check2','success','true');", true);

                //Cargarcobertura();
            }
            catch (Exception Ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Alerta", "Alerta('Algo va mal','Su registro no se ha almacenado','icon-cross3',warning','true');", true);
            }
        }

        protected void Cobertura_t_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
           Cobertura_t.EditIndex = -1;
            Cargarcobertura();
        }
        protected void Cobertura_t_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Cobertura_t.EditIndex = e.NewEditIndex;
            Label label = (Label)Cobertura_t.Rows[e.NewEditIndex].FindControl("Estadol");
            Cargarcobertura();
            DropDownList Seleccion = (DropDownList)Cobertura_t.Rows[e.NewEditIndex].FindControl("estado");
            Seleccion.SelectedValue=label.Text;
        }
        protected void Cobertura_t_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            TextBox t = new TextBox();
            var cobe = new Cobertura();
            t = (TextBox)Cobertura_t.Rows[e.RowIndex].FindControl("id");
            cobe.IdCobertura = t.Text;
            t = (TextBox)Cobertura_t.Rows[e.RowIndex].FindControl("Nombre");
            cobe.NombreCobertura = t.Text;
            DropDownList estado = (DropDownList)Cobertura_t.Rows[e.RowIndex].FindControl("estado");
            cobe.EstadoCobertura = estado.Text;
            var Response = ConsumirAppi.ConsumirPost(Rutas.Cobertura, new RestRequest("ModificarCobertura", Method.POST), cobe);
            Cobertura_t.EditIndex = -1;
            Cargarcobertura();
        }

        protected void Cobertura_t_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}