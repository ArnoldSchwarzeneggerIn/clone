using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class InstanciaDetalle
    {
        Conexion conx = new Conexion();
        private Parametro[] para;
        private string idInstanciadetalle = string.Empty;
        private string idInstancia = string.Empty;
        private string nombreInstanciadetalle = string.Empty;
        private string tipoDeElector = string.Empty;
        private string cupoInstanciadetalle = string.Empty;
        private string votacionInstanciadetalle = string.Empty;
        private string estadoInstanciadetalle = string.Empty;
        private string periodoInstranciadetalle = string.Empty;

        public string IdInstanciadetalle
        {
            get
            {
                return idInstanciadetalle;
            }

            set
            {
                idInstanciadetalle = value;
            }
        }

        public string IdInstancia
        {
            get
            {
                return idInstancia;
            }

            set
            {
                idInstancia = value;
            }
        }

        public string NombreInstanciadetalle
        {
            get
            {
                return nombreInstanciadetalle;
            }

            set
            {
                nombreInstanciadetalle = value;
            }
        }

        public string TipoDeElector
        {
            get
            {
                return tipoDeElector;
            }

            set
            {
                tipoDeElector = value;
            }
        }

        public string CupoInstanciadetalle
        {
            get
            {
                return cupoInstanciadetalle;
            }

            set
            {
                cupoInstanciadetalle = value;
            }
        }

        public string VotacionInstanciadetalle
        {
            get
            {
                return votacionInstanciadetalle;
            }

            set
            {
                votacionInstanciadetalle = value;
            }
        }

        public string EstadoInstanciadetalle
        {
            get
            {
                return estadoInstanciadetalle;
            }

            set
            {
                estadoInstanciadetalle = value;
            }
        }

        public string PeriodoInstranciadetalle
        {
            get
            {
                return periodoInstranciadetalle;
            }

            set
            {
                periodoInstranciadetalle = value;
            }
        }

        public DataTable Consultar()
        {
            return conx.realizarConsulta("PR_CNST_INSC", "CR_CNST_INSC", null);
        }
        public Parametro[] AgregarInstanciaDetalle(InstanciaDetalle obj)
        {
            para = new Parametro[6];

            para[0] = new Parametro("PINSD_NOMBRE", obj.NombreInstanciadetalle);
            para[1] = new Parametro("PINSD_TIPO_ELECTOR", obj.TipoDeElector);
            para[2] = new Parametro("PINSD_VOTACION", obj.VotacionInstanciadetalle);
            para[3] = new Parametro("PINSD_CUPOS", obj.CupoInstanciadetalle);
            para[4] = new Parametro("PINSD_INSTANCIA", obj.CupoInstanciadetalle);
            para[5] = new Parametro("PINSD_PERIODO", obj.PeriodoInstranciadetalle);


            return para;
        }

        public Parametro[] ModificarInstanciaDetalle(InstanciaDetalle obj)
        {
            para = new Parametro[8];

            para[0] = new Parametro("PINSD_ID", obj.IdInstanciadetalle);
            para[1] = new Parametro("PINSD_NOMBRE", obj.NombreInstanciadetalle);
            para[2] = new Parametro("PINSD_TIPO_ELECTOR", obj.TipoDeElector);
            para[3] = new Parametro("PINSD_VOTACION", obj.VotacionInstanciadetalle);
            para[4] = new Parametro("PINSD_CUPOS", obj.CupoInstanciadetalle);
            para[5] = new Parametro("PINSD_ESTADO", obj.EstadoInstanciadetalle);
            para[6] = new Parametro("PINSD_INSTANCIA", obj.IdInstancia);
            para[7] = new Parametro("PINSD_PERIODO", obj.PeriodoInstranciadetalle);

            return para;
        }


        public DataTable ConsultarCargosInstancia(InstanciaDetalle obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINSD_INSTANCIA", obj.IdInstancia);

            return conx.realizarConsulta("PR_CNST_INSD_POR_INST", "CR_CNST_INSD_POR_INST", para);
        }

    }
}