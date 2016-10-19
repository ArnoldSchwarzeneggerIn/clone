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
    public partial class instanciaDetalle : System.Web.UI.Page
    {
        private Instancia Inst;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getInstancia();
            }
        }
        protected void getInstancia()
        {
            if (Session["InstanciaDetalle"] != null)
            {
                Inst = (Instancia)Session["InstanciaDetalle"];
                Session.Remove("InstanciaDetalle");
                nombreInstancia.Text = Inst.NombreInstancia;
                EstadoInstancia.Text = Inst.EstadoInstancia;
                cargosInstancia();

            }
            else
            {
                Response.Redirect("Instancias.aspx");
            }
        }

        protected void cargosInstancia()
        {
            try
            {
                var instDetall = new InstanciaDetalle() { IdInstancia = Inst.IdInstancia };
                List<InstanciaDetalle> detall = JsonConvert.DeserializeObject<List<InstanciaDetalle>>(ConsumirAppi.ConsumirPost(Rutas.InstaciaDetalle, new RestRequest("ConsultarCargosInstancia", Method.POST), instDetall).Content);
                cargosInsta.DataSource = detall;
                cargosInsta.DataBind();
            }
            catch(Exception ex)
            {

            }
           
        }

       
    }
}