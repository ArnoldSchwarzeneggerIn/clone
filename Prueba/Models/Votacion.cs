using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Votacion
    {
        
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

    }
}