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
        private Conexion conx = new Conexion();
        public Parametro[] para;
        public string IdInstanciadetalle {get;set;}
        public string IdInstancia {get;set;}
        public string NombreInstanciadetalle {get;set;}
        public string TipoDeElector {get;set;}
        public string CupoInstanciadetalle {get;set;}
        public string VotacionInstanciadetalle {get;set;}
        public string EstadoInstanciadetalle {get;set;}
        public string PeriodoInstranciadetalle {get;set;}

        public DataTable ConsultarInstanciaDetalle()
        {
            return conx.realizarConsulta("PR_CNST_INSD", "CR_CNST_INSD", null);
        }
        public Parametro[] AgregarInstanciaDetalle(InstanciaDetalle obj)
        {
            para = new Parametro[6];

            para[0] = new Parametro("PINSD_NOMBRE", obj.NombreInstanciadetalle);
            para[1] = new Parametro("PINSD_TIPO_ELECTOR", obj.TipoDeElector);
            para[2] = new Parametro("PINSD_VOTACION", obj.VotacionInstanciadetalle);
            para[3] = new Parametro("PINSD_CUPOS", obj.CupoInstanciadetalle);
            para[4] = new Parametro("PINSD_INSTANCIA", obj.IdInstancia);
            para[5] = new Parametro("PINSD_PERIODO", obj.PeriodoInstranciadetalle);


            return para;
        }

        public bool ModificarInstanciaDetalle(InstanciaDetalle obj)
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

            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_UPDT_INSD", para);

            return conx.realizarTransaccion(trans);
        }


        public DataTable ConsultarCargosInstancia(InstanciaDetalle obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PINSD_INSTANCIA", obj.IdInstancia);

            return conx.realizarConsulta("PR_CNST_INSD_POR_INST", "CR_CNST_INSD_POR_INST", para);
        }

        public bool InsertarInstanciaDetalle(InstanciaDetalle obj)
        {
            Transacion [] trans = new Transacion[1];
            trans[0] = new Transacion("PR_NSRT_INTD",AgregarInstanciaDetalle(obj));

            return conx.realizarTransaccion(trans);
        }

        public bool InstanciaDetalleConformacion(InstanciaDetalle obj)
        {
            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_NSRT_INTD", AgregarInstanciaDetalle(obj));

            return conx.realizarTransaccion(trans);
        }

    }
}