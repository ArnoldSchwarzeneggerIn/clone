using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Requisito
    {
        public Parametro[] Para;
        private string idRequisito = string.Empty;
        public string IdRequisito
        {
            get { return idRequisito; }
            set { idRequisito = value; }
        }


        private string nombreRequisito = string.Empty;
        public string NombreRequisito
        {
            get { return nombreRequisito; }
            set { nombreRequisito = value; }
        }


        private string estadoRequisito = string.Empty;
        public string EstadoRequisito
        {
            get
            {
                return estadoRequisito;
            }

            set
            {
                estadoRequisito = value;
            }
        }

        private string soporteRequisito = string.Empty;

        public string SoporteRequisito
        {
            get
            {
                return soporteRequisito;
            }

            set
            {
                soporteRequisito = value;
            }
        }

        public string DetalleinstanciaRequisito
        {
            get
            {
                return detalleinstanciaRequisito;
            }

            set
            {
                detalleinstanciaRequisito = value;
            }
        }

        private string detalleinstanciaRequisito = string.Empty;

        public Parametro[] Insertar()
        {
            Para = new Parametro[3];
            Para[0] = new Parametro("PREQU_NOMBRE", NombreRequisito);
            Para[1] = new Parametro("PREQU_SOPORTE", SoporteRequisito);
            Para[2] = new Parametro("PREQU_INSTANCIADETALLE", DetalleinstanciaRequisito);

            return Para;
        }

        public Parametro[] Modificar()
        {
            Para = new Parametro[3];
            Para[0] = new Parametro("PREQU_NOMBRE", NombreRequisito);
            Para[1] = new Parametro("PREQU_ESTADO", EstadoRequisito);
            Para[2] = new Parametro("PREQU_SOPORTE", SoporteRequisito);
            Para[3] = new Parametro("PREQU_INSTANCIADETALLE", DetalleinstanciaRequisito);

            return Para;
        }


        public Parametro[] ConsultarPorInstanciaDetalle()
        {
            Para = new Parametro[1];
            Para[0] = new Parametro("PREQU_INSTANCIADETALLE", DetalleinstanciaRequisito);
            return Para;
        }

        public Parametro[] consultarrequisitos()
        {
            Para = new Parametro[1];
            Para[0] = new Parametro("PCOND_ID", DetalleinstanciaRequisito);
            return Para;
        }
    }
}