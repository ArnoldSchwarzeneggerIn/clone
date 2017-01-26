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

namespace Prueba
{
    public partial class Propuestas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Votacion> vot= new List<Votacion>();
                int lengt = Int32.Parse(Request.QueryString["tamano"]);
                string lista = Request.QueryString["lista"];
                string[] arr1 = lista.Split('.');
                for (int i = 0; i < lengt; i++)
                {
                    string[] aux = arr1[i].Split(',');
                    var propuesta = new Votacion()
                    {
                      
                        PROP_DETALLE = aux[1],
                        PROP_ID = aux[0]
                    };
                    vot.Add(propuesta);
                }
                Listapropuestas.DataSource = vot;
                Listapropuestas.DataBind();

            }


        }
        /* Metodo para saver cual de los item selecciono */
        protected void Verconvocatoria_Command(object sender, CommandEventArgs e)
        {
            //19293949
            try
            {

                switch (e.CommandName)
                {
                    case "Votar":

                        /* Resivo los parametros del candidato a votar  */
                        break;
                }

            }
            catch (Exception ex) { }

        }
        private void button1_Click(object sender, System.EventArgs e)
        {
           
        }
    }
}