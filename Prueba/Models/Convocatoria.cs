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
        public string TITULOCONVOCATORIA { get; set; }
        public string DescripcionConvocatoria { get; set; }
        public string Fechainicioinscripcion{ get; set; }
        public string Fechafininscripcion{ get; set; }
        public string Fechapublicacionhabilitado{ get; set; }
        public string Fechapublicacionjurados{ get; set; }
        public string Fechaeleccionespresenciales{ get; set; }
        public string Fechaeleccionesdistancia{ get; set; }
        public string Fechapublicacionresultados{ get; set; }
        public string Estado { get; set; }
        public string fecharegistro { get; set; }

        public DataTable CNmroCnvt(Convocatoria obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCONV_FECH_FIN_INSC", obj.Fechafininscripcion);


            return conx.realizarConsulta("PR_CNST_CNVT_NMRO", "CR_CNST_CNVT_NMRO", para);
        }



        public Parametro[] ParametroInsertar(Convocatoria obj)
        {
            para = new Parametro[11];
            para[0] = new Parametro("PCONV_TITULO", obj.TITULOCONVOCATORIA);
            para[1] = new Parametro("PCONV_DESCRIPCION", obj.DescripcionConvocatoria);
            para[2] = new Parametro("PCONV_FECH_INIC_INSC", obj.Fechainicioinscripcion);
            para[3] = new Parametro("PCONV_FECH_FIN_INSC", obj.Fechafininscripcion);
            para[4] = new Parametro("PCONV_FECH_PUBL_HABI", obj.Fechapublicacionhabilitado);
            para[5] = new Parametro("PCONV_FECH_PUBL_JURA", obj.Fechapublicacionjurados);
            para[6] = new Parametro("PCONV_FECH_ELEC_PRES", obj.Fechaeleccionespresenciales);
            para[7] = new Parametro("PCONV_FECH_ELEC_DIST", obj.Fechaeleccionesdistancia);
            para[8] = new Parametro("PCONV_FECH_PUBL_RESU", obj.Fechapublicacionresultados);
            para[9] = new Parametro("PCONV_ESTADO", obj.Estado);
            para[10] = new Parametro("PCONV_FECH_REGISTRO", obj.fecharegistro);

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
        
        public Parametro[] Votacion(Convocatoria obj)
        {
            para = new Parametro[2];
            para[0] = new Parametro("PPROGRAMA", obj.IdConvocatoria);
            para[1] = new Parametro("PTIPOUSUARIO", obj.NumeroConvocatoria);
            return para;
        }

        public DataTable VotacionConvocatoria(Convocatoria obj)

        {
            return conx.realizarConsulta("PR_CNST_VOTACION", "CR_CNST_VOTACION", Votacion(obj));
        }


        public DataTable CInstCnvt(Convocatoria obj)

        {
            para = new Parametro[1];
            para[0] = new Parametro("PCONV_ID", obj.IdConvocatoria);

            return conx.realizarConsulta("PR_CNST_COND_INST", "CR_CNST_COND_INST", para);
        }

        public DataTable CInsdCnvt(Convocatoria obj)

        {
            para = new Parametro[1];
            para[0] = new Parametro("PCONV_ID", obj.IdConvocatoria);

            return conx.realizarConsulta("PR_CNST_COND_INSD", "CR_CNST_COND_INSD", para);
        }

        public DataTable CCnvtE(Convocatoria obj)
        {
            para = new Parametro[1];
            para[0] = new Parametro("PESTADO" , obj.Estado);
            return conx.realizarConsulta("PR_CNST_CNVTESTADO", "CR_CNST_CNVTESTADO", para);
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

        //insertar convocatoria
        public bool ICnvt(Convocatoria obj)
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

        public DataTable ConsultarCargosPorConvocatoriasActvias(Convocatoria obj)
        {
            para = new Parametro[1];
            para[1] = new Parametro("PCONV_ID", obj.IdConvocatoria);
            return conx.realizarConsulta("PR_CNST_INSD_POR_CONV", "CR_CNST_INSD_POR_CONV", para);
        }


        public DataTable ConsultarCargosPorConvocatoria(Convocatoria obj)
        {
            para = new Parametro[2];
            para[0] = new Parametro("PPROGRAMA", obj.IdConvocatoria);
            para[1] = new Parametro("PTIPOUSUARIO", obj.TITULOCONVOCATORIA);

            return conx.realizarConsulta("PR_CNST_COND_POR_CONV", "CR_CNST_COND_POR_CONV", para);

        }


        public bool MECnvt(Convocatoria obj)
        {

            para = new Parametro[2];
            para[0] = new Parametro("PCONV_ID", obj.IdConvocatoria);
            para[1] = new Parametro("PCONV_ESTADO", obj.Estado);

            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_UPDT_CNVTSTDO", para);

            return conx.realizarTransaccion(trans);

        }

        // Consultar cargos por instancia 
        public DataTable CCrgsInst()
        {
        
            return conx.realizarConsulta("PR_CNST_INSD_POR_INST", "CR_CNST_INSD_POR_INST", null);

        }













    }
}
