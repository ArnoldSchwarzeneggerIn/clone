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
        public Parametro[] Insertar()
        {
            para = new Parametro[6];

            para[0] = new Parametro("PINSD_NOMBRE", NombreInstanciadetalle);
            para[1] = new Parametro("PINSD_TIPO_ELECTOR", TipoDeElector);
            para[2] = new Parametro("PINSD_VOTACION", VotacionInstanciadetalle);
            para[3] = new Parametro("PINSD_CUPOS", CupoInstanciadetalle);
            para[4] = new Parametro("PINSD_INSTANCIA", CupoInstanciadetalle);
            para[5] = new Parametro("PINSD_PERIODO", PeriodoInstranciadetalle);


            return para;
        }

        public Parametro[] Modificar()
        {
            para = new Parametro[8];

            para[0] = new Parametro("PINSD_ID", IdInstanciadetalle);
            para[1] = new Parametro("PINSD_NOMBRE", NombreInstanciadetalle);
            para[2] = new Parametro("PINSD_TIPO_ELECTOR", TipoDeElector);
            para[3] = new Parametro("PINSD_VOTACION", VotacionInstanciadetalle);
            para[4] = new Parametro("PINSD_CUPOS", CupoInstanciadetalle);
            para[5] = new Parametro("PINSD_ESTADO", EstadoInstanciadetalle);
            para[6] = new Parametro("PINSD_INSTANCIA", IdInstancia);
            para[7] = new Parametro("PINSD_PERIODO", PeriodoInstranciadetalle);

            return para;
        }

    }
}