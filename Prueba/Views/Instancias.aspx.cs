using Newtonsoft.Json;
using Prueba.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
      private static RestClient client = new RestClient("http://localhost:25597/api/instancia/");

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar_instancias();
                Cargar_cobertura();
            }
        }

        protected void Cargar_instancias()
        {
            List<Instancia> model = null;
            var client = new HttpClient();
            var task = client.GetAsync("http://191.102.85.226/Electoral/api/instancia/ConsultarInstancia")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<Instancia>>(jsonString.Result);

              });
            task.Wait();
            Instancia_tabla.DataSource = model;
            Instancia_tabla.DataBind();
        }
        protected void Cargar_cobertura()
        {
            List<Cobertura> model = null;
            var client = new HttpClient();
            var task = client.GetAsync("http://191.102.85.226/Electoral/api/cobertura/ConsultarCobertura")
              .ContinueWith((taskwithresponse) =>
              {
                  var response = taskwithresponse.Result;
                  var jsonString = response.Content.ReadAsStringAsync();
                  jsonString.Wait();
                  model = JsonConvert.DeserializeObject<List<Cobertura>>(jsonString.Result);

              });
            task.Wait();
            Estado.DataSource = model;
            Estado.DataTextField = "nombrecobertura";
            Estado.DataValueField = "idCobertura";
            Estado.DataBind();
            Estado.Items.Insert(0, new ListItem("Seleccione", ""));
        }
        protected void Correr()
        {
            try
            {

            var Datos = new RestRequest("InsertarInstancia",Method.POST);
            Instancia a = new Instancia() { IdCobertura = Estado.SelectedIndex.ToString(), NombreInstancia =Ins.Value };
            Datos.AddJsonBody(a);
            var REsponse= client.Execute(Datos);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "demo.showNotification('top','right','"+"Registro Exitoso"+"');", true);


            }
            catch (Exception e)
            {

            }

    }

    protected void Button1_Click(object sender, EventArgs e)
        {
          Correr();
        }
    }
}