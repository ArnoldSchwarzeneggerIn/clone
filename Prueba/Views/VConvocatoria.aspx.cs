using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RestSharp;
using Prueba.Models;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Prueba.Utileria;
using System.Data;
using System.IO;
using System.Web.UI.HtmlControls;

namespace Prueba.Views
{
    public partial class VConvocatoria : System.Web.UI.Page
    {

        //the objects for create the panel of convocados model 1
        //static string z;
        //static DataTable TablaInstancias1 = new DataTable();
        //static DataTable TablaCargos1 = new DataTable();
        //static int[] IdCargos1;
        //static int NTablaCargos1;
        //static Panel[] ArregloPanelInstancias1;
        //static Panel[] ArregloPanelCargosB1;
        //static Label[] ArregloLabelCargos1;
        //static Panel[] ArregloPanelGroup1;
        //static Panel[] ArregloPanelBody1;
        //static HyperLink[] linkb1;
        //static HyperLink[] linkc1;
        //static Label[] ArregloLabelInstancias1;

        //the object for create cargos a convocar
        public Convocatoria cnvt;
        public DataTable TablaInstancias;
        public DataTable TablaCargos;
        public Panel[] ArregloPanelInstancias;
        public Panel[] ArregloPanelCargosB;
        public Label[] ArregloLabelCargos;
        public DropDownList[] ArregloDropDownListCargos;
        public CheckBox[] ArregloCheckCargos;
        public int[] IdCargos;
        int NTablaCargos;
        public Panel[] ArregloPanelGroup;
        public Panel[] ArregloPanelBody;
        public HyperLink[] link;
        public int numerocheck;
        public int NumeroListasSinSeleccionar;
        public int obj;
        public ConvocatoriaDetalle[] cond;



        //the objects for create the panel of convocados model 2
        static string z;
        static public Convocatoria cnvtA;
        static public DataTable TablaInstanciasA;
        static public DataTable TablaCargosA;
        static public DataTable TablaCargosAA;
        static public Panel[] ArregloPanelInstanciasA;
        static public Panel[] ArregloPanelCargosBA;
        static public Label[] ArregloLabelCargosA;
        static public DropDownList[] ArregloDropDownListCargosA;
        static public CheckBox[] ArregloCheckCargosA;
        static public int[] IdCargosA;
        static int NTablaCargosA;
        static public Panel[] ArregloPanelGroupA;
        static public Panel[] ArregloPanelBodyA;
        static public HyperLink[] linkA;
        static public int numerocheckA;
        static public int NumeroListasSinSeleccionarA;
        static public int objA;
        static public ConvocatoriaDetalle[] condA;


        //the objects for create the panel of convocatorias published
        static string zB;
        static DataTable TablaInstanciasB = new DataTable();
        static DataTable TablaCargosB = new DataTable();
        static DataTable TablaCargosBA = new DataTable();
        static int[] IdCargosB;
        static int NTablaCargosB;
        static Panel[] ArregloPanelInstanciasB;
        static Panel[] ArregloPanelCargosBB;
        static Label[] ArregloLabelCargosB;
        static Panel[] ArregloPanelGroupB;
        static Panel[] ArregloPanelBodyB;
        static LinkButton[] linkB;
        static Label[] ArregloLabelInstanciasB;



        protected void Page_Load(object sender, EventArgs e)
        {
            

            string s = Request.Params["__EVENTTARGET"];
            switch (Request.Params["__EVENTTARGET"])
            {
                case "CNmroCnvt":
                    NmroCnvt(sender, e);
                    break;
                case "Guardar":
                    ICnvtC(sender, e);
                    break;

            }

            DateTime fe = fecha();


            //seleccionar cargos

            //GENERALES
            //Fill DataTable with all position
            TablaCargos = CInstancia();

            //Fill View with the datatable TablaCargos
            DataView view = new DataView(TablaCargos);

            //Instancia TablaInstancias
            TablaInstancias = new DataTable();

            //Fill TablaInstancias with the data of the DataView view, filtering data for idInstancia and nombreInstnacia
            TablaInstancias = view.ToTable(true, "idInstancia", "nombreInstancia");


            ArregloPanelInstancias = new Panel[TablaInstancias.Rows.Count];
            ArregloPanelCargosB = new Panel[TablaCargos.Rows.Count];
            ArregloLabelCargos = new Label[TablaCargos.Rows.Count];
            ArregloDropDownListCargos = new DropDownList[TablaCargos.Rows.Count];
            ArregloCheckCargos = new CheckBox[TablaCargos.Rows.Count];
            IdCargos = new int[TablaCargos.Rows.Count];
            ArregloPanelGroup = new Panel[TablaInstancias.Rows.Count];
            ArregloPanelBody = new Panel[TablaInstancias.Rows.Count];
            link = new HyperLink[TablaCargos.Rows.Count];
            //Label[] ArregloError;
            numerocheck = 0;
            obj = 0;
            cond = new ConvocatoriaDetalle[TablaCargos.Rows.Count];
            cnvt = new Convocatoria();



            for (int i = 0; i < TablaInstancias.Rows.Count; i++)
            {

                ArregloPanelGroup[i] = new Panel();
                ArregloPanelGroup[i].CssClass = "accordion-group";

                ArregloPanelBody[i] = new Panel();
                ArregloPanelBody[i].ID = "collapse" + i;
                ArregloPanelBody[i].CssClass = "accordion-body collapse";

                ArregloPanelInstancias[i] = new Panel();
                ArregloPanelInstancias[i].CssClass = "accordion-heading";

                link[i] = new HyperLink();
                link[i].ID = "link" + i;
                link[i].CssClass = "accordion-toggle";
                link[i].Text = TablaInstancias.Rows[i]["nombreInstancia"].ToString();
                link[i].Attributes.Add("data-toggle", "collapse");
                link[i].Attributes.Add("data-parent", "#accordion2");
                link[i].Attributes.Add("href", "#collapse" + i);


                ArregloPanelGroup[i].Controls.Add(ArregloPanelInstancias[i]);
                ArregloPanelInstancias[i].Controls.Add(link[i]);

            }


            for (int j = 0; j < TablaCargos.Rows.Count; j++)
            {

                ArregloCheckCargos[j] = new CheckBox();
                ArregloCheckCargos[j].CssClass = "ArregloCheckCargos";
                ArregloCheckCargos[j].ID = "ArregloCheckCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString();
                ArregloCheckCargos[j].Attributes.Add("name", "NArregloCheckCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString());


                ArregloLabelCargos[j] = new Label();
                ArregloLabelCargos[j].ID = "ArregloLabelCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString();
                ArregloLabelCargos[j].CssClass = "ArregloLabelCargos";
                ArregloLabelCargos[j].Text = TablaCargos.Rows[j]["NombreInstanciadetalle"].ToString();

                IdCargos[j] = Convert.ToInt32(TablaCargos.Rows[j]["idinstanciadetalle"].ToString());



                ArregloDropDownListCargos[j] = new DropDownList();
                ArregloDropDownListCargos[j].ID = "ArregloDropDownListCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString();
                ArregloDropDownListCargos[j].CssClass = "ArregloDropDownListCargos";
                ArregloDropDownListCargos[j].Items.Insert(0, new ListItem("Selccione Opcion...", " "));
                ArregloDropDownListCargos[j].AppendDataBoundItems = true;


                for (int k = 0; k < Convert.ToInt32(TablaCargos.Rows[j]["CupoInstanciadetalle"].ToString()); k++)
                {
                    ArregloDropDownListCargos[j].Items.Add("" + (k + 1));

                }

                ArregloPanelCargosB[j] = new Panel();
                ArregloPanelCargosB[j].CssClass = "accordion-inner";

                ArregloPanelCargosB[j].Controls.Add(ArregloCheckCargos[j]);
                ArregloPanelCargosB[j].Controls.Add(ArregloLabelCargos[j]);
                ArregloPanelCargosB[j].Controls.Add(ArregloDropDownListCargos[j]);

            }


            for (int i = 0; i < TablaInstancias.Rows.Count; i++)
            {
                for (int j = 0; j < TablaCargos.Rows.Count; j++)
                {
                    if (TablaInstancias.Rows[i]["idinstancia"].ToString() == TablaCargos.Rows[j]["instanciadetalleinstancia"].ToString())
                    {

                        ArregloPanelBody[i].Controls.Add(ArregloPanelCargosB[j]);
                        ArregloPanelGroup[i].Controls.Add(ArregloPanelBody[i]);
                    }
                }

                Panel1.Controls.Add(ArregloPanelGroup[i]);

            }







            CCnvtE(new Convocatoria { Estado = "PUBLICADO" }, LVPblc);
            CCnvtE(new Convocatoria { Estado = "BORRADOR" }, LVBrrd);

            NmroPblcs.Text = LVPblc.Items.Count.ToString();
            NmroBrrds.Text = LVBrrd.Items.Count.ToString();
            //validate that when get 1 set text whit borrador and get 2 or more set text with borradores
            //TxtoBrrds.InnerText = (NmroBrrds.Text.Equals("1")) ? " BORRADOR" : " BORRADORES";


            if (!IsPostBack)
            {
                //    if (Session["Token"] == null)
                //    {
                //        Response.Redirect("Loggin.aspx");
                //    }


                //scope("public_profile");

                //  InicioInscripcion.Attributes.Add("min", fe.(0).ToString("yyyy-MM-dd"));


                //Fill dropdownlist years
                //for (int i = 0; i < 3; i++)
                //{
                //    AConv.Items.Add(new ListItem(Convert.ToString(Convert.ToInt16(fe.Year) + (i)), i.ToString()));
                //}
                //End fill dropdownlist years

                //Fill field number convocatoria
                //string s = AConv.SelectedItem.Text;
                //NConv.Value = Numero(s);
                //End Fill field number convocatoria


                //menu
                //Loggin log = new Loggin { UsuarioLogin = usser.Value, ContraceniaLogin = pwd.Value };

                ////List<Loggin> user = JsonConvert.DeserializeObject<List<Login>>(ConsumirAppi.ConsumirGet)
                //List<Login> user = JsonConvert.DeserializeObject<List<Login>>(ConsumirAppi.ConsumirPost(Rutas.Login, new RestRequest("signin", Method.POST), log)).Content;

                //menu
                DataTable dtOutput = (DataTable)Session["usuario"];

                foreach (DataRow drOutput in dtOutput.Rows)
                {


                    HtmlGenericControl li = new HtmlGenericControl("li");                    
                    MenuConvocatoria.Controls.Add(li);

                    HtmlGenericControl anchor = new HtmlGenericControl("a");
                    anchor.Attributes.Add("href", "#");
                    anchor.Attributes.Add("class", "has-ul");
                    anchor.Attributes.Add("style", "text-transform: capitalize");
                    anchor.InnerText = drOutput["MENUNOMBRE"].ToString();

                    HtmlGenericControl icon = new HtmlGenericControl("i");
                    icon.Attributes.Add("class", "icon-stack2");
                    anchor.Controls.Add(icon);

                    li.Controls.Add(anchor);

                    //< i class="icon-stack2"></i>


                    //HtmlGenericControl span = new HtmlGenericControl("span");
                    //li.Attributes.Add("class", "navigation-header");

                    
                    HtmlGenericControl ul = new HtmlGenericControl("ul");
                    ul.Attributes.Add("class","hidden-ul");
                    ul.Attributes.Add("style", "display: none");
                    li.Controls.Add(ul);
                    

                    DataView data = new DataView(dtOutput);

                    DataTable dtOutputList = data.ToTable(true, "SUBMENUMENU", "RUTA","SUBMENU");

                    foreach (DataRow drOutputList in dtOutputList.Rows)
                    {
                        HtmlGenericControl ili = new HtmlGenericControl("li");                     
                        ul.Controls.Add(ili);
                        HtmlGenericControl ianchor = new HtmlGenericControl("a");
                        ianchor.Attributes.Add("style", "text-transform: capitalize");
                        foreach (DataColumn dcOutputList in dtOutputList.Columns)
                        {
                            ianchor.Attributes.Add("href", Convert.ToString(drOutputList["RUTA"]));
                        }
                        
                        ianchor.InnerText = Convert.ToString(drOutputList["SUBMENU"]);
                        ili.Controls.Add(ianchor);
                    }
                    //tabs.Controls.Add(li);
                }



                FRegistro.Value = fe.ToString("yyyy-MM-dd");
                FRegistro.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                NmroCnvt(sender, e);
                //InicioInscripcion.Value = fe.ToString("yyyy-MM-dd");
                InicioInscripcion.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                ffindeinscripcion.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                candidatoshconvo.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                juradosconvoca.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                resultadosconvo.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                epresenciaconvo.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                edistanciaconvo.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));

                //fechamaxima
                ////string Fm = (fe.Year + "-" + 12 + "-" + 31);

                ////InicioInscripcion.Attributes.Add("max", Fm);
                ////ffindeinscripcion.Attributes.Add("max", Fm);
                ////candidatoshconvo.Attributes.Add("max", Fm);
                ////juradosconvoca.Attributes.Add("max", Fm);
                ////resultadosconvo.Attributes.Add("max", Fm);
                ////epresenciaconvo.Attributes.Add("max", Fm);
                ////edistanciaconvo.Attributes.Add("max", Fm);
            }








        }





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
        }




        //Consultar Borradores de convocatorias 
        protected void CCnvtE(Convocatoria c, ListView l)
        {
            try
            {
                //ScriptManager.RegisterStartupScript(this, this.GetType(), "Alerta", "Alerta('Registro','El registro se ha guardado satisfactoriamente','icon-check2','success','true');", true);

                //List<Convocatoria> convocatoria = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvtE", Method.POST), c).Content);
                //foreach (var convocatorias in convocatoria)
                //{
                //    convocatorias.fecharegistro = Convert.ToDateTime(convocatorias.fecharegistro).Year.ToString();
                //}

                DataTable Data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvtE", Method.POST), c).Content);
                foreach (DataRow row in Data.Rows)
                {
                    row["fecharegistro"] = Convert.ToDateTime(row["fecharegistro"]).Year.ToString();
                }

                l.DataSource = Data;
                l.DataBind();
            }
            catch (Exception Ex)
            {
                throw new Exception("Servicio web fuera de servicio, porfavor intente mas tarde", Ex);
            }
        }



        protected DataTable CCargos()
        {
            try
            {

                DataTable Data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirGet(Rutas.InstaciaDetalle, new RestRequest("ConsultarInstanciaDetalle", Method.GET)).Content);
                //DataTable data = new DataTable();
                //data = Converter<InstanciaDetalle>.Convert(cargos);
                return Data;

            }
            catch (Exception e)
            {
                throw new Exception("Servicio web fuera de servicio, porfavor intente mas tarde", e);
            }
        }

        protected DataTable CInstancia()
        {
            try
            {

                //List<Instancia> cargos = JsonConvert.DeserializeObject<List<Instancia>>(ConsumirAppi.ConsumirGet(Rutas.Instancia, new RestRequest("ConsultarInstancia", Method.GET)).Content);
                DataTable cargos = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirGet(Rutas.Convocatoria, new RestRequest("CCrgsInst", Method.GET)).Content);
                return cargos;

            }
            catch (Exception e)
            {
                throw new Exception("Servicio web fuera de servicio, porfavor intente mas tarde", e);
            }
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


        protected void Agregar_Click(object sender, EventArgs e)

        {

        }

        protected void Convocatoria_tabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void Verconvocatoria_Command(object sender, CommandEventArgs e)
        {

            ////Session["Convocatoria"] = e.CommandArgument.ToString();

            //z = e.CommandArgument.ToString();
            ////float x = float.Parse(z);
            ////int y = (int)x;


            //TablaInstancias1 = CInstancia(new Convocatoria() { IdConvocatoria = z }, true);
            //int NTablaInstancias1 = TablaInstancias1.Rows.Count;

            //ArregloPanelGroup1 = new Panel[NTablaInstancias1];
            //ArregloPanelInstancias1 = new Panel[NTablaInstancias1];
            //ArregloPanelBody1 = new Panel[NTablaInstancias1];
            //ArregloLabelInstancias1 = new Label[NTablaInstancias1];
            //linkc1 = new HyperLink[NTablaInstancias1];

            //for (int i = 0; i < NTablaInstancias1; i++)
            //{


            //    ArregloPanelGroup1[i] = new Panel();
            //    ArregloPanelGroup1[i].CssClass = "accordion-group";

            //    ArregloPanelBody1[i] = new Panel();
            //    ArregloPanelBody1[i].ID = "collapseb" + i;
            //    ArregloPanelBody1[i].CssClass = "accordion-body in";

            //    ArregloPanelInstancias1[i] = new Panel();
            //    ArregloPanelInstancias1[i].CssClass = "accordion-heading text-center";



            //    //link[i] = new HyperLink();
            //    //link[i].ID = "link" + i;
            //    //link[i].CssClass = "icon-trash";
            //    //link[i].Text = TablaInstancias.Rows[i]["nombreInstancia"].ToString();
            //    //link[i].Attributes.Add("data-toggle", "collapse");
            //    //link[i].Attributes.Add("data-parent", "#accordion2");
            //    //link[i].Attributes.Add("href", "#collapse" + i);

            //    ArregloLabelInstancias1[i] = new Label();
            //    ArregloLabelInstancias1[i].Text = TablaInstancias1.Rows[i]["NOMBREINSTANCIA"].ToString();

            //    linkc1[i] = new HyperLink();
            //    linkc1[i].CssClass = "icon-pencil7";
            //    linkc1[i].ID = "linkc1" + TablaInstancias1.Rows[i]["IDINSTANCIA"].ToString();
            //    linkc1[i].Style.Add("color", "black");
            //    linkc1[i].Style.Add("float", "left");


            //    ArregloPanelInstancias1[i].Controls.Add(ArregloLabelInstancias1[i]);
            //    ArregloPanelInstancias1[i].Controls.Add(linkc1[i]);
            //    ArregloPanelGroup1[i].Controls.Add(ArregloPanelInstancias1[i]);

            //}

            //TablaCargos1 = CInstancia(new Convocatoria() { IdConvocatoria = z }, false);
            //NTablaCargos1 = TablaCargos1.Rows.Count;
            //ArregloPanelCargosB1 = new Panel[NTablaCargos1];
            //ArregloLabelCargos1 = new Label[NTablaCargos1];
            //linkb1 = new HyperLink[NTablaCargos1];
            //IdCargos1 = new int[NTablaCargos1];

            //for (int j = 0; j < NTablaCargos1; j++)
            //{
            //    ArregloLabelCargos1[j] = new Label();
            //    ArregloLabelCargos1[j].ID = "ArregloLabelCargosb" + TablaCargos1.Rows[j]["INSD_ID"].ToString();
            //    ArregloLabelCargos1[j].Text = TablaCargos1.Rows[j]["INSD_NOMBRE"].ToString();

            //    IdCargos1[j] = Convert.ToInt32(TablaCargos1.Rows[j]["INSD_ID"].ToString());

            //    linkb1[j] = new HyperLink();
            //    linkb1[j].ID = "linkb" + TablaCargos1.Rows[j]["INSD_ID"].ToString();
            //    linkb1[j].CssClass = "icon-trash";
            //    linkb1[j].Style.Add("float", "right");
            //    linkb1[j].Style.Add("Color", "black");

            //    //link1[j].Text = "Inscribir";

            //    ArregloPanelCargosB1[j] = new Panel();
            //    ArregloPanelCargosB1[j].CssClass = "accordion-inner";

            //    ArregloPanelCargosB1[j].Controls.Add(ArregloLabelCargos1[j]);
            //    ArregloPanelCargosB1[j].Controls.Add(linkb1[j]);


            //}

            //for (int i = 0; i < NTablaInstancias1; i++)
            //{
            //    for (int j = 0; j < NTablaCargos1; j++)
            //    {
            //        if (TablaInstancias1.Rows[i]["IdInstancia"].ToString() == TablaCargos1.Rows[j]["INST_ID"].ToString())
            //        {
            //            ArregloPanelBody1[i].Controls.Add(ArregloPanelCargosB1[j]);
            //            ArregloPanelGroup1[i].Controls.Add(ArregloPanelBody1[i]);
            //        }
            //    }
            //    panel4.Controls.Add(ArregloPanelGroup1[i]);

            //}

            //Modify Encabezado Header Convocatoria 

            z = e.CommandArgument.ToString();

            //ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "Refresh_page2()", true);

            List<Convocatoria> ConvocatoriaData = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("Ccnvt", Method.POST), new Convocatoria { IdConvocatoria = z.ToString() }).Content);

            Date1.Value = Convert.ToDateTime(ConvocatoriaData[0].fecharegistro).ToString("yyyy-MM-dd");
            Text1.Value = ConvocatoriaData[0].NUMEROCONVOCATORIA;
            Date2.Value = Convert.ToDateTime(ConvocatoriaData[0].Fechainicioinscripcion).ToString("yyyy-MM-dd");
            Date3.Value = Convert.ToDateTime(ConvocatoriaData[0].Fechafininscripcion).ToString("yyyy-MM-dd");
            Date4.Value = Convert.ToDateTime(ConvocatoriaData[0].Fechapublicacionresultados).ToString("yyyy-MM-dd");
            Date5.Value = Convert.ToDateTime(ConvocatoriaData[0].Fechapublicacionjurados).ToString("yyyy-MM-dd");
            Date6.Value = Convert.ToDateTime(ConvocatoriaData[0].Fechapublicacionhabilitado).ToString("yyyy-MM-dd");
            Date7.Value = Convert.ToDateTime(ConvocatoriaData[0].Fechaeleccionespresenciales).ToString("yyyy-MM-dd");
            Date8.Value = Convert.ToDateTime(ConvocatoriaData[0].Fechaeleccionesdistancia).ToString("yyyy-MM-dd");
            Textarea1.Value = ConvocatoriaData[0].DescripcionConvocatoria;
            MDocumento2.InnerText = ConvocatoriaData[0].DNombre;
            //FileUpload2.PostedFile.FileName 


            //seleccionar cargos

            //GENERALES
            //Fill DataTable with all position
            //TablaCargos = CInstancia();
            TablaCargosA = TablaCargos;

            //Fill View with the datatable TablaCargos
            DataView view2 = new DataView(TablaCargosA);

            //Instancia TablaInstancias
            TablaInstanciasA = new DataTable();

            //Fill TablaInstancias with the data of the DataView view, filtering data for idInstancia and nombreInstnacia
            TablaInstanciasA = view2.ToTable(true, "idInstancia", "nombreInstancia");


            ArregloPanelInstanciasA = new Panel[TablaInstanciasA.Rows.Count];
            ArregloPanelCargosBA = new Panel[TablaCargosA.Rows.Count];
            ArregloLabelCargosA = new Label[TablaCargosA.Rows.Count];
            ArregloDropDownListCargosA = new DropDownList[TablaCargosA.Rows.Count];
            ArregloCheckCargosA = new CheckBox[TablaCargosA.Rows.Count];
            IdCargosA = new int[TablaCargosA.Rows.Count];
            ArregloPanelGroupA = new Panel[TablaInstanciasA.Rows.Count];
            ArregloPanelBodyA = new Panel[TablaInstanciasA.Rows.Count];
            linkA = new HyperLink[TablaCargosA.Rows.Count];
            //Label[] ArregloError;
            numerocheckA = 0;
            objA = 0;
            condA = new ConvocatoriaDetalle[TablaCargosA.Rows.Count];
            cnvtA = new Convocatoria();


            TablaCargosAA = CInstancia(new Convocatoria() { IdConvocatoria = z }, false);
            DataView view4 = new DataView(TablaCargosAA);
            DataTable TablaCargos4 = new DataTable();
            TablaCargos4 = view4.ToTable(true, "INST_ID");




            for (int i = 0; i < TablaInstanciasA.Rows.Count; i++)
            {
                int x = 0;
                ArregloPanelGroupA[i] = new Panel();
                ArregloPanelGroupA[i].CssClass = "accordion-group";

                ArregloPanelInstanciasA[i] = new Panel();
                ArregloPanelInstanciasA[i].CssClass = "accordion-heading";

                linkA[i] = new HyperLink();
                linkA[i].ID = "link2" + i;
                linkA[i].CssClass = "accordion-toggle";
                linkA[i].Text = TablaInstanciasA.Rows[i]["nombreInstancia"].ToString();
                linkA[i].Attributes.Add("data-toggle", "collapse");
                linkA[i].Attributes.Add("data-parent", "#accordion2");
                linkA[i].Attributes.Add("href", "#collapse2" + i);


                for (int j = 0; j < TablaCargos4.Rows.Count; j++)
                {
                    if (TablaInstanciasA.Rows[i]["idInstancia"].ToString() == TablaCargos4.Rows[j]["INST_ID"].ToString())
                    {
                        x = x + 1;
                    }
                    else
                    {

                    }
                }


                ArregloPanelBodyA[i] = new Panel();
                ArregloPanelBodyA[i].ID = "collapse2" + i;
                ArregloPanelBodyA[i].CssClass = (x == 0) ? "accordion-body collapse" : "accordion-body collapse in";

                ArregloPanelInstanciasA[i].Controls.Add(linkA[i]);
                ArregloPanelGroupA[i].Controls.Add(ArregloPanelInstanciasA[i]);


            }


            for (int j = 0; j < TablaCargosA.Rows.Count; j++)
            {

                ArregloCheckCargosA[j] = new CheckBox();
                ArregloCheckCargosA[j].CssClass = "ArregloCheckCargos";
                ArregloCheckCargosA[j].ID = "ArregloCheckCargosA" + TablaCargosA.Rows[j]["idinstanciadetalle"].ToString();
                ArregloCheckCargosA[j].Attributes.Add("name", "NArregloCheckCargosA" + TablaCargosA.Rows[j]["idinstanciadetalle"].ToString());
                //ArregloCheckCargosA[j].AutoPostBack = true;

                ArregloLabelCargosA[j] = new Label();
                ArregloLabelCargosA[j].ID = "ArregloLabelCargosA" + TablaCargosA.Rows[j]["idinstanciadetalle"].ToString();
                ArregloLabelCargosA[j].CssClass = "ArregloLabelCargos";
                ArregloLabelCargosA[j].Text = TablaCargosA.Rows[j]["NombreInstanciadetalle"].ToString();

                IdCargosA[j] = Convert.ToInt32(TablaCargosA.Rows[j]["idinstanciadetalle"].ToString());


                ArregloDropDownListCargosA[j] = new DropDownList();
                ArregloDropDownListCargosA[j].ID = "ArregloDropDownListCargosA" + TablaCargosA.Rows[j]["idinstanciadetalle"].ToString();
                ArregloDropDownListCargosA[j].CssClass = "ArregloDropDownListCargos";
                ArregloDropDownListCargosA[j].Items.Insert(0, new ListItem("Selccione Opcion...", " "));
                ArregloDropDownListCargosA[j].AppendDataBoundItems = true;


                for (int k = 0; k < Convert.ToInt32(TablaCargosA.Rows[j]["CupoInstanciadetalle"].ToString()); k++)
                {
                    ArregloDropDownListCargosA[j].Items.Add("" + (k + 1));


                }


                    for (int i = 0; i < TablaCargosAA.Rows.Count; i++)
                    {
                        if (TablaCargosA.Rows[j]["IDINSTANCIADETALLE"].ToString() == TablaCargosAA.Rows[i]["INSD_ID"].ToString())
                        {
                            ArregloCheckCargosA[j].Checked = true;
                            ArregloDropDownListCargosA[j].SelectedValue = TablaCargosAA.Rows[i]["COND_CUPOS"].ToString();
                        }
                    }
                

                ArregloPanelCargosBA[j] = new Panel();
                ArregloPanelCargosBA[j].CssClass = "accordion-inner";

                ArregloPanelCargosBA[j].Controls.Add(ArregloCheckCargosA[j]);
                ArregloPanelCargosBA[j].Controls.Add(ArregloLabelCargosA[j]);
                ArregloPanelCargosBA[j].Controls.Add(ArregloDropDownListCargosA[j]);

            }


            for (int i = 0; i < TablaInstanciasA.Rows.Count; i++)
            {
                for (int j = 0; j < TablaCargosA.Rows.Count; j++)
                {
                    if (TablaInstanciasA.Rows[i]["idinstancia"].ToString() == TablaCargosA.Rows[j]["instanciadetalleinstancia"].ToString())
                    {

                        ArregloPanelBodyA[i].Controls.Add(ArregloPanelCargosBA[j]);
                        ArregloPanelGroupA[i].Controls.Add(ArregloPanelBodyA[i]);
                    }
                }

                Panel4.Controls.Add(ArregloPanelGroupA[i]);

            }





            //z = e.CommandArgument.ToString();           
            //    TablaCargos1 = CInstancia(new Convocatoria() { IdConvocatoria = z }, false);

            //    for (int i=0; i<TablaCargos.Rows.Count;i++) {

            //        for (int j = 0; j < TablaCargos1.Rows.Count; j++)
            //        {
            //            if (TablaCargos.Rows[i]["IDINSTANCIADETALLE"].ToString() == TablaCargos1.Rows[j]["INSD_ID"].ToString())
            //            {
            //                ArregloCheckCargos[i].Checked = true;
            //            }
            //        }

            //    }

            ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "MBrrd()", true);
            //ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "nueva();", true);



        }

        private void downloadse(string ids)
        {

            List<Convocatoria> ConvocatoriaData = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("Ccnvt", Method.POST), new Convocatoria { IdConvocatoria = z.ToString() }).Content);
            //DataTable dt = lp.get_lista(ids);
            //if (dt.Rows.Count > 0)
            //{
            //    DataRow fila = dt.Rows[0];
            //    Byte[] bytes = (Byte[])fila["Source"];
            //    Response.Buffer = true;
            //    Response.Charset = "";
            //    Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //    Response.ContentType = fila["Type"].ToString();
            //    Response.AddHeader("content-disposition", "attachment;filename="
            //    + fila["Name"].ToString() + fila["Type"].ToString());
            //    Response.BinaryWrite(bytes);
            //    Response.Flush();
            //    Response.End();
            //}
        }


        protected void Salir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("Loggin.aspx");

        }



        protected void Button4_Click(object sender, EventArgs e)
        {

            //validacion por si no chequea ninguna instancia


        }

        protected void ICnvtC(object sender, EventArgs e)
        {
            Transaction[] tran = new Transaction[TablaCargos.Rows.Count];


            for (int i = 0; i < TablaCargos.Rows.Count; i++)
            {
                if (ArregloCheckCargos[i].Checked && ArregloDropDownListCargos[i].SelectedValue != " ")
                {

                    try
                    {

                        ConvocatoriaDetalle objeto = new ConvocatoriaDetalle();
                        objeto.InstanciadetalleConvocatoriaDetalle = IdCargos[i].ToString();
                        objeto.CuposConvocatoriaDetalle = ArregloDropDownListCargos[i].SelectedValue;


                        cond[i] = objeto;
                        obj = obj + 1;



                        ArregloCheckCargos[i].Checked = false;
                        ArregloDropDownListCargos[i].SelectedValue = " ";
                    }
                    catch (Exception Ex)
                    {

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                    }

                }


            }

            if (obj != 0)
            {
                cnvt.TituloConvocatoria = "wtf";
                cnvt.DescripcionConvocatoria = descripcion.Value;
                cnvt.Fechainicioinscripcion = Convert.ToDateTime(InicioInscripcion.Value).ToString("dd/MM/yyy");
                cnvt.Fechafininscripcion = Convert.ToDateTime(ffindeinscripcion.Value).ToString("dd/MM/yyy");
                cnvt.Fechapublicacionhabilitado = Convert.ToDateTime(candidatoshconvo.Value).ToString("dd/MM/yyy");
                cnvt.Fechapublicacionjurados = Convert.ToDateTime(juradosconvoca.Value).ToString("dd/MM/yyy");
                cnvt.Fechaeleccionespresenciales = Convert.ToDateTime(epresenciaconvo.Value).ToString("dd/MM/yyy");
                cnvt.Fechaeleccionesdistancia = Convert.ToDateTime(edistanciaconvo.Value).ToString("dd/MM/yyy");
                cnvt.Fechapublicacionresultados = Convert.ToDateTime(resultadosconvo.Value).ToString("dd/MM/yyy");
                cnvt.fecharegistro = Convert.ToDateTime(FRegistro.Value).ToString("dd/MM/yyy");
                cnvt.Estado = "BORRADOR";

                // add pdf content data of the convocatoria

                Stream fs = null;
                string postedfile = "";
                postedfile = FileUpload1.PostedFile.FileName;
                if (FileUpload1.HasFile)
                {
                    fs = FileUpload1.PostedFile.InputStream;
                }

                string filename = Path.GetFileName(postedfile);
                string ext = Path.GetExtension(filename);

                BinaryReader br = new BinaryReader(fs);
                Byte[] bytes = br.ReadBytes((Int32)fs.Length);

                cnvt.Documento = bytes;
                cnvt.DExtension = ext;
                cnvt.DNombre = filename;


                var Response1 = ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("ICnvt", Method.POST), cnvt);
                if (Convert.ToString(Response1.StatusCode) == "OK")
                {
                    var Response2 = ConsumirAppi.ConsumirPost(Rutas.ConvocatoriaDetalle, new RestRequest("InsertarConvocatoriaDetalle", Method.POST), cond);
                    if (Convert.ToString(Response2.StatusCode) == "OK")
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
                        ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "Refresh_page2();", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                    }

                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                }






                //Response.Redirect(Request.RawUrl);

                //attempting return to a part specific "TBrrd" but not can avoid the resend of information
                //ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "IrAPanel('TBrrd');", true);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //cnvt.TituloConvocatoria = tituloconvo.Value;
            cnvt.DescripcionConvocatoria = descripcion.Value;
            cnvt.Fechainicioinscripcion = Convert.ToDateTime(InicioInscripcion.Value).ToString("dd/MM/yyy");
            cnvt.Fechafininscripcion = Convert.ToDateTime(ffindeinscripcion.Value).ToString("dd/MM/yyy");
            cnvt.Fechapublicacionhabilitado = Convert.ToDateTime(candidatoshconvo.Value).ToString("dd/MM/yyy");
            cnvt.Fechapublicacionjurados = Convert.ToDateTime(juradosconvoca.Value).ToString("dd/MM/yyy");
            cnvt.Fechaeleccionespresenciales = Convert.ToDateTime(epresenciaconvo.Value).ToString("dd/MM/yyy");
            cnvt.Fechaeleccionesdistancia = Convert.ToDateTime(edistanciaconvo.Value).ToString("dd/MM/yyy");
            cnvt.Fechapublicacionresultados = Convert.ToDateTime(ffindeinscripcion.Value).ToString("dd/MM/yyy");

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {


        }


        protected void NuevoClick12(object sender, EventArgs e)
        {

        }



        protected void Button3_Click(object sender, EventArgs e)
        {

            Transaction[] tran = new Transaction[TablaCargosA.Rows.Count];

            for (int i = 0; i < TablaCargosA.Rows.Count; i++)
            {
                if (ArregloCheckCargosA[i].Checked && ArregloDropDownListCargosA[i].SelectedValue != " ")
                {

                    try
                    {

                        ConvocatoriaDetalle objeto = new ConvocatoriaDetalle();
                        objeto.InstanciadetalleConvocatoriaDetalle = IdCargosA[i].ToString();
                        objeto.CuposConvocatoriaDetalle = ArregloDropDownListCargosA[i].SelectedValue;
                        objeto.ConvocatoriaConvocatoriaDetalle = z;


                        condA[i] = objeto;
                        objA = obj + 1;



                        //ArregloCheckCargosA[i].Checked = false;
                        //ArregloDropDownListCargosA[i].SelectedValue = " ";
                    }
                    catch (Exception Ex)
                    {

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                    }

                }


            }

            if (objA != 0)
            {
                cnvtA.IdConvocatoria = z;
                cnvtA.NUMEROCONVOCATORIA = Text1.Value;
                cnvtA.DescripcionConvocatoria = Textarea1.Value;
                cnvtA.Fechainicioinscripcion = Convert.ToDateTime(Date2.Value).ToString("dd/MM/yyy");
                cnvtA.Fechafininscripcion = Convert.ToDateTime(Date3.Value).ToString("dd/MM/yyy");
                cnvtA.Fechapublicacionhabilitado = Convert.ToDateTime(Date6.Value).ToString("dd/MM/yyy");
                cnvtA.Fechapublicacionjurados = Convert.ToDateTime(Date5.Value).ToString("dd/MM/yyy");
                cnvtA.Fechaeleccionespresenciales = Convert.ToDateTime(Date7.Value).ToString("dd/MM/yyy");
                cnvtA.Fechaeleccionesdistancia = Convert.ToDateTime(Date8.Value).ToString("dd/MM/yyy");
                cnvtA.Fechapublicacionresultados = Convert.ToDateTime(Date4.Value).ToString("dd/MM/yyy");
                cnvtA.fecharegistro = Convert.ToDateTime(Date1.Value).ToString("dd/MM/yyy");
                cnvtA.Estado = "PUBLICADO";

                // add pdf content data of the convocatoria

                Stream fs = null;
                string postedfile = "";
                postedfile = FileUpload2.PostedFile.FileName;
                if (FileUpload2.HasFile)
                {
                    fs = FileUpload2.PostedFile.InputStream;
                }
                if (fs != null)
                {
                    string filename = Path.GetFileName(postedfile);
                    string ext = Path.GetExtension(filename);

                    BinaryReader br = new BinaryReader(fs);
                    Byte[] bytes = br.ReadBytes((Int32)fs.Length);

                    cnvtA.Documento = bytes;
                    cnvtA.DExtension = ext;
                    cnvtA.DNombre = filename;
                }
                else
                {
                    cnvtA.Documento = null;
                    cnvtA.DExtension = "NODATA";
                    cnvtA.DNombre = "NODATA";
                }

                ConvocatoriaDetalle cond5 = new ConvocatoriaDetalle();
                cond5.ConvocatoriaConvocatoriaDetalle = z;


                var Response1 = ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("MCnvt", Method.POST), cnvtA);
                if (Convert.ToString(Response1.StatusCode) == "OK")
                {
                    var response2 = ConsumirAppi.ConsumirPost(Rutas.ConvocatoriaDetalle, new RestRequest("DCnvd", Method.POST), cond5);
                    if (Convert.ToString(response2.StatusCode) == "OK")
                    {
                        var Response3 = ConsumirAppi.ConsumirPost(Rutas.ConvocatoriaDetalle, new RestRequest("MCnvd", Method.POST), condA);
                        if (Convert.ToString(Response3.StatusCode) == "OK")
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
                            ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "Refresh_page2();", true);
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                        }
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                }

            }
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            z = e.CommandArgument.ToString();
            ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("MECnvt", Method.POST), new Convocatoria { IdConvocatoria = z, Estado = "PUBLICADO" });
        }

        protected void VerPblc(object sender, CommandEventArgs e)
        {

            zB = e.CommandArgument.ToString();
            CntvPblc.InnerText = zB;

            Convocatoria conv = new Convocatoria() { IdConvocatoria = zB};

            List<Convocatoria> ConvocatoriaData = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("Ccnvt", Method.POST), conv).Content);
            Label3.InnerText = ConvocatoriaData[0].DNombre;


            DataTable Data = JsonConvert.DeserializeObject<DataTable>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("CCnvt", Method.POST), conv).Content);
            foreach (DataRow row in Data.Rows)
            {
                row["fecharegistro"] = Convert.ToDateTime(row["fecharegistro"]).Year.ToString();
            }    

            ListView1.DataSource = Data;
            ListView1.DataBind();


            //NmroPblcs.Text = LVPblc.Items.Count.ToString();
            TablaCargosB = CInstancia(new Convocatoria() { IdConvocatoria = zB }, false);
            DataView view10 = new DataView(TablaCargosB);
            TablaInstanciasB = view10.ToTable(true, "INST_ID","INST_NOMBRE");
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
            //linkB = new LinkButton [TablaCargosB.Rows.Count];
            IdCargosB = new int[NTablaCargosB];

            for (int j = 0; j < NTablaCargosB; j++)
            {
                ArregloLabelCargosB[j] = new Label();
                ArregloLabelCargosB[j].ID = "ArregloLabelCargosB" + TablaCargosB.Rows[j]["INSD_ID"].ToString();
                ArregloLabelCargosB[j].Text = TablaCargosB.Rows[j]["INSD_NOMBRE"].ToString();

                IdCargosB[j] = Convert.ToInt32(TablaCargosB.Rows[j]["INSD_ID"].ToString());

                //linkB[j] = new LinkButton();
                //linkB[j].Text = "Inscribir";
                //linkB[j].CssClass = "ArregloDropDownListCargos";

                ArregloPanelCargosB[j] = new Panel();
                ArregloPanelCargosB[j].CssClass = "accordion-inner";

                ArregloPanelCargosB[j].Controls.Add(ArregloLabelCargosB[j]);
                //ArregloPanelCargosB[j].Controls.Add(linkB[j]);


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

        protected void Button4_Click1(object sender, EventArgs e)
        {
            ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("MECnvt", Method.POST), new Convocatoria { IdConvocatoria = z, Estado = "ELIMINADO" });

        }


        //Obtener fecha del servidor
        public DateTime fecha()
        {

            List<Fecha> fecha = JsonConvert.DeserializeObject<List<Fecha>>(ConsumirAppi.ConsumirGet(Rutas.Fecha, new RestRequest("ConsultarFecha", Method.GET)).Content);
            return Convert.ToDateTime(fecha[0].FECHA);

        }

        public string Numero(string obj)
        {

            Convocatoria conv = new Convocatoria() { Fechafininscripcion = "01/01/" + Convert.ToDateTime(FRegistro.Value).Year };
            List<Convocatoria> numero = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("cnmrocnvt", Method.POST), conv).Content);
            return numero[0].NUMEROCONVOCATORIA;

        }


        protected void NmroCnvt(object sender, EventArgs e)
        {
            string s = Convert.ToDateTime(FRegistro.Value).Year.ToString();
            NConv.Value = Numero(s);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var s = "wtf";
        }

        protected void CrearAcordionCargos(Panel p, string s)
        {

            //    //seleccionar cargos

            //    //GENERALES
            //    //Fill DataTable with all position
            //    TablaCargos = CInstancia();

            //    //Fill View with the datatable TablaCargos
            //    DataView view = new DataView(TablaCargos);

            //    //Instancia TablaInstancias
            //    TablaInstancias = new DataTable();

            //    //Fill TablaInstancias with the data of the DataView view, filtering data for idInstancia and nombreInstnacia
            //    TablaInstancias = view.ToTable(true, "idInstancia", "nombreInstancia");


            //    ArregloPanelInstancias = new Panel[TablaInstancias.Rows.Count];
            //    ArregloPanelCargosB = new Panel[TablaCargos.Rows.Count];
            //    ArregloLabelCargos = new Label[TablaCargos.Rows.Count];
            //    ArregloDropDownListCargos = new DropDownList[TablaCargos.Rows.Count];
            //    ArregloCheckCargos = new CheckBox[TablaCargos.Rows.Count];
            //    IdCargos = new int[TablaCargos.Rows.Count];
            //    ArregloPanelGroup = new Panel[TablaInstancias.Rows.Count];
            //    ArregloPanelBody = new Panel[TablaInstancias.Rows.Count];
            //    link = new HyperLink[TablaCargos.Rows.Count];
            //    //Label[] ArregloError;
            //    numerocheck = 0;
            //    obj = 0;
            //    cond = new ConvocatoriaDetalle[TablaCargos.Rows.Count];
            //    cnvt = new Convocatoria();



            //    for (int i = 0; i < TablaInstancias.Rows.Count; i++)
            //    {

            //        ArregloPanelGroup[i] = new Panel();
            //        ArregloPanelGroup[i].CssClass = "accordion-group";

            //        ArregloPanelBody[i] = new Panel();
            //        ArregloPanelBody[i].ID = "collapse" + i;
            //        ArregloPanelBody[i].CssClass = "accordion-body collapse";

            //        ArregloPanelInstancias[i] = new Panel();
            //        ArregloPanelInstancias[i].CssClass = "accordion-heading";

            //        link[i] = new HyperLink();
            //        link[i].ID = "link" + i;
            //        link[i].CssClass = "accordion-toggle";
            //        link[i].Text = TablaInstancias.Rows[i]["nombreInstancia"].ToString();
            //        link[i].Attributes.Add("data-toggle", "collapse");
            //        link[i].Attributes.Add("data-parent", "#accordion2");
            //        link[i].Attributes.Add("href", "#collapse" + i);


            //        ArregloPanelGroup[i].Controls.Add(ArregloPanelInstancias[i]);
            //        ArregloPanelInstancias[i].Controls.Add(link[i]);

            //    }


            //    for (int j = 0; j < TablaCargos.Rows.Count; j++)
            //    {

            //        ArregloCheckCargos[j] = new CheckBox();
            //        ArregloCheckCargos[j].CssClass = "ArregloCheckCargos";
            //        ArregloCheckCargos[j].ID = "ArregloCheckCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString();
            //        ArregloCheckCargos[j].Attributes.Add("name", "NArregloCheckCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString());


            //        ArregloLabelCargos[j] = new Label();
            //        ArregloLabelCargos[j].ID = "ArregloLabelCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString();
            //        ArregloLabelCargos[j].CssClass = "ArregloLabelCargos";
            //        ArregloLabelCargos[j].Text = TablaCargos.Rows[j]["NombreInstanciadetalle"].ToString();

            //        IdCargos[j] = Convert.ToInt32(TablaCargos.Rows[j]["idinstanciadetalle"].ToString());



            //        ArregloDropDownListCargos[j] = new DropDownList();
            //        ArregloDropDownListCargos[j].ID = "ArregloDropDownListCargos" + TablaCargos.Rows[j]["idinstanciadetalle"].ToString();
            //        ArregloDropDownListCargos[j].CssClass = "ArregloDropDownListCargos";
            //        ArregloDropDownListCargos[j].Items.Insert(0, new ListItem("Selccione Opcion...", " "));
            //        ArregloDropDownListCargos[j].AppendDataBoundItems = true;


            //        for (int k = 0; k < Convert.ToInt32(TablaCargos.Rows[j]["CupoInstanciadetalle"].ToString()); k++)
            //        {
            //            ArregloDropDownListCargos[j].Items.Add("" + (k + 1));

            //        }

            //        ArregloPanelCargosB[j] = new Panel();
            //        ArregloPanelCargosB[j].CssClass = "accordion-inner";

            //        ArregloPanelCargosB[j].Controls.Add(ArregloCheckCargos[j]);
            //        ArregloPanelCargosB[j].Controls.Add(ArregloLabelCargos[j]);
            //        ArregloPanelCargosB[j].Controls.Add(ArregloDropDownListCargos[j]);

            //    }


            //    for (int i = 0; i < TablaInstancias.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < TablaCargos.Rows.Count; j++)
            //        {
            //            if (TablaInstancias.Rows[i]["idinstancia"].ToString() == TablaCargos.Rows[j]["instanciadetalleinstancia"].ToString())
            //            {

            //                ArregloPanelBody[i].Controls.Add(ArregloPanelCargosB[j]);
            //                ArregloPanelGroup[i].Controls.Add(ArregloPanelBody[i]);
            //            }
            //        }

            //        Panel1.Controls.Add(ArregloPanelGroup[i]);

            //    }


        }


        protected void Registrar_Click(object sender, EventArgs e)
        {






        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            List<Convocatoria> ConvocatoriaData = JsonConvert.DeserializeObject<List<Convocatoria>>(ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("Ccnvt", Method.POST), new Convocatoria { IdConvocatoria = z.ToString() }).Content);

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

        protected void Button8_Click(object sender, EventArgs e)
        {

        }

        protected void FileUpload2_Disposed(object sender, EventArgs e)
        {

        }

        protected void FileUpload2_Unload(object sender, EventArgs e)
        {

        }

        protected void Button8_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebForm6.aspx?z="+zB);
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
    }


}

















