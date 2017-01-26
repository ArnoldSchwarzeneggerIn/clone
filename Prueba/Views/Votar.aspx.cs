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
    
    public partial class Votar : System.Web.UI.Page
    {

        static List<Votacion> detall;
        static List<Convocatoria> list_conv;
        static List<Votacion> list_ins;
        static List<Votacion> list_can;
        static List<Votacion> list_pro;
        static Convocatoria con;
        static Votacion ins,pro;       
        static bool recargo=false;
        /* Datos de las convocatorias*/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!recargo)
            {
                var conv = new Votacion() { CONV_TITULO = "ESTUDIANTE", CONV_ID = "INGENIERIA DE SISTEMAS" };
                detall = JsonConvert.DeserializeObject<List<Votacion>>(ConsumirAppi.ConsumirPost(Rutas.Votacion, new RestRequest("Cvotacion", Method.POST), conv).Content);
                list_conv = new List<Convocatoria>();
                for (int i = 0; i < detall.Count; i++)
                {
                    var convocatoria = new Convocatoria()
                    {
                        //TituloCovocatoria = detall[i].CONV_TITULO,
                        DescripcionConvocatoria = detall[i].CONV_DESCRIPCION,
                        Fechainicioinscripcion = detall[i].CONV_FECH_INIC_INSC,
                        Fechafininscripcion = detall[i].CONV_FECH_FIN_INSC,
                        IdConvocatoria = detall[i].CONV_ID,

                    };


                    if (i > 0 && list_conv[list_conv.Count - 1].IdConvocatoria != convocatoria.IdConvocatoria)
                    {
                        list_conv.Add(convocatoria);
                    }
                    else if (i == 0)
                    {
                        list_conv.Add(convocatoria);
                    }

                }
                ListaConvocatoria.DataSource = list_conv;
                ListaConvocatoria.DataBind();

                recargo = true;
            }
            else {
                ListaConvocatoria.DataSource = list_conv;
                ListaConvocatoria.DataBind();
            }
            
        }


        /* Metodo para saver cual de los item selecciono */
        protected void Verconvocatoria_Command(object sender, CommandEventArgs e)
        {
            //19293949
            try
            {
                bool ban = false;
                string url = "";
                switch (e.CommandName)
                {
                    case "calendario":
                        Session["Convocatoria"] = e.CommandArgument.ToString();
                        Response.Redirect("VConvocatoriaDetalle.aspx");
                        break;
                    case "convocatoria":
                        con = new Convocatoria() { IdConvocatoria = e.CommandArgument.ToString() };
                        instancias(con);
                        ban = true;
                        url = "<script>javascript:cargo();</script>";                       
                        break;
                    case "instancia":                        
                        string[] arr = e.CommandArgument.ToString().Split(',');
                        ins = new Votacion() { CONV_ID = arr[0], INST_NOMBRE = arr[1], INSD_NOMBRE = arr[2] };
                        Candidatos(ins);
                        ban = true;
                        url = "<script>javascript:cargo2();</script>";                       
                        break;
                    case "candidato":                       
                        pro = new Votacion() { CODIGO= e.CommandArgument.ToString() };
                        string aux = Propuestas(pro);
                        Response.Redirect("Propuestas.aspx?tamano="+ list_pro.Count + "&lista=" + aux );                                              
                        break;
                    case "Votar":
                        ban = true;
                        /* Resivo los parametros del candidato a votar  */
                        break;
                }

                if (ban) {                    
                    ClientScript.RegisterStartupScript(this.GetType(), "assets/js/cespas.js",url);
                }

            }
            catch (Exception ex) { }

        }

        /* Datos de las Instancias*/
        protected void instancias(Convocatoria conv)
        {
            try
            {
                list_ins = new List<Votacion>();
                for (int i = 0; i < detall.Count; i++)
                {
                    var instancia = new Votacion()
                    {
                        INST_NOMBRE = detall[i].INST_NOMBRE,
                        INSD_NOMBRE = detall[i].INSD_NOMBRE,
                        CONV_ID = detall[i].CONV_ID
                    };

                    if (i > 0 && instancia.CONV_ID == conv.IdConvocatoria && list_ins[list_ins.Count - 1].INST_NOMBRE != instancia.INST_NOMBRE && list_ins[list_ins.Count - 1].INSD_NOMBRE != instancia.INSD_NOMBRE)
                    {
                        list_ins.Add(instancia);
                    }
                    else if (i == 0 && instancia.CONV_ID == conv.IdConvocatoria)
                    {
                        list_ins.Add(instancia);
                    }

                }
                 
                ListaInstacia.DataSource = list_ins;
                ListaInstacia.DataBind();

            }
            catch (Exception ex) { }
        }

        /* Datos de los Candidatos*/
        protected void Candidatos(Votacion conv)
        {
            try
            {
                list_can = new List<Votacion>();
                for (int i = 0; i < detall.Count; i++)
                {
                    var candidato = new Votacion()
                    {
                        INST_NOMBRE = detall[i].INST_NOMBRE,
                        INSD_NOMBRE = detall[i].INSD_NOMBRE,
                        CONV_ID = detall[i].CONV_ID,
                        NOMBRE = detall[i].NOMBRE,
                        CODIGO = detall[i].CODIGO,
                        PROG_NOMBRE = detall[i].PROG_NOMBRE

                    };

                    if (i > 0 && candidato.CONV_ID == conv.COND_ID && candidato.INST_NOMBRE == conv.INST_NOMBRE && candidato.INSD_NOMBRE == conv.INSD_NOMBRE && list_can[list_can.Count - 1].INST_NOMBRE != candidato.INST_NOMBRE && list_can[list_can.Count - 1].INSD_NOMBRE != candidato.INSD_NOMBRE)
                    {
                        list_can.Add(candidato);
                    }
                    else if (i == 0 && candidato.CONV_ID == conv.CONV_ID && candidato.INST_NOMBRE == conv.INST_NOMBRE && candidato.INSD_NOMBRE == conv.INSD_NOMBRE)
                    {
                        list_can.Add(candidato);
                    }

                }
                Listacandidatos.DataSource = list_can;
                Listacandidatos.DataBind();
            }
            catch (Exception ex) { }
        }

        /* Propuestas de los Candidatos*/
        protected string Propuestas(Votacion conv)
        {
            try
            {                
                list_pro = new List<Votacion>();
                for (int i = 0; i < detall.Count; i++)
                {
                    if (detall[i].CODIGO==conv.CODIGO)
                    {
                        var propuesta = new Votacion()
                        {
                            PROP_DETALLE = detall[i].PROP_DETALLE,
                            PROP_ID=detall[i].PROP_ID
                        };
                        if (i>0&&list_pro[list_pro.Count-1].PROP_ID!=propuesta.PROP_ID)
                        {
                            list_pro.Add(propuesta);
                        }else if(i==0)
                        {
                            list_pro.Add(propuesta);
                        }                        
                    }                   
                }
                
                return formato(list_pro);             
            }
            catch (Exception ex) {
                return null;
            }
        }

        /* metodo de formateo de las propuestas*/
        protected string formato(List<Votacion> aux)
        {
            string mos = "";
            for (int i = 0; i < aux.Count; i++)
            {
                mos=""+ aux[i].PROP_ID + ","+aux[i].PROP_DETALLE+"."+mos;
            }
            return mos;
        }

    }
}