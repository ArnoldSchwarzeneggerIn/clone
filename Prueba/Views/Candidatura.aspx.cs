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
using System.Drawing;
using System.Drawing.Imaging;

namespace Prueba.Views
{
    public partial class Candidatos : System.Web.UI.Page
    {
        static string a="";
        static string c="";
        static string d = "";
        private object txtUserID;

        public static List<Propuesta> propuest = new List<Propuesta>();

        protected void Page_Load(object sender, EventArgs e)
        {

            if(Request.Params["_EVENTTARGET"] == "AS")
            {
                string S = "HOLA";
            }

            

            if (!IsPostBack)
            {

              
                a = Request.Params["a"];
                c = Request.Params["c"];
                d = Request.Params["d"];

                Convocatoria conv = new Convocatoria(){IdConvocatoria=c,TituloConvocatoria=a, NUMEROCONVOCATORIA=d };


                DataTable data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCrgsCnvt", Method.POST), conv).Content);

                NumeroConvo.Text = data.Rows[0]["CONV_NUMERO"].ToString();
                cargo.Text = data.Rows[0]["INSD_NOMBRE"].ToString();
                titu.InnerText = data.Rows[0]["INST_NOMBRE"].ToString();

                DataTable data2 = (DataTable)Session["usuario"];
                List<Persona> data3 = (List<Persona>)Session["usuario1"];
                Nombre.Text = data2.Rows[0]["NOMBRES"].ToString();
                Apellido.Text = data2.Rows[0]["APELLIDOS"].ToString();
                Identificacion.Text = data2.Rows[0]["IDENTIFICACION"].ToString();

                Byte[] bytes = (Byte[])data3[0].foto;
                string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
                Image1.ImageUrl = "data:image/png;base64," + base64String;

  

                //if (Session["Token"] == null)
                //{
                //    Response.Redirect("Loggin.aspx");
                //}
                //scope("private_profile");
                ConsultarRequisitos();
                NumeroConvo.Text = c;


                //fill propuestas
                
                

            }

    //         if(IsPostBack)
    //{
    //    Boolean fileOK = false;
    //    String path = Server.MapPath("~/Views/assets/images/");
    //    if (FileUpload1.HasFile) 
    //    {
    //        String fileExtension = 
    //            System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
    //        String[] allowedExtensions = 
    //            {".gif", ".png", ".jpeg", ".jpg"};
    //      for (int i = 0; i < allowedExtensions.Length; i++)
    //      {
    //           if (fileExtension == allowedExtensions[i])
    //           {
    //                fileOK = true;
    //           }
    //      }
    //    }

    //    if (fileOK)
    //    {
    //        try
    //        {
    //            FileUpload1.PostedFile.SaveAs(path 
    //                + FileUpload1.FileName);
    //            Label1.Text = "Archivo Cargado";
    //        }
    //        catch (Exception ex)
    //        {
    //            Label1.Text = "El archivo no fue cargado";
    //        }
    //    }
    //    else
    //    {
    //        Label1.Text = "Este archivo no es del tipo adecuado";
    //    }
    
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

        protected void requisitos_ItemEditing(object sender, ListViewEditEventArgs e)
        {
            requisitos.EditIndex = e.NewEditIndex;
            Label Estado = (Label)requisitos.Items[e.NewEditIndex].FindControl("Estadolabel");
            Label cobertura = (Label)requisitos.Items[e.NewEditIndex].FindControl("coberturaid");
            LinkButton Nombre = (LinkButton)requisitos.Items[e.NewEditIndex].FindControl("LinkButton1");
        }

        protected void requisitos_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            if (e.CommandName == "INSERT")
            {
                TextBox txtSurName = (TextBox)requisitos.InsertItem.FindControl("SURENAMETextBox");
                TextBox txtFirstName = (TextBox)requisitos.InsertItem.FindControl("TextBox1");
                FileUpload fu2 = (FileUpload)requisitos.InsertItem.FindControl("FileUpload2");
                if (fu2.HasFile)
                {
                    

                }
                else
                {
                    //ErrorLabel1.Text = "no";

                }
            }
        }

        protected void AgregarPropuesta_Click(object sender, EventArgs e)
        {
            Propuesta propu = new Propuesta()
            {
                prop_detalle = propuesta.InnerText
            };

            propuest.Add(propu);
            //see propuestas

            NumeroR.InnerText = propuest.Count.ToString();
            ListView1.DataSource = propuest;
            ListView1.DataBind();
        }
    }
    }
