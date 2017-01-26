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
    public partial class WebForm6 : System.Web.UI.Page
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //string z = Request.Params["z"];
                string z = "1";


                //seleccionar cargos

                //GENERALES
                //Fill DataTable with all position
                //TablaCargos = CInstancia();
                TablaCargosA = CInstancia();

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


                    if (!IsPostBack)
                    {

                        for (int i = 0; i < TablaCargosAA.Rows.Count; i++)
                        {
                            if (TablaCargosA.Rows[j]["IDINSTANCIADETALLE"].ToString() == TablaCargosAA.Rows[i]["INSD_ID"].ToString())
                            {
                                ArregloCheckCargosA[j].Checked = true;
                                ArregloDropDownListCargosA[j].SelectedValue = TablaCargosAA.Rows[i]["COND_CUPOS"].ToString();
                            }
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

                ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "alertss", "PBrrd()", true);
                //ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "nueva();", true);



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

        protected void NuevoClick12(object sender, EventArgs e)
        {

        }

        protected void ICnvtC(object sender, EventArgs e)
        {

        }


        protected void Button4_Click(object sender, EventArgs e)
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
                        objA = objA + 1;



                        //ArregloCheckCargosA[i].Checked = false;
                        //ArregloDropDownListCargosA[i].SelectedValue = " ";
                    }
                    catch (Exception Ex)
                    {

                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: 'Su registro no se ha almacenado',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                    }

                }


            }



            ConvocatoriaDetalle cond5 = new ConvocatoriaDetalle();
            cond5.ConvocatoriaConvocatoriaDetalle = z;

            var response2 = ConsumirAppi.ConsumirPost(Rutas.ConvocatoriaDetalle, new RestRequest("DCnvd", Method.POST), cond5);
            if (Convert.ToString(response2.StatusCode) == "OK")
            {
                var Response3 = ConsumirAppi.ConsumirPost(Rutas.ConvocatoriaDetalle, new RestRequest("MCnvd", Method.POST), condA);
                if (Convert.ToString(Response3.StatusCode) == "OK")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Registro Exitoso', text: 'Registro exitoso.',icon: 'icon-checkmark3', type: 'success'});}); ", true);
                    ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "Refresh_page();", true);
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



            ScriptManager.RegisterStartupScript(this.Page, GetType(), "alertss", "Refresh_page();", true);
        }




        protected void Salir_Click(object sender, EventArgs e)
        {

        }


        protected void Button4_Click1(object sender, EventArgs e)
        {

        }





    }


}