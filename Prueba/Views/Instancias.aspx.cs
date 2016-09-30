using Newtonsoft.Json;
using Prueba.Models;
using System;
using System.Collections.Generic;
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
        static async Task RunAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://191.102.85.226/Electoral/api/");
                var Instancia = "{ NombreInstancia :" + "prueba" +", IdCobertura : 10.ToString() }";
               var obj = JsonConvert.SerializeObject(Instancia);
                var response = await client.PostAsJsonAsync("instancia/InsertarInstancia", obj);

                if (response.IsSuccessStatusCode)
                {
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            RunAsync().Wait();
        }
    }
}