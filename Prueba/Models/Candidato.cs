using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Candidato
    {
        Conexion conx = new Conexion();
        Login logi = new Login();
        Parametro[] para;
        public string Candidatura { get; set; }
        public string FechaInscripcion { get; set; }
        public string Observacion { get; set; }
        public string CandidatoCedula { get; set; }
        public string CandidatoConvocatoria { get; set; }
        public string CandidatoInstancia { get; set; }
        public string CandidatoPrograma { get; set; }

        public Parametro[] AgregarParametros(Candidato obj)
        {
            para = new Parametro[3];

            para[0] = new Parametro("CAND_OBSERVACION", obj.Observacion);
            para[1] = new Parametro("CAND_CONVOCATORIA", obj.CandidatoConvocatoria);
            para[2] = new Parametro("CAND_FK_CEDU", obj.CandidatoCedula);

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

        public bool InsertarCandidato(Candidato obj)
        {
            Transacion[] list = new Transacion[1];
          //  list[0] = new Transacion("PR_REGISTRARCANDIDATO", GetParameters(obj));
            return conx.realizarTransaccion(list);
        }

       
    }
}