﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prueba.Utileria;
using Prueba.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Prueba.Views
{
    public partial class Candidatos : System.Web.UI.Page
    {
        static List<Requisito> model;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //if (Session["Token"] == null)
                //{
                //    Response.Redirect("Loggin.aspx");
                //}
                //scope("private_profile");
                ConsultarRequisitos();
            }
        }

        protected void scope(string Scope)
        {
            //var respose = ConsumirAppi.Scope(Rutas.Autenticacion, new RestRequest("oauth2/resource.asmx/scope", Method.POST), Scope);
            //JToken Tokens = JsonConvert.DeserializeObject(respose);
            //JArray scope = JArray.Parse(Tokens.SelectToken("description").ToString());
            //imagen_Perfil.Attributes.Add("src", scope[0]["FOTO"].ToString());
            //Imagen_perfil2.Attributes.Add("src", scope[0]["FOTO"].ToString());
            //Nombre2.Text = scope[0]["NOMBRES"].ToString();
            //Nombre1.Text = scope[0]["NOMBRES"].ToString() + " " + scope[0]["APELLIDOS"].ToString();
            //Ubicacion.Text = scope[0]["MUNICIPIO"].ToString() + "-" + scope[0]["DEPARTAMENTO"].ToString();

            //Nombre.Text = scope[0]["NOMBRES"].ToString();
            //Apellido.Text = scope[0]["APELLIDOS"].ToString();
            //Identificacion.Text = scope[0]["IDENTIFICACION"].ToString();

        }

        protected void ConsultarRequisitos()
        {
            //var req = new Requisito() { DetalleinstanciaRequisito = "6" };


            List<Requisito> model = JsonConvert.DeserializeObject<List<Requisito>>(ConsumirAppi.ConsumirPost(Rutas.Requisito, new RestRequest("ConsultarPorInstanciaDetalle", Method.POST), new Requisito { DetalleinstanciaRequisito = "6" }).Content);
            //List<Requisito> model = JsonConvert.DeserializeObject<List<Requisito>>(ConsumirAppi.ConsumirPost(Rutas.Requisito, new RestRequest("ConsultarPorInstanciaDetalle", Method.POST), req));



            requisitos.DataSource = model;
            requisitos.DataBind();
        }


       


    }
}