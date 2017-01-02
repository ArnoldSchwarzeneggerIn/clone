using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;

namespace Prueba.Controllers
{
    public class VotacionController : ApiController
    {
        Votacion vota = new Votacion();

        [HttpPost]
        public IHttpActionResult CVotacion(Votacion obj)
        {

        //CONV_ID
        //CONV_TITULO
        //CONV_DESCRIPCION
        //CONV_FECH_INIC_INSC
        //CONV_FECH_FIN_INSC
        //COND_ID
        //COND_CONVOCATORIA
        //COND_INSTANCIADETALLE
        //COND_CUPOS
        //COND_ESTADO
        //public string INSD_ID
        //public string INSD_NOMBRE
        //public string INST_ID
        //public string INST_NOMBRE
        //public string PROG_ID
        //public string PROG_NOMBRE
        //public string FACU_ID
        //public string FACU_NOMBRE
        //public string TIPE_NOMBRE
        //public string NOMBRE
        //public string PROP_DETALL

        ////GENERALES
        //    DataTable data = vota.Cvotacion(obj);
        //    DataView view = new DataView(data);

        //    //CONVOCATORIA

        //    DataTable CONVOCATORIA = view.ToTable(true, "CONV_ID", "CONV_TITULO","CONV_DESCRIPCION", "CONV_FECH_INIC_INSC", "CONV_FECH_FIN_INSC");

            
        //    string[] CONV_ID = new string[CONVOCATORIA.Rows.Count];
        //    string[] CONV_TITULO = new string[CONVOCATORIA.Rows.Count];
        //    string[] CONV_DESCRIPCION = new string[CONVOCATORIA.Rows.Count];
        //    string[] CONV_FECH_INIC_INSC = new string[CONVOCATORIA.Rows.Count];
        //    string[] CONV_FECH_FIN_INSC = new string[CONVOCATORIA.Rows.Count];


        //    for (int i = 0; i < CONVOCATORIA.Rows.Count; i++)
        //    {
                
        //        CONV_ID[i] = CONVOCATORIA.Rows[i]["CONV_ID"].ToString();
        //        CONV_TITULO[i] = CONVOCATORIA.Rows[i]["CONV_TITULO"].ToString();
        //        CONV_DESCRIPCION[i] = CONVOCATORIA.Rows[i]["CONV_DESCRIPCION"].ToString();
        //        CONV_FECH_INIC_INSC[i] = CONVOCATORIA.Rows[i]["CONV_FECH_INIC_INSC"].ToString();
        //        CONV_FECH_FIN_INSC[i] = CONVOCATORIA.Rows[i]["CONV_FECH_FIN_INSC"].ToString();
        //    }

        //    //CONVOCATOIA DETALLE

        //    DataTable CDETALLE = view.ToTable(true, "COND_ID", "COND_CONVOCATORIA", "COND_INSTANCIADETALLE", "COND_CUPOS", "COND_ESTADO");

        //    string[] COND_ID = new string[CDETALLE.Rows.Count];
        //    string[] COND_CONVOCATORIA = new string[CDETALLE.Rows.Count];
        //    string[] COND_INSTANCIADETALLE = new string[CDETALLE.Rows.Count];
        //    string[] COND_CUPOS = new string[CDETALLE.Rows.Count];
        //    string[] COND_ESTADO = new string[CDETALLE.Rows.Count];


        //    string[] cdetalle = new string[CDETALLE.Rows.Count];

        //    for (int i = 0; i < CDETALLE.Rows.Count; i++)
        //    {
        //        COND_ID[i] = CDETALLE.Rows[i]["COND_ID"].ToString();
        //        COND_CONVOCATORIA[i] = CDETALLE.Rows[i]["COND_CONVOCATORIA"].ToString();
        //        COND_INSTANCIADETALLE[i] = CDETALLE.Rows[i]["COND_INSTANCIADETALLE"].ToString();
        //        COND_CUPOS[i] = CDETALLE.Rows[i]["COND_CUPOS"].ToString();
        //        COND_ESTADO[i] = CDETALLE.Rows[i]["COND_ESTADO"].ToString();
        //    }


        //    //CANDIDATO

        //    DataTable CANDIDATO = view.ToTable(true, "NOMBRE");

        //    string[] candidato = new string[CANDIDATO.Rows.Count];

        //    for (int i = 0; i < CANDIDATO.Rows.Count; i++)
        //    {
        //        candidato[i] = CANDIDATO.Rows[i]["NOMBRE"].ToString();

        //    }


        //    //PROPUESTA
        //    DataTable PROPUESTA = view.ToTable(true, "PROP_ID", "PROP_DETALLE");

        //    string[] propuesta = new string[PROPUESTA.Rows.Count];
            
        //    for (int i = 0; i < PROPUESTA.Rows.Count; i++)
        //    {
        //        propuesta[i] = PROPUESTA.Rows[i]["PROP_DETALLE"].ToString();
                
        //    }


        //    //return Json(new
        //    //{

        //    //    Cid = CONV_ID,
        //    //    Ct = CONV_TITULO,
        //    //    Cd = CONV_DESCRIPCION,
        //    //    Cfi = CONV_FECH_INIC_INSC,
        //    //    Cff=CONV_FECH_FIN_INSC,
        //    //    Cdid=COND_ID,
        //    //    cdc=COND_CONVOCATORIA,
        //    //    cdi=COND_INSTANCIADETALLE,
        //    //    cdcp=COND_CUPOS,
        //    //    cde=COND_ESTADO,
        //    //    Candito =  candidato,
        //    //    Propuesta = propuesta


        //    //});

            return Json(vota.Cvotacion(obj));
        }
    }

    
    }

