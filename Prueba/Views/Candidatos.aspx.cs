using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prueba.Utileria;
using Prueba.Models;
using Newtonsoft.Json;
using RestSharp;
using System.Data;
using System.Web.UI.HtmlControls;
using System.IO;
using Newtonsoft.Json.Linq;

namespace Prueba.Views
{
    public partial class Candidatos : System.Web.UI.Page
    {
        static string z="";
        static string c="";
       
       
        protected void Page_Load(object sender, EventArgs e)
        {

            if(Request.Params["_EVENTTARGET"] == "AS")
            {
                string S = "HOLA";
            }
            
            if (!IsPostBack)
            {
              
               z = Request.Params["id"];
                c = Request.Params["C"];

                //if (Session["Token"] == null)
                //{
                //    Response.Redirect("Loggin.aspx");
                //}
                //scope("private_profile");
                ConsultarRequisitos();
                NumeroConvo.Text = c;


            }

             if(IsPostBack)
    {
        Boolean fileOK = false;
        String path = Server.MapPath("~/Views/assets/images/");

        if (FileUpload1.HasFile) 
        {
                    
            String fileExtension = 
                System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
            String[] allowedExtensions = 
                {".gif", ".png", ".jpeg", ".jpg"};
          for (int i = 0; i < allowedExtensions.Length; i++)
          {
               if (fileExtension == allowedExtensions[i])
               {
                    fileOK = true;
               }
          }
        }

        if (fileOK)
        {
            try
            {
                FileUpload1.PostedFile.SaveAs(path 
                    + FileUpload1.FileName);
                        EnviarRuta(path + FileUpload1.FileName);
                Label1.Text = "Archivo Cargado";


            }
            catch (Exception ex)
            {
                Label1.Text = "El archivo no fue cargado";
            }
        }
        else
        {
            Label1.Text = "Este archivo no es del tipo adecuado";
        }
    }
            //traer la fecha del servidor 
            DataTable fechamodel = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirGet(Rutas.Fecha, new RestRequest("Consultarfecha", Method.GET)).Content);

            fecha.Text = fechamodel.Rows[0]["FECHA"].ToString();


        }
        //trae los datos desde la bd de chaira
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

            Nombre.Text = scope[0]["NOMBRES"].ToString();
            Apellido.Text = scope[0]["APELLIDOS"].ToString();
            Identificacion.Text = scope[0]["IDENTIFICACION"].ToString();

        }
        //trae los requisitos por cada el cargo seleccionado
        protected void ConsultarRequisitos()
        {
            //var req = new Requisito() { DetalleinstanciaRequisito = "6" };


            DataTable model = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Requisito, new RestRequest("ConsultarPorInstanciaDetalle", Method.POST), new Requisito { DetalleinstanciaRequisito =  "6"}).Content);
            //List<Requisito> model = JsonConvert.DeserializeObject<List<Requisito>>(ConsumirAppi.ConsumirPost(Rutas.Requisito, new RestRequest("ConsultarPorInstanciaDetalle", Method.POST), req));



            requisitos.DataSource = model;
            requisitos.DataBind();
        }

        //protected void InsertarCandidatura()
        //{
        //    var Candida = new Candidatura() { cand_cedula = Identificacion.Text, cand_convocatoriadetalle = cargo.Text, cand_observacion = obser.InnerText, cand_fechainscripcion = fecha.Text};

        //    var response = ConsumirAppi.ConsumirPost(Rutas.Candidatura, new RestRequest("InsertarCandidatura", Method.POST),Candida);

        //}

            //envia los datos de la candidatura a la bd de electoral
        protected void Button_Click(object sender, EventArgs e)
        {
            var Candida = new Candidatura() { cand_cedula = Identificacion.Text, cand_convocatoriadetalle = cargo.Text,  cand_fechainscripcion = fecha.Text };

            var response = ConsumirAppi.ConsumirPost(Rutas.Candidatura, new RestRequest("InsertarCandidatura", Method.POST), Candida);

         }

        protected void EnviarRuta(string ruta)
        {
            var docu = new Documento() { Candidato = "1", Nombre = Nombre.Text, Observacion= obser.InnerText, Ruta= ruta};
            var response = ConsumirAppi.ConsumirPost(Rutas.Documento, new RestRequest("IDcmtCndt", Method.POST), docu);
        }
     

        
    }
}