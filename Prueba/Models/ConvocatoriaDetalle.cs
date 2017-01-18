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
        public Transacion[] tran;
        public string IdConvocatoriaDetalle { set; get; }
        public string ConvocatoriaConvocatoriaDetalle { set; get; }
        public string InstanciadetalleConvocatoriaDetalle { set; get; }
        public string CuposConvocatoriaDetalle { set; get; }
        public string EstadoConvocatoriaDetalle { set; get; }


        public Parametro[] ParametrosInsertar()
        {
            para = new Parametro[3];
            para[0] = new Parametro("PCOND_INSTANCIADETALLE", InstanciadetalleConvocatoriaDetalle);
            para[1] = new Parametro("PCONVOCATORIA", ConvocatoriaConvocatoriaDetalle);
            para[2] = new Parametro("PCOND_CUPOS", CuposConvocatoriaDetalle);

            return para;

        }

        public Parametro[] ParametrosInsertar(ConvocatoriaDetalle obj)
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCOND_INSTANCIADETALLE", obj.InstanciadetalleConvocatoriaDetalle);
            para[1] = new Parametro("PCOND_CUPOS", obj.CuposConvocatoriaDetalle);

            return para;

        }


        public Parametro[] ParametrosInsertar2(ConvocatoriaDetalle obj)
        {
            para = new Parametro[3];
            para[0] = new Parametro("PCOND_INSTANCIADETALLE", obj.InstanciadetalleConvocatoriaDetalle);
            para[1] = new Parametro("PCONVOCATORIA", obj.ConvocatoriaConvocatoriaDetalle);
            para[2] = new Parametro("PCOND_CUPOS", obj.CuposConvocatoriaDetalle);

            return para;

        }



        public Parametro[] Eliminar()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONVOCATORIA_ID", ConvocatoriaConvocatoriaDetalle);
            para[1] = new Parametro("PCARGO_ID", InstanciadetalleConvocatoriaDetalle);

            return para;

        }


        public Parametro[] Modificar(ConvocatoriaDetalle obj)
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCOND_INSTANCIADETALLE", obj.InstanciadetalleConvocatoriaDetalle);
            para[1] = new Parametro("PCOND_CUPOS", obj.CuposConvocatoriaDetalle);
            para[2] = new Parametro("PCONVOCATORIA", obj.IdConvocatoriaDetalle);

            return para;


        }


        public Parametro[] ConsultarInstanciasC()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONV_ID", ConvocatoriaConvocatoriaDetalle);
            para[1] = new Parametro("INSTA", IdConvocatoriaDetalle);
            return para;
        }

        public bool InsertarConvocatoriaDetalle(ConvocatoriaDetalle []obj)
        {
            tran = new Transacion[obj.Length];
            
            for (int i=0;i<obj.Length;i++)
            {
                if (obj[i] != null)
                {
                    tran[i] = new Transacion("PR_NSRT_CNVD", ParametrosInsertar(obj[i]));
                }
                
            }
            return conx.realizarTransaccion(tran);
        }

        public DataTable ConsultarConvocatoria()
        {
            return conx.realizarConsulta("","", null);
        }


        public bool DCnvd(ConvocatoriaDetalle obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCOND_CONVOCATORIA", obj.ConvocatoriaConvocatoriaDetalle);

            tran = new Transacion[1]; 
            tran[0] = new Transacion("PR_DLTE_CNVD", para);

            return conx.realizarTransaccion(tran);
        }

        public bool MCnvd(ConvocatoriaDetalle []obj)
        {

            //int N = obj.Length + 1; 
            //tran = new Transacion[N]; 

            ////tran[0] = new Transacion("PR_DLTE_CNVD", null);
            //for (int i = 1; i <N; i++)

            tran = new Transacion[obj.Length];

            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i] != null)
                {
                    tran[i] = new Transacion("PR_UPDT_CNVD", ParametrosInsertar2(obj[i]));
                }

            }
            return conx.realizarTransaccion(tran);
        }
    }
}