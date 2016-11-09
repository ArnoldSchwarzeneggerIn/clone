using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Jurado
    {
        Conexion conx = new Conexion();
        Parametro []para;
        Transacion[] tran;
        public string jura_persona {get; set;}
        public string jura_id { get; set; }
        public string jura_fecha { get; set; }
        public string jura_convocatoria { get; set; }

        public DataTable ConsultarJurados(Convocatoria obj)
        {
            para  = new Parametro[1];
            para[0] = new Parametro("PCONV_", obj.IdConvocatoria);
            return conx.realizarConsulta("PR_CNST_JURADOPORCONVOCATORIA", "CR_CNST_JURADOPORCONVOCATORIA",para);
        }

        public bool InsertarJurados(Jurado obj)
        {
            para = new Parametro[3];
            para[0] = new Parametro("PJURA_PERSONA", obj.jura_persona);
            para[1] = new Parametro("PJURA_FECHA", obj.jura_fecha);
            para[2] = new Parametro("PJURA_COVOCATORIA", obj.jura_convocatoria);

            tran = new Transacion[1];
            tran[0] = new Transacion("PR_NSRT_JURA", para);
            return conx.realizarTransaccion(tran);
        }

       
    }
}