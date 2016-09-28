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
        Loggin logi = new Loggin();
        private string Candidatura = string.Empty;
        private string FechaInscripcion = string.Empty;
        private string observacion = string.Empty;
        private string CandidatoCedula = string.Empty;
        private string CandidatoConvocatoria = string.Empty;
        private string CandidatoInstancia = string.Empty;
        private string CandidatoPrograma = string.Empty;
        Parametro[] para;
        public string CandidatoCedula1
        {
            get
            {
                return CandidatoCedula;
            }

            set
            {
                CandidatoCedula = value;
            }
        }

        public string CandidatoConvocatoria1
        {
            get
            {
                return CandidatoConvocatoria;
            }

            set
            {
                CandidatoConvocatoria = value;
            }
        }

        public string CandidatoInstancia1
        {
            get
            {
                return CandidatoInstancia;
            }

            set
            {
                CandidatoInstancia = value;
            }
        }

        public string CandidatoPrograma1
        {
            get
            {
                return CandidatoPrograma;
            }

            set
            {
                CandidatoPrograma = value;
            }
        }

        public string Observacion
        {
            get
            {
                return observacion;
            }

            set
            {
                observacion = value;
            }
        }

        public string FechaInscripcion1
        {
            get
            {
                return FechaInscripcion;
            }

            set
            {
                FechaInscripcion = value;
            }
        }

        public string Candidatura1
        {
            get
            {
                return Candidatura;
            }

            set
            {
                Candidatura = value;
            }
        }

        public Parametro[] GetParameters(Candidato obj)
        {
            para = new Parametro[3];

            para[0] = new Parametro("CAND_OBSERVACION", obj.Observacion);
            para[1] = new Parametro("CAND_CONVOCATORIA", obj.CandidatoConvocatoria1);
            para[2] = new Parametro("CAND_FK_CEDU", obj.CandidatoCedula1);
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
            list[0] = new Transacion("PR_REGISTRARCANDIDATO", GetParameters(obj));
            return conx.realizarTransaccion(list);
        }


     



    }
}