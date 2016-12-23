using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class ConvocatoriaDetalle
    {

        Conexion conx = new Conexion();
        public Parametro[] para;
        public Transaction[] tran;
        public string IdConvocatoriaDetalle { set; get; }
        public string ConvocatoriaConvocatoriaDetalle { set; get; }
        public string InstanciadetalleConvocatoriaDetalle { set; get; }
        public string CuposConvocatoriaDetalle { set; get; }
        public string EstadoConvocatoriaDetalle { set; get; }


        public ConvocatoriaDetalle()
        {
           
        }


        public Parametro[] ParametrosInsertar()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCOND_INSTANCIADETALLE", InstanciadetalleConvocatoriaDetalle);
            para[1] = new Parametro("PCOND_CUPOS", CuposConvocatoriaDetalle);

            return para;

        }


        public Parametro[] Eliminar()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONVOCATORIA_ID", ConvocatoriaConvocatoriaDetalle);
            para[1] = new Parametro("PCARGO_ID", InstanciadetalleConvocatoriaDetalle);

            return para;

        }


        public Parametro[] Modificar()
        {
            para = new Parametro[4];
            //para[0] = new Parametro("PCOND_ID", IdConvocatoriaDetalle);
            //para[1] = new Parametro("PCOND_CONVOCATORIA", ConvocatoriaConvocatoriaDetalle);


            return para;


        }


        public Parametro[] ConsultarInstanciasC()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONV_ID", ConvocatoriaConvocatoriaDetalle);
            para[1] = new Parametro("INSTA", IdConvocatoriaDetalle);
            return para;
        }
        
        //public bool InsertarConvocatoriaDetalle(ConvocatoriaDetalle cond)
        ////{
        ////    tran = new Transacion[1];
        ////    tran[0] = new Transacion("PR_NSTR_COND", cond.Agregar());

        ////    return tran;
        //}

        public DataTable ConsultarConvocatoria()
        {
            return conx.realizarConsulta("","", null);
        }

    }
}