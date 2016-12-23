using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Votacion
    {
        Parametro[] para;
        Conexion conx = new Conexion();


        public string CONV_ID { get; set; }
        public string CONV_TITULO { get; set; }
        public string CONV_DESCRIPCION { get; set; }
        public  string CONV_FECH_INIC_INSC { get; set; }
        public string CONV_FECH_FIN_INSC { get; set; }
        public string COND_ID { get; set; }
        public string COND_CONVOCATORIA { get; set; }
        public string COND_INSTANCIADETALLE { get; set; }
        public string COND_CUPOS { get; set; }
        public string COND_ESTADO { get; set; }
        public string INSD_ID { get; set; }
        public string INSD_NOMBRE { get; set; }
        public string INSD_INSTANCIA { get; set; }
        public string INST_ID { get; set; }
        public string INST_NOMBRE { get; set; }
        public string PROG_ID { get; set; }
        public string PROG_NOMBRE { get; set; }
        public string FACU_ID { get; set; }
        public string FACU_NOMBRE { get; set; }
        public string TIPE_NOMBRE { get; set; }
        public string NOMBRE { get; set; }
        public string PROP_DETALL { get; set; }

        
        public Votacion()
        {

        }

        public DataTable Cvotacion(Votacion obj)
        {
            para = new Parametro[2];
            para[0] = new Parametro("PPROGRAMA", obj.CONV_ID);
            para[1] = new Parametro("PTIPOUSUARIO", obj.CONV_TITULO);

            return conx.realizarConsulta("PR_CNST_COND_POR_CONV", "CR_CNST_COND_POR_CONV", para);

        }


        int z = 0;

    }
}