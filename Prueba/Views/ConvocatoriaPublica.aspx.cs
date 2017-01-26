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
using System.Web.UI.HtmlControls;
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
        static LinkButton[] linkBA;
        static Label[] ArregloLabelInstanciasB;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvtE", Method.POST), new Convocatoria { Estado = "PUBLICADO"}).Content);
                LVPblc.DataSource = data;
                LVPblc.DataBind();
                NmroPblcs.Text = LVPblc.Items.Count.ToString();


                CargarMenu();

            }

        }
        protected void VerPblc(object sender, CommandEventArgs e)
        {

            CargarMenu();
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
            linkBA = new LinkButton[TablaCargosB.Rows.Count];
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
                linkB[j].PostBackUrl = "http://localhost:25597/views/Candidatura.aspx?a=" + IdCargosB[j].ToString() + "&c=" + zB+"&d="+ TablaCargosB.Rows[j]["INST_ID"].ToString();

                linkBA[j] = new LinkButton();
                linkBA[j].Text = "ver candidatos";
                linkBA[j].CssClass = "ArregloDropDownListCargos";
                //linkB[j].OnClientClick = "RedirectCandidato("+IdCargosB[j].ToString()+","+zB+")";
                linkBA[j].PostBackUrl = "http://localhost:25597/views/CandiatosInscritos.aspx?id=" + IdCargosB[j].ToString() + "&c=" + zB;

                ArregloPanelCargosB[j] = new Panel();
                ArregloPanelCargosB[j].CssClass = "accordion-inner";

                ArregloPanelCargosB[j].Controls.Add(ArregloLabelCargosB[j]);
                ArregloPanelCargosB[j].Controls.Add(linkB[j]);
                ArregloPanelCargosB[j].Controls.Add(linkBA[j]);


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
        //menu
        void CargarMenu()
        {


            DataTable dtOutput = (DataTable)Session["usuario"];
            DataView DataMenu = new DataView(dtOutput);
            DataTable MenuEncabezado = DataMenu.ToTable(true, "MENUNOMBRE", "ID_MENU");
            DataTable MenuDetalle = DataMenu.ToTable(true, "SUBMENUMENU", "SUBMENU", "RUTA");

            foreach (DataRow drOutput in MenuEncabezado.Rows)
            {


                HtmlGenericControl li = new HtmlGenericControl("li");


                HtmlGenericControl anchor = new HtmlGenericControl("a");
                anchor.Attributes.Add("href", "#");
                anchor.Attributes.Add("class", "has-ul text-capitalize");
                anchor.InnerText = drOutput["MENUNOMBRE"].ToString();

                HtmlGenericControl icon = new HtmlGenericControl("i");
                icon.Attributes.Add("class", "icon-stack2");
                anchor.Controls.Add(icon);

                li.Controls.Add(anchor);

                HtmlGenericControl ul = new HtmlGenericControl("ul");
                ul.Attributes.Add("class", "hidden-ul");
                ul.Attributes.Add("style", "display: none");
                li.Controls.Add(ul);




                //DataView data = new DataView(dtOutput);


                //DataRow[] foundRows;
                ////for (int i = 0; i<dtOutput.Rows.Count)
                ////{

                //foundRows = dtOutput.Select("ID_MENU =" + drOutput["ID_MENU"].ToString());

                //DataTable dtOutputList = new DataTable();
                //for (int i = 0; i < foundRows.Length;i++)
                //{
                //    //dtOutputList.Rows.Add(foundRows[i]);
                //    dtOutputList.ImportRow(foundRows[i]);
                //}


                ////DataView menu = new DataView(dtOutput);
                ////DataTable dtOutputList = menu.ToTable(true, "ID_MENU", "RUTA", "SUBMENU");
                ////int[] numero = new int[dtOutputList.Rows.Count];
                ////for (int i = 0; i < dtOutputList.Rows.Count; i++)
                ////{

                ////    if (dtOutputList.Rows[i]["ID_MENU"].ToString() != drOutput["ID_MENU"].ToString())
                ////    {
                ////        numero[i] = i+1;
                ////    }
                ////}

                ////for(int i = 0; i < numero.Length;i++)
                ////{
                ////    if (numero[i] != 0)
                ////    {
                ////        dtOutputList.Rows.Remove(dtOutputList.Rows[numero[i]-1]);
                ////    }
                ////}



                ////DataTable dtOutputList = data.ToTable(true, "SUBMENUMENU", "RUTA","SUBMENU");





                //    foreach (DataRow drOutputList in MenuDetalle.Rows)
                //    {
                //        HtmlGenericControl ili = new HtmlGenericControl("li");
                //        ul.Controls.Add(ili);

                //        HtmlGenericControl ianchor = new HtmlGenericControl("a");
                //        ianchor.Attributes.Add("class", "text-capitalize");

                //        ianchor.Attributes.Add("href", Convert.ToString(drOutputList["RUTA"]));

                //        //foreach (DataColumn dcOutputList in dtOutputList.Columns)
                //        //{
                //        //    ianchor.Attributes.Add("href", Convert.ToString(drOutputList["RUTA"]));
                //        //}

                //        ianchor.InnerText = Convert.ToString(drOutputList["SUBMENU"]);
                //        ili.Controls.Add(ianchor);
                //    }
                //    MenuConvocatoria.Controls.Add(li);
                //}


                foreach (DataRow drOutputList in MenuDetalle.Rows)
                {
                    if (drOutput["ID_MENU"].ToString() == drOutputList["SUBMENUMENU"].ToString())
                    {
                        HtmlGenericControl ili = new HtmlGenericControl("li");


                        HtmlGenericControl ianchor = new HtmlGenericControl("a");
                        ianchor.Attributes.Add("class", "text-capitalize");

                        ianchor.Attributes.Add("href", Convert.ToString(drOutputList["RUTA"]));

                        //foreach (DataColumn dcOutputList in dtOutputList.Columns)
                        //{
                        //    ianchor.Attributes.Add("href", Convert.ToString(drOutputList["RUTA"]));
                        //}

                        ianchor.InnerText = Convert.ToString(drOutputList["SUBMENU"]);
                        ili.Controls.Add(ianchor);
                        ul.Controls.Add(ili);
                    }
                }
                MenuA.Controls.Add(li);
            }
            //end menu
        }
    }
}