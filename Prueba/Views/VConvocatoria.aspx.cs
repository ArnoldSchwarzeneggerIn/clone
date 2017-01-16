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
        //static Panel[] ArregloPanelCargos1;
        //static Label[] ArregloLabelCargos1;
        //static Panel[] ArregloPanelGroup1;
        //static Panel[] ArregloPanelBody1;
        //static HyperLink[] linkb1;
        //static HyperLink[] linkc1;
        //static Label[] ArregloLabelInstancias1;


        //the objects for create the panel of convocados model 2
        static string z;
        public Convocatoria cnvt2;
        public DataTable TablaInstancias2;
        public DataTable TablaCargos2;
        public DataTable TablaCargos3;
        public Panel[] ArregloPanelInstancias2;
        public Panel[] ArregloPanelCargos2;
        public Label[] ArregloLabelCargos2;
        public DropDownList[] ArregloDropDownListCargos2;
        public CheckBox[] ArregloCheckCargos2;
        public int[] IdCargos2;
        int NTablaCargos2;
        public Panel[] ArregloPanelGroup2;
        public Panel[] ArregloPanelBody2;
        public HyperLink[] link2;
        public int numerocheck2;
        public int NumeroListasSinSeleccionar2;
        public int obj2;
        public ConvocatoriaDetalle[] cond2;



        //the object for create cargos a convocar
        public Convocatoria cnvt;
        public DataTable TablaInstancias;
        public DataTable TablaCargos;
        public Panel[] ArregloPanelInstancias;
        public Panel[] ArregloPanelCargos;
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








        protected void Page_Load(object sender, EventArgs e)
        {
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
            ArregloPanelCargos = new Panel[TablaCargos.Rows.Count];
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

                ArregloPanelCargos[j] = new Panel();
                ArregloPanelCargos[j].CssClass = "accordion-inner";

                ArregloPanelCargos[j].Controls.Add(ArregloCheckCargos[j]);
                ArregloPanelCargos[j].Controls.Add(ArregloLabelCargos[j]);
                ArregloPanelCargos[j].Controls.Add(ArregloDropDownListCargos[j]);

            }


            for (int i = 0; i < TablaInstancias.Rows.Count; i++)
            {
                for (int j = 0; j < TablaCargos.Rows.Count; j++)
                {
                    if (TablaInstancias.Rows[i]["idinstancia"].ToString() == TablaCargos.Rows[j]["instanciadetalleinstancia"].ToString())
                    {

                        ArregloPanelBody[i].Controls.Add(ArregloPanelCargos[j]);
                        ArregloPanelGroup[i].Controls.Add(ArregloPanelBody[i]);
                    }
                }

                Panel1.Controls.Add(ArregloPanelGroup[i]);

            }


        




            CCnvtE(new Convocatoria { Estado = "PUBLICADO" }, ListaConvocatoria);
            CCnvtE(new Convocatoria { Estado = "BORRADOR" }, LVBrrd);
            NumeroR.Text = LVBrrd.Items.Count.ToString();

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

                FRegistro.Value = fe.ToString("yyyy-MM-dd");
                FRegistro.Attributes.Add("min", fe.ToString("yyyy-MM-dd"));
                InicioInscripcion.Value = fe.ToString("yyyy-MM-dd");
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
            //ArregloPanelCargos1 = new Panel[NTablaCargos1];
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

            //    ArregloPanelCargos1[j] = new Panel();
            //    ArregloPanelCargos1[j].CssClass = "accordion-inner";

            //    ArregloPanelCargos1[j].Controls.Add(ArregloLabelCargos1[j]);
            //    ArregloPanelCargos1[j].Controls.Add(linkb1[j]);


            //}

            //for (int i = 0; i < NTablaInstancias1; i++)
            //{
            //    for (int j = 0; j < NTablaCargos1; j++)
            //    {
            //        if (TablaInstancias1.Rows[i]["IdInstancia"].ToString() == TablaCargos1.Rows[j]["INST_ID"].ToString())
            //        {
            //            ArregloPanelBody1[i].Controls.Add(ArregloPanelCargos1[j]);
            //            ArregloPanelGroup1[i].Controls.Add(ArregloPanelBody1[i]);
            //        }
            //    }
            //    panel4.Controls.Add(ArregloPanelGroup1[i]);

            //}


            //seleccionar cargos

            //GENERALES
            //Fill DataTable with all position
            //TablaCargos = CInstancia();
            TablaCargos2 = TablaCargos;

            //Fill View with the datatable TablaCargos
            DataView view2 = new DataView(TablaCargos2);

            //Instancia TablaInstancias
            TablaInstancias2 = new DataTable();

            //Fill TablaInstancias with the data of the DataView view, filtering data for idInstancia and nombreInstnacia
            TablaInstancias2 = view2.ToTable(true, "idInstancia", "nombreInstancia");


            ArregloPanelInstancias2 = new Panel[TablaInstancias2.Rows.Count];
            ArregloPanelCargos2 = new Panel[TablaCargos2.Rows.Count];
            ArregloLabelCargos2 = new Label[TablaCargos2.Rows.Count];
            ArregloDropDownListCargos2 = new DropDownList[TablaCargos2.Rows.Count];
            ArregloCheckCargos2 = new CheckBox[TablaCargos2.Rows.Count];
            IdCargos2 = new int[TablaCargos2.Rows.Count];
            ArregloPanelGroup2 = new Panel[TablaInstancias2.Rows.Count];
            ArregloPanelBody2 = new Panel[TablaInstancias2.Rows.Count];
            link2 = new HyperLink[TablaCargos2.Rows.Count];
            //Label[] ArregloError;
            numerocheck2 = 0;
            obj2 = 0;
            cond2 = new ConvocatoriaDetalle[TablaCargos2.Rows.Count];
            cnvt2 = new Convocatoria();


            z = e.CommandArgument.ToString();
            TablaCargos3 = CInstancia(new Convocatoria() { IdConvocatoria = z }, false);
            DataView view4 = new DataView(TablaCargos3);
            DataTable TablaCargos4 = new DataTable();
            TablaCargos4 = view4.ToTable(true, "INST_ID");
            



            for (int i = 0; i < TablaInstancias2.Rows.Count; i++)
            {
                int x = 0;
                ArregloPanelGroup2[i] = new Panel();
                ArregloPanelGroup2[i].CssClass = "accordion-group";

                ArregloPanelInstancias2[i] = new Panel();
                ArregloPanelInstancias2[i].CssClass = "accordion-heading";

                link2[i] = new HyperLink();
                link2[i].ID = "link2" + i;
                link2[i].CssClass = "accordion-toggle";
                link2[i].Text = TablaInstancias2.Rows[i]["nombreInstancia"].ToString();
                link2[i].Attributes.Add("data-toggle", "collapse");
                link2[i].Attributes.Add("data-parent", "#accordion2");
                link2[i].Attributes.Add("href", "#collapse2" + i);


                for (int j = 0; j < TablaCargos4.Rows.Count; j++)
                {
                    if (TablaInstancias2.Rows[i]["idInstancia"].ToString() == TablaCargos4.Rows[j]["INST_ID"].ToString())
                    {
                        x = x + 1;
                    }
                    else
                    {
                        
                    }
                }


                ArregloPanelBody2[i] = new Panel();
                ArregloPanelBody2[i].ID = "collapse2" + i;
                ArregloPanelBody2[i].CssClass =  (x==0)? "accordion-body collapse" : "accordion-body collapse in";

                ArregloPanelInstancias2[i].Controls.Add(link2[i]);
                ArregloPanelGroup2[i].Controls.Add(ArregloPanelInstancias2[i]);
                

            }


            for (int j = 0; j < TablaCargos2.Rows.Count; j++)
            {

                ArregloCheckCargos2[j] = new CheckBox();
                ArregloCheckCargos2[j].CssClass = "ArregloCheckCargos";
                ArregloCheckCargos2[j].ID = "ArregloCheckCargos2" + TablaCargos2.Rows[j]["idinstanciadetalle"].ToString();
                ArregloCheckCargos2[j].Attributes.Add("name", "NArregloCheckCargos2" + TablaCargos2.Rows[j]["idinstanciadetalle"].ToString());


                ArregloLabelCargos2[j] = new Label();
                ArregloLabelCargos2[j].ID = "ArregloLabelCargos2" + TablaCargos2.Rows[j]["idinstanciadetalle"].ToString();
                ArregloLabelCargos2[j].CssClass = "ArregloLabelCargos";
                ArregloLabelCargos2[j].Text = TablaCargos2.Rows[j]["NombreInstanciadetalle"].ToString();

                IdCargos2[j] = Convert.ToInt32(TablaCargos2.Rows[j]["idinstanciadetalle"].ToString());


                ArregloDropDownListCargos2[j] = new DropDownList();
                ArregloDropDownListCargos2[j].ID = "ArregloDropDownListCargos2" + TablaCargos2.Rows[j]["idinstanciadetalle"].ToString();
                ArregloDropDownListCargos2[j].CssClass = "ArregloDropDownListCargos";
                ArregloDropDownListCargos2[j].Items.Insert(0, new ListItem("Selccione Opcion...", " "));
                ArregloDropDownListCargos2[j].AppendDataBoundItems = true;


                for (int k = 0; k < Convert.ToInt32(TablaCargos2.Rows[j]["CupoInstanciadetalle"].ToString()); k++)
                {
                    ArregloDropDownListCargos2[j].Items.Add("" + (k + 1));
                    

                }



                for (int i = 0; i < TablaCargos3.Rows.Count; i++)
                {
                    if (TablaCargos2.Rows[j]["IDINSTANCIADETALLE"].ToString() == TablaCargos3.Rows[i]["INSD_ID"].ToString())
                    {
                        ArregloCheckCargos2[j].Checked = true;
                        ArregloDropDownListCargos2[j].SelectedValue = TablaCargos3.Rows[i]["COND_CUPOS"].ToString();
                    }
                }
               

                ArregloPanelCargos2[j] = new Panel();
                ArregloPanelCargos2[j].CssClass = "accordion-inner";

                ArregloPanelCargos2[j].Controls.Add(ArregloCheckCargos2[j]);
                ArregloPanelCargos2[j].Controls.Add(ArregloLabelCargos2[j]);
                ArregloPanelCargos2[j].Controls.Add(ArregloDropDownListCargos2[j]);

            }


            for (int i = 0; i < TablaInstancias2.Rows.Count; i++)
            {
                for (int j = 0; j < TablaCargos2.Rows.Count; j++)
                {
                    if (TablaInstancias2.Rows[i]["idinstancia"].ToString() == TablaCargos2.Rows[j]["instanciadetalleinstancia"].ToString())
                    {

                        ArregloPanelBody2[i].Controls.Add(ArregloPanelCargos2[j]);
                        ArregloPanelGroup2[i].Controls.Add(ArregloPanelBody2[i]);
                    }
                }

                Panel4.Controls.Add(ArregloPanelGroup2[i]);

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


            ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "nueva();", true);



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
                //cnvt.TituloConvocatoria = tituloconvo.Value;
                cnvt.DescripcionConvocatoria = descripcion.Value;
                cnvt.Fechainicioinscripcion = Convert.ToDateTime(InicioInscripcion.Value).ToString("dd/MM/yyy");
                cnvt.Fechafininscripcion = Convert.ToDateTime(ffindeinscripcion.Value).ToString("dd/MM/yyy");
                cnvt.Fechapublicacionhabilitado = Convert.ToDateTime(candidatoshconvo.Value).ToString("dd/MM/yyy");
                cnvt.Fechapublicacionjurados = Convert.ToDateTime(juradosconvoca.Value).ToString("dd/MM/yyy");
                cnvt.Fechaeleccionespresenciales = Convert.ToDateTime(epresenciaconvo.Value).ToString("dd/MM/yyy");
                cnvt.Fechaeleccionesdistancia = Convert.ToDateTime(edistanciaconvo.Value).ToString("dd/MM/yyy");
                cnvt.Fechapublicacionresultados = Convert.ToDateTime(ffindeinscripcion.Value).ToString("dd/MM/yyy");
                cnvt.fecharegistro = Convert.ToDateTime(ffindeinscripcion.Value).ToString("dd/MM/yyy");
                cnvt.Estado = "BORRADOR";

                var Response1 = ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("ICnvt", Method.POST), cnvt);
                var Response2 = ConsumirAppi.ConsumirPost(Rutas.ConvocatoriaDetalle, new RestRequest("InsertarConvocatoriaDetalle", Method.POST), cond);

                //Response.Redirect(Request.RawUrl);

                FRegistro.Value = "";
                NConv.Value = "";
                InicioInscripcion.Value = null;
                ffindeinscripcion.Value = null;
                resultadosconvo.Value = null;
                juradosconvoca.Value = null;
                candidatoshconvo.Value = null;
                epresenciaconvo.Value = null;
                edistanciaconvo.Value = null;
                descripcion.Value = "";


                ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
                ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "Refresh_page();", true);

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
            ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("MECnvt", Method.POST), new Convocatoria { IdConvocatoria = z, Estado = "PUBLICADO" });
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            z = e.CommandArgument.ToString();
            ConsumirAppi.ConsumirPost(Rutas.Convocatoria, new RestRequest("MECnvt", Method.POST), new Convocatoria { IdConvocatoria = z, Estado = "PUBLICADO" });
        }

        protected void LBPblc_Command(object sender, CommandEventArgs e)
        {

            z = e.CommandArgument.ToString();

            //TablaInstancias1 = CInstancia(new Convocatoria() { IdConvocatoria = z }, true);
            //int NTablaInstancias1 = TablaInstancias1.Rows.Count;

            //ArregloPanelGroup1 = new Panel[NTablaInstancias1];
            //ArregloPanelInstancias1 = new Panel[NTablaInstancias1];
            //ArregloPanelBody1 = new Panel[NTablaInstancias1];
            //ArregloLabelInstancias1 = new Label[NTablaInstancias1];

            ////LinkButton []Editar = new LinkButton[TablaInstancias1.Rows.Count];

            //LinkButton[] Borrar;

            //LinkButton Editar = new LinkButton();


            //for (int i = 0; i < NTablaInstancias1; i++)
            //{


            //    ArregloPanelGroup1[i] = new Panel();
            //    ArregloPanelGroup1[i].CssClass = "accordion-group";

            //    ArregloPanelInstancias1[i] = new Panel();
            //    ArregloPanelInstancias1[i].CssClass = "accordion-heading";

            //    ArregloPanelBody1[i] = new Panel();
            //    ArregloPanelBody1[i].ID = "collapseb" + i;
            //    ArregloPanelBody1[i].CssClass = "accordion-body in";


            //    //Borrar[i] = new LinkButton();
            //    ////Borrar[i].ID = "link" + i;
            //    //Borrar[i].CssClass = "icon-trash";
            //    //Borrar[i].Text = TablaInstancias.Rows[i]["nombreInstancia"].ToString();
            //    //Borrar[i].Attributes.Add("data-toggle", "collapse");
            //    //Borrar[i].Attributes.Add("data-parent", "#accordion2");
            //    //Borrar[i].Attributes.Add("href", "#collapse" + i);

            //    ArregloLabelInstancias1[i] = new Label();
            //    ArregloLabelInstancias1[i].Text = TablaInstancias1.Rows[i]["NOMBREINSTANCIA"].ToString();

            //    ArregloPanelInstancias1[i].Controls.Add(ArregloLabelInstancias1[i]);
            //    ArregloPanelGroup1[i].Controls.Add(ArregloPanelInstancias1[i]);

            //}

            //TablaCargos1 = CInstancia(new Convocatoria() { IdConvocatoria = z }, false);
            //NTablaCargos1 = TablaCargos1.Rows.Count;
            //ArregloPanelCargos1 = new Panel[NTablaCargos1];
            //ArregloLabelCargos1 = new Label[NTablaCargos1];
            //Borrar = new LinkButton[NTablaCargos1];
            //IdCargos1 = new int[NTablaCargos1];

            //for (int j = 0; j < NTablaCargos1; j++)
            //{
            //    ArregloLabelCargos1[j] = new Label();
            //    ArregloLabelCargos1[j].ID = "ArregloLabelCargosb" + TablaCargos1.Rows[j]["INSD_ID"].ToString();
            //    ArregloLabelCargos1[j].Text = TablaCargos1.Rows[j]["INSD_NOMBRE"].ToString();

            //    IdCargos1[j] = Convert.ToInt32(TablaCargos1.Rows[j]["INSD_ID"].ToString());

            //    //link1[j] = new HyperLink();

            //    //link1[j].Text = "Inscribir";

            //    ArregloPanelCargos1[j] = new Panel();
            //    ArregloPanelCargos1[j].CssClass = "accordion-inner";

            //    ArregloPanelCargos1[j].Controls.Add(ArregloLabelCargos1[j]);
            //    ArregloPanelCargos1[j].Controls.Add(Borrar[j]);


            //}

            //for (int i = 0; i < NTablaInstancias1; i++)
            //{
            //    for (int j = 0; j < NTablaCargos1; j++)
            //    {
            //        if (TablaInstancias1.Rows[i]["IdInstancia"].ToString() == TablaCargos1.Rows[j]["INST_ID"].ToString())
            //        {
            //            ArregloPanelBody1[i].Controls.Add(ArregloPanelCargos1[j]);

            //        }
            //    }
            //    ArregloPanelGroup1[i].Controls.Add(ArregloPanelBody1[i]);
            //    panel3.Controls.Add(ArregloPanelGroup1[i]);

            //}


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
        //    ArregloPanelCargos = new Panel[TablaCargos.Rows.Count];
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

        //        ArregloPanelCargos[j] = new Panel();
        //        ArregloPanelCargos[j].CssClass = "accordion-inner";

        //        ArregloPanelCargos[j].Controls.Add(ArregloCheckCargos[j]);
        //        ArregloPanelCargos[j].Controls.Add(ArregloLabelCargos[j]);
        //        ArregloPanelCargos[j].Controls.Add(ArregloDropDownListCargos[j]);

        //    }


        //    for (int i = 0; i < TablaInstancias.Rows.Count; i++)
        //    {
        //        for (int j = 0; j < TablaCargos.Rows.Count; j++)
        //        {
        //            if (TablaInstancias.Rows[i]["idinstancia"].ToString() == TablaCargos.Rows[j]["instanciadetalleinstancia"].ToString())
        //            {

        //                ArregloPanelBody[i].Controls.Add(ArregloPanelCargos[j]);
        //                ArregloPanelGroup[i].Controls.Add(ArregloPanelBody[i]);
        //            }
        //        }

        //        Panel1.Controls.Add(ArregloPanelGroup[i]);

        //    }


        }
    }
}

















