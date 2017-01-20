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
    public partial class ConvocatoriaPublica : System.Web.UI.Page
    {
        //the objects for create the panel of convocatorias published
        static string zB;
        static DataTable TablaInstanciasB = new DataTable();
        static DataTable TablaCargosB = new DataTable();
        static DataTable TablaCargosBA = new DataTable();
        static int[] IdCargosB;
        static int NTablaCargosB;
        static Panel[] ArregloPanelInstanciasB;
        static Panel[] ArregloPanelCargosB;
        static Label[] ArregloLabelCargosB;
        static Panel[] ArregloPanelGroupB;
        static Panel[] ArregloPanelBodyB;
        static LinkButton[] linkB;
        static Label[] ArregloLabelInstanciasB;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvtE", Method.POST), new Convocatoria { Estado = "PUBLICADO"}).Content);
                LVPblc.DataSource = data;
                LVPblc.DataBind();
                NmroPblcs.Text = LVPblc.Items.Count.ToString();

            }

        }
        protected void VerPblc(object sender, CommandEventArgs e)
        {
            zB = e.CommandArgument.ToString();
            CntvPblc.InnerText = zB;

            Convocatoria conv = new Convocatoria() { IdConvocatoria = zB };

            List<Convocatoria> ConvocatoriaData = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("Ccnvt", Method.POST), conv).Content);
            Label3.InnerText = ConvocatoriaData[0].DNombre;


            DataTable Data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvt", Method.POST), conv).Content);
            foreach (DataRow row in Data.Rows)
            {
                row["fecharegistro"] = Convert.ToDateTime(row["fecharegistro"]).Year.ToString();
            }

            LVPblc.DataSource = Data;
            LVPblc.DataBind();


            //NmroPblcs.Text = LVPblc.Items.Count.ToString();
            TablaCargosB = CInstancia(new Convocatoria() { IdConvocatoria = zB }, false);
            DataView view10 = new DataView(TablaCargosB);
            TablaInstanciasB = view10.ToTable(true, "INST_ID", "INST_NOMBRE");
            int NTablaInstanciasB = TablaInstanciasB.Rows.Count;

            ArregloPanelGroupB = new Panel[NTablaInstanciasB];
            ArregloPanelInstanciasB = new Panel[NTablaInstanciasB];
            ArregloPanelBodyB = new Panel[NTablaInstanciasB];
            ArregloLabelInstanciasB = new Label[NTablaInstanciasB];




            for (int i = 0; i < NTablaInstanciasB; i++)
            {


                ArregloPanelGroupB[i] = new Panel();
                ArregloPanelGroupB[i].CssClass = "accordion-group";

                ArregloPanelInstanciasB[i] = new Panel();
                ArregloPanelInstanciasB[i].CssClass = "accordion-heading";

                ArregloPanelBodyB[i] = new Panel();
                ArregloPanelBodyB[i].ID = "collapseb" + i;
                ArregloPanelBodyB[i].CssClass = "accordion-body in";

                ArregloLabelInstanciasB[i] = new Label();
                ArregloLabelInstanciasB[i].Text = TablaInstanciasB.Rows[i]["INST_NOMBRE"].ToString();

                ArregloPanelInstanciasB[i].Controls.Add(ArregloLabelInstanciasB[i]);
                ArregloPanelGroupB[i].Controls.Add(ArregloPanelInstanciasB[i]);

            }


            NTablaCargosB = TablaCargosB.Rows.Count;
            ArregloPanelCargosB = new Panel[NTablaCargosB];
            ArregloLabelCargosB = new Label[NTablaCargosB];
            linkB = new LinkButton [TablaCargosB.Rows.Count];
            IdCargosB = new int[NTablaCargosB];

            for (int j = 0; j < NTablaCargosB; j++)
            {
                ArregloLabelCargosB[j] = new Label();
                ArregloLabelCargosB[j].ID = "ArregloLabelCargosB" + TablaCargosB.Rows[j]["INSD_ID"].ToString();
                ArregloLabelCargosB[j].Text = TablaCargosB.Rows[j]["INSD_NOMBRE"].ToString();

                IdCargosB[j] = Convert.ToInt32(TablaCargosB.Rows[j]["INSD_ID"].ToString());

                linkB[j] = new LinkButton();
                linkB[j].Text = "Inscribir";
                linkB[j].CssClass = "ArregloDropDownListCargos";
                //linkB[j].OnClientClick = "RedirectCandidato("+IdCargosB[j].ToString()+","+zB+")";
                linkB[j].PostBackUrl = "http://localhost:25597/views/Candidatura.aspx?id=" + IdCargosB[j].ToString() + "&c=" + zB;

                ArregloPanelCargosB[j] = new Panel();
                ArregloPanelCargosB[j].CssClass = "accordion-inner";

                ArregloPanelCargosB[j].Controls.Add(ArregloLabelCargosB[j]);
                ArregloPanelCargosB[j].Controls.Add(linkB[j]);


            }

            for (int i = 0; i < NTablaInstanciasB; i++)
            {
                for (int j = 0; j < NTablaCargosB; j++)
                {
                    if (TablaInstanciasB.Rows[i]["INST_ID"].ToString() == TablaCargosB.Rows[j]["INSD_INSTANCIA"].ToString())
                    {
                        ArregloPanelBodyB[i].Controls.Add(ArregloPanelCargosB[j]);

                    }
                }
                ArregloPanelGroupB[i].Controls.Add(ArregloPanelBodyB[i]);
                Panel3.Controls.Add(ArregloPanelGroupB[i]);

            }


            ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "IrAPanel('PPblc');", true);
        }
        protected DataTable CInstancia(Convocatoria c, bool a)
        {
            try
            {
                if (a)
                {
                    DataTable Data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest((a) ? "CInstCnvt" : "CInsdCnvt", Method.POST), c).Content);
                    //DataTable data = new DataTable();
                    //data = Converter<Instancia>.Convert(cargos);
                    return Data;
                }
                else
                {
                    DataTable Data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest((a) ? "CInstCnvt" : "CInsdCnvt", Method.POST), c).Content);
                    //DataTable data = new DataTable();
                    //data = Converter<Votacion>.Convert(cargos);
                    return Data;
                }



            }
            catch (Exception e)
            {
                throw new Exception("Servicio web fuera de servicio, porfavor intente mas tarde", e);
            }
        }
        protected void Button8_Click2(object sender, EventArgs e)
        {
            List<Convocatoria> ConvocatoriaData = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("Ccnvt", Method.POST), new Convocatoria { IdConvocatoria = zB.ToString() }).Content);

            Byte[] bytes = (Byte[])ConvocatoriaData[0].Documento;
            Response.Buffer = true;
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = ConvocatoriaData[0].DExtension;
            Response.AddHeader("content-disposition", "attachment;filename="
            + ConvocatoriaData[0].DNombre);
            Response.BinaryWrite(bytes);
            Response.Flush();
            Response.End();
        }

        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Loggin.aspx");

        }
    }
}