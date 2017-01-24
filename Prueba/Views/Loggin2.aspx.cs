using Newtonsoft.Json;
using Prueba.Models;
using Prueba.Utileria;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Views
{
    public partial class loggin2 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
               
            }



            //Loggin logi = new Loggin();
            //logi.UsuarioLogin = "admin";
            //logi.ContraceniaLogin = "admin";

            //user.Add(logi);

            //logi = new Loggin();
            //logi.UsuarioLogin = "publico";
            //logi.ContraceniaLogin = "publico";

            //user.Add(logi);


            //user.Add(logi);


            //Session["Token"] = null;
            //        Session["Code"] = null;

        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            Loggin log = new Loggin { UsuarioLogin = usser.Value, ContraceniaLogin = pwd.Value };
            DataTable user = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Login, new RestRequest("Singnin", Method.POST), log).Content);
            if(user.Rows[0]["MENUNOMBRE"].ToString() != null)
            {
                Session["usuario"] = user;
                Response.Redirect("VConvocatoria.aspx");
            }
            
           
        }
    }
}