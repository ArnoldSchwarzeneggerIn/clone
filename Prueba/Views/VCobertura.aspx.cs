using Newtonsoft.Json;
using Prueba.Models;
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
                Cargarcobertura();
            }
        }
        protected void Cargarcobertura()
        {
            try
            {
            List<Cobertura> cober = JsonConvert.DeserializeObject<List<Cobertura>>(ConsumirAppi.ConsumirGet(Rutas.Cobertura, new RestRequest("ConsultarCobertura", Method.GET)).Content);
            Cobertura_t.DataSource = cober;
                NumeroR.Text = cober.Count.ToString();
            Cobertura_t.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','" + "No se cargaron datos" + "');", true);
            }

        }

        protected void AgregarCober_Click(object sender, EventArgs e)
        {
            try
            {
                var Cober = new Cobertura() { NombreCobertura = cober.Value};
                var Response = ConsumirAppi.ConsumirPost(Rutas.Cobertura,new RestRequest("InsertarCobertura", Method.POST),Cober);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','" + "Registro Exitoso" + "');", true);
            }
            catch (Exception Ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','" + "No ha sido registrado" + "');", true);
               
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
            var Response = ConsumirAppi.ConsumirPost(Rutas.Cobertura, new RestRequest("InsertarCobertura", Method.POST), cobe);
            Cobertura_t.EditIndex = -1;
            Cargarcobertura();
        }
    }
}