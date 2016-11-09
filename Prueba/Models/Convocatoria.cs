using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Convocatoria
    {

        Conexion conx = new Conexion();
        public Parametro[] para;
        public string IdConvocatoria { get; set; }
        public string NumeroConvocatoria { get; set; }
        public string TituloCovocatoria { get; set; }
        public string DescripcionConvocatoria { get; set; }
        public string Fechainicioinscripcion{ get; set; }
        public string Fechafininscripcion{ get; set; }
        public string Fechapublicacionhabilitado{ get; set; }
        public string Fechapublicacionjurados{ get; set; }
        public string Fechaeleccionespresenciales{ get; set; }
        public string Fechaeleccionesdistancia{ get; set; }
        public string Fechapublicacionresultados{ get; set; }
        public string Estado { get; set; }
       

        public Parametro[] ParametroInsertar(Convocatoria obj)
        {
            para = new Parametro[9];
            para[0] = new Parametro("PCONV_TITULO", obj.TituloCovocatoria);
            para[1] = new Parametro("PCONV_DESCRIPCION", obj.DescripcionConvocatoria);
            para[2] = new Parametro("PCONV_FECH_INIC_INSC", obj.Fechainicioinscripcion);
            para[3] = new Parametro("PCONV_FECH_FIN_INSC", obj.Fechafininscripcion);
            para[4] = new Parametro("PCONV_FECH_PUBL_HABI", obj.Fechapublicacionhabilitado);
            para[5] = new Parametro("PCONV_FECH_PUBL_JURA", obj.Fechapublicacionjurados);
            para[6] = new Parametro("PCONV_FECH_ELEC_PRES", obj.Fechaeleccionespresenciales);
            para[7] = new Parametro("PCONV_FECH_ELEC_DIST", obj.Fechaeleccionesdistancia);
            para[8] = new Parametro("PCONV_FECH_PUBL_RESU", obj.Fechapublicacionresultados);

            return para;
        }

        public Parametro[] ParametroModificar(Convocatoria obj)
        {
            para = new Parametro[9];
            para[0] = new Parametro("PCONV_ID", obj.IdConvocatoria);
            para[1] = new Parametro("PCONV_NUMERO", obj.NumeroConvocatoria);
            para[2] = new Parametro("PCONV_FECH_INIC_INSC", obj.Fechainicioinscripcion);
            para[3] = new Parametro("PCONV_FECH_FIN_INSC", obj.Fechafininscripcion);
            para[4] = new Parametro("PCONV_FECH_PUBL_HABI", obj.Fechapublicacionhabilitado);
            para[5] = new Parametro("PCONV_FECH_PUBL_JURA", obj.Fechapublicacionjurados);
            para[6] = new Parametro("PCONV_FECH_ELEC_PRES", obj.Fechaeleccionespresenciales);
            para[7] = new Parametro("PCONV_FECH_ELEC_DIST", obj.Fechaeleccionesdistancia);
            para[8] = new Parametro("PCONV_FECH_PUBL_RESU", obj.Fechapublicacionresultados);

            return para;


        }

        public DataTable ConsultarConvocatoria()
        {
            return conx.realizarConsulta("PR_CNST_CNVT", "CR_CNST_CNVT", null);
        }


        public DataTable ConsultaConvocaotoriaPorFecha()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONV_FECH_INIC_INSC", Fechainicioinscripcion);
            para[1] = new Parametro("PCONV_FECH_FIN_INSC", Fechafininscripcion);

            return conx.realizarConsulta("PR_CNST_CNVT_POR_FECH", "CR_CNST_CNVT_POR_FECH", para);

        }
        public DataTable ConsultarConvocatoriaPorNumero(Convocatoria obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCONV_ID", obj.IdConvocatoria );

            return conx.realizarConsulta("PR_CNST_CNVT_POR_NUMERO", "CR_CNST_CNVT_POR_NUMERO", para);
        }

        public DataTable ConsultarConvocatoriaAbierta()
        {
            return conx.realizarConsulta("PR_CNST_CNVT_BRTS", "CR_CNST_CNVT_BRTS", null);
        }


        public bool InsertarConvocatoria(Convocatoria obj)
        {
            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_NSRT_CNVT", ParametroInsertar(obj));
            return conx.realizarTransaccion(trans);
        }

        public bool ModificarConvocatoria(Convocatoria obj)
        {

            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_UPDT_CNVT", ParametroModificar(obj));
            return conx.realizarTransaccion(trans);

        }












    }
}
