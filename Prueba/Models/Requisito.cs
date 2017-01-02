using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Requisito
    {
        public Parametro[] Para;
        public Conexion conx = new Conexion();
        public string IdRequisito {get;set;}

        public string NombreRequisito {get;set;}
     
        public string EstadoRequisito {get;set;}
      
        public string SoporteRequisito {get;set;}

        public string DetalleinstanciaRequisito {get;set;}

        public Parametro[] ParametrosInsertar()
        {
            Para = new Parametro[3];
            Para[0] = new Parametro("PREQU_NOMBRE", NombreRequisito);
            Para[1] = new Parametro("PREQU_SOPORTE", SoporteRequisito);
            Para[2] = new Parametro("PREQU_INSTANCIADETALLE", DetalleinstanciaRequisito);

            return Para;
        }

        public Parametro[] ParametrosModificar()
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
           
            return Para;
        }

        public Parametro[] consultarrequisitos()
        {
            Para = new Parametro[1];
            Para[0] = new Parametro("PCOND_ID", DetalleinstanciaRequisito);
            return Para;
        }

        public DataTable ConsultarPorInstanciaDetalle(Requisito requ)
        {
            Para = new Parametro[1];
            Para[0] = new Parametro("PREQU_INSTANCIADETALLE", requ.DetalleinstanciaRequisito);

            return conx.realizarConsulta("PR_CNST_RQST_POR_INSD", "PR_CNST_RQST_POR_INSD", Para);
        }

    }
}