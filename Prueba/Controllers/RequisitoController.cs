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
    public class RequisitoController : ApiController
    {
        Requisito req = new Requisito();

        [HttpPost]
        public IHttpActionResult ConsultarPorInsd(Requisito obj)
        {
            //DataTable data = req.ConsultarPorInstanciaDetalle(obj);
            //DataView view = new DataView(data);

            //DataTable CANDIDATOS = view.ToTable(true,"CAND_ID", "CAND_CONVOCATORIADETALLE","CAND_CEDULA","CAND_PLANCHA","CAND_OBSERVACION", "CAND_FECHAINSCRIPCION","CAND_ESTADO");


            //string[] CAND_ID = new string[CANDIDATOS.Rows.Count];
            //string[] CAND_CONVOCATORIA = new string[CANDIDATOS.Rows.Count];
            //string[] CAND_CEDULA = new string[CANDIDATOS.Rows.Count];
            //string[] CAND_PLANCHA = new string[CANDIDATOS.Rows.Count];
            //string[] CAND_OBSERVACION = new string[CANDIDATOS.Rows.Count];
            //string[] CAND_FECHAINSCRIPCION = new string[CANDIDATOS.Rows.Count];
            //string[] CAND_ESTADO = new string[CANDIDATOS.Rows.Count];

            //for (int i = 0; i < CANDIDATOS.Rows.Count; i++)
            //{

            //    CAND_ID[i] = CANDIDATOS.Rows[i]["CAND_ID"].ToString();
            //    CAND_CONVOCATORIA[i] = CANDIDATOS.Rows[i]["CAND_CONVOCATORIA"].ToString();
            //    CAND_CEDULA[i] = CANDIDATOS.Rows[i]["CAND_CEDULA"].ToString();
            //    CAND_PLANCHA[i] = CANDIDATOS.Rows[i]["CAND_PLANCHA"].ToString();
            //    CAND_OBSERVACION[i] = CANDIDATOS.Rows[i]["CAND_OBSERVACION"].ToString();
            //    CAND_FECHAINSCRIPCION[i] = CANDIDATOS.Rows[i]["CAND_FECHAINSCRIPCION"].ToString();
            //    CAND_ESTADO[i] = CANDIDATOS.Rows[i]["CAND_ESTADO"].ToString();
            //}

            return Json(req.ConsultarPorInstanciaDetalle(obj));





        }

    }
}
