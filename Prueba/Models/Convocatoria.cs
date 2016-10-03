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

        public Convocatoria(string id_con)
        {
            idConvocatoria = id_con;
        }

        public Convocatoria()
        {

        }
        private Parametro[] para;
        private string idConvocatoria = string.Empty;

        public string IdConvocatoria
        {
            get { return idConvocatoria; }
            set { idConvocatoria = value; }
        }

        private string numeroConvocatoria = string.Empty;

        public string NumeroConvocatoria
        {
            get { return numeroConvocatoria; }
            set { numeroConvocatoria = value; }
        }

        private string tituloCovocatoria = string.Empty;
        public string TituloCovocatoria
        {
            get
            {
                return tituloCovocatoria;
            }

            set
            {
                tituloCovocatoria = value;
            }
        }



        private string descripcionConvocatoria = string.Empty;

        public string DescripcionConvocatoria
        {
            get
            {
                return descripcionConvocatoria;
            }

            set
            {
                descripcionConvocatoria = value;
            }
        }

        private string fechainicioinscripcionConvocatoria = string.Empty;

        public string FechainicioinscripcionConvocatoria
        {
            get { return fechainicioinscripcionConvocatoria; }
            set { fechainicioinscripcionConvocatoria = value; }
        }

        private string fechafininscripcionConvocatoria = string.Empty;

        public string FechafininscripcionConvocatoria
        {
            get { return fechafininscripcionConvocatoria; }
            set { fechafininscripcionConvocatoria = value; }
        }

        private string fechapublicacionhabilitadoConvocatoria = string.Empty;

        public string FechapublicacionhabilitadoConvocatoria
        {
            get { return fechapublicacionhabilitadoConvocatoria; }
            set { fechapublicacionhabilitadoConvocatoria = value; }
        }

        private string fechapublicacionjuradosConvocatoria = string.Empty;

        public string FechapublicacionjuradosConvocatoria
        {
            get { return fechapublicacionjuradosConvocatoria; }
            set { fechapublicacionjuradosConvocatoria = value; }
        }

        private string fechaeleccionespresencialesConvocatoria = string.Empty;

        public string FechaeleccionespresencialesConvocatoria
        {
            get { return fechaeleccionespresencialesConvocatoria; }
            set { fechaeleccionespresencialesConvocatoria = value; }
        }

        private string fechaeleccionesdistanciaConvocatoria = string.Empty;

        public string FechaeleccionesdistanciaConvocatoria
        {
            get
            {
                return fechaeleccionesdistanciaConvocatoria;
            }

            set
            {
                fechaeleccionesdistanciaConvocatoria = value;
            }
        }



        private string fechapublicacionresultadosConvocatoria = string.Empty;

        public string FechapublicacionresultadosConvocatoria
        {
            get { return fechapublicacionresultadosConvocatoria; }
            set { fechapublicacionresultadosConvocatoria = value; }
        }



        public Parametro[] AgregarParametro(Convocatoria obj)
        {
            para = new Parametro[9];
            para[0] = new Parametro("PCONV_TITULO", obj.TituloCovocatoria);
            para[1] = new Parametro("PCONV_DESCRIPCION", obj.DescripcionConvocatoria);
            para[2] = new Parametro("PCONV_FECH_INIC_INSC", obj.FechainicioinscripcionConvocatoria);
            para[3] = new Parametro("PCONV_FECH_FIN_INSC", obj.FechafininscripcionConvocatoria);
            para[4] = new Parametro("PCONV_FECH_PUBL_HABI", obj.FechapublicacionhabilitadoConvocatoria);
            para[5] = new Parametro("PCONV_FECH_PUBL_JURA", obj.FechapublicacionjuradosConvocatoria);
            para[6] = new Parametro("PCONV_FECH_ELEC_PRES", obj.FechaeleccionespresencialesConvocatoria);
            para[7] = new Parametro("PCONV_FECH_ELEC_DIST", obj.FechaeleccionesdistanciaConvocatoria);
            para[8] = new Parametro("PCONV_FECH_PUBL_RESU", obj.FechapublicacionresultadosConvocatoria);

            return para;
        }

        public Parametro[] ModificarParametro(Convocatoria obj)
        {
            para = new Parametro[11];
            para[0] = new Parametro("PCONV_ID", obj.IdConvocatoria);
            para[1] = new Parametro("PCONV_NUMERO", obj.NumeroConvocatoria);
            para[2] = new Parametro("PCONV_TITULO", obj.TituloCovocatoria);
            para[3] = new Parametro("PCONV_DESCRIPCION", obj.DescripcionConvocatoria);
            para[4] = new Parametro("PCONV_FECH_INIC_INSC", obj.FechainicioinscripcionConvocatoria);
            para[5] = new Parametro("PCONV_FECH_FIN_INSC", obj.FechafininscripcionConvocatoria);
            para[6] = new Parametro("PCONV_FECH_PUBL_HABI", obj.FechapublicacionhabilitadoConvocatoria);
            para[7] = new Parametro("PCONV_FECH_PUBL_JURA", obj.FechapublicacionjuradosConvocatoria);
            para[8] = new Parametro("PCONV_FECH_ELEC_PRES", obj.FechaeleccionespresencialesConvocatoria);
            para[9] = new Parametro("PCONV_FECH_ELEC_DIST", obj.FechaeleccionesdistanciaConvocatoria);
            para[10] = new Parametro("PCONV_FECH_PUBL_RESU", obj.FechapublicacionresultadosConvocatoria);

            return para;


        }

        public DataTable ConsultarConvocatoria()
        {
            return conx.realizarConsulta("PR_CNST_CNVT", "CR_CNST_CNVT", null);
        }

        public DataTable ConsultarConvocatoriaNumero()
        {
            return conx.realizarConsulta("PR_CNST_CNVT_NMRO", "CR_CNST_CNVT_NMRO", null);
        }

        public DataTable ConsultarConvocatoriaPorFecha(Convocatoria obj)
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONV_FECH_INIC_INSC", obj.FechainicioinscripcionConvocatoria);
            para[1] = new Parametro("PCONV_FECH_FIN_INSC", obj.FechafininscripcionConvocatoria);

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
            trans[0] = new Transacion("PR_NSRT_CNVT", AgregarParametro(obj));
            return conx.realizarTransaccion(trans);
        }

        public bool ModificarConvocatoria(Convocatoria obj)
        {

            Transacion[] trans = new Transacion[1];
            trans[0] = new Transacion("PR_UPDT_CNVT", ModificarParametro(obj));
            return conx.realizarTransaccion(trans);

        }












    }
}
