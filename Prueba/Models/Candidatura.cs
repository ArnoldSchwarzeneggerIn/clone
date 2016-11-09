using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Candidatura
    {
        Conexion conx = new Conexion();
        Login logi = new Login();
        Parametro[] para;
        public string cand_id { get; set; }
        public string cand_convocatoriadetalle { get; set; }
        public string cand_cedula { get; set; }
        public string cand_plancha { get; set; }
        public string cand_observacion { get; set; }
        public string cand_fechainscripcion{ get; set; }
        public string cand_estado { get; set; }

        public Parametro[] AgregarCandidatura(Candidatura obj)
        {
            para = new Parametro[7];

            para[0] = new Parametro("PCAND_ID", obj.cand_id);
            para[1] = new Parametro("PCAND_CONVOCATORIADETALLE", obj.cand_convocatoriadetalle);
            para[2] = new Parametro("PCAND_CEDULA", obj.cand_cedula);
            para[3] = new Parametro("PCAND_PLANCHA", obj.cand_plancha);
            para[4] = new Parametro("PCAND_OBSERVACION", obj.cand_observacion);
            para[5] = new Parametro("PCAND_FECHAINSCRIPCION", obj.cand_fechainscripcion);
            para[6] = new Parametro("PCAND_ESTADO", obj.cand_estado);

            return para;
        }

        //public DataTable ConsultarCandidato()
        //{
        //    return conx.realizarConsulta("","")
        //}

        //public DataTable ConsultarPrograma()
        //{
        //    para = new Parametro[1];
        //    para = new Parametro[1];
        //    para[0] = new Parametro("USUARIO", usuario);
        //    return conx.realizarConsulta("PR_CONSULTARPROGRAMA", "CR_CONSP",)
        //}

        public bool InsertarCandidadatura(Candidatura obj)
        {
            Transacion[] list = new Transacion[1];
            list[0] = new Transacion("PR_NSRT_CAND", AgregarCandidatura(obj));
            return conx.realizarTransaccion(list);
        }

    }
}