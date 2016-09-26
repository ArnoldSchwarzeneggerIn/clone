using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Candidato
    {

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

        public Parametro[] InsertarCandidato()
        {
            para = new Parametro[3];

            para[0] = new Parametro("CAND_OBSERVACION", this.Observacion);
            para[1] = new Parametro("CAND_CONVOCATORIA", this.CandidatoConvocatoria1);
            para[2] = new Parametro("CAND_FK_CEDU", this.CandidatoCedula1);
            return para;
        }
    }
}