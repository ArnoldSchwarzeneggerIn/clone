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



        public Parametro[] Agregar()
        {
            para = new Parametro[9];
            para[0] = new Parametro("PCONV_TITULO", TituloCovocatoria);
            para[1] = new Parametro("PCONV_DESCRIPCION", DescripcionConvocatoria);
            para[2] = new Parametro("PCONV_FECH_INIC_INSC", FechainicioinscripcionConvocatoria);
            para[3] = new Parametro("PCONV_FECH_FIN_INSC", FechafininscripcionConvocatoria);
            para[4] = new Parametro("PCONV_FECH_PUBL_HABI", FechapublicacionhabilitadoConvocatoria);
            para[5] = new Parametro("PCONV_FECH_PUBL_JURA", FechapublicacionjuradosConvocatoria);
            para[6] = new Parametro("PCONV_FECH_ELEC_PRES", FechaeleccionespresencialesConvocatoria);
            para[7] = new Parametro("PCONV_FECH_ELEC_DIST", FechaeleccionesdistanciaConvocatoria);
            para[8] = new Parametro("PCONV_FECH_PUBL_RESU", FechapublicacionresultadosConvocatoria);

            return para;


        }

        public Parametro[] Modificar()
        {
            para = new Parametro[9];
            para[0] = new Parametro("PCONV_ID", IdConvocatoria);
            para[1] = new Parametro("PCONV_NUMERO", NumeroConvocatoria);
            para[2] = new Parametro("PCONV_FECH_INIC_INSC", FechainicioinscripcionConvocatoria);
            para[3] = new Parametro("PCONV_FECH_FIN_INSC", FechafininscripcionConvocatoria);
            para[4] = new Parametro("PCONV_FECH_PUBL_HABI", FechapublicacionhabilitadoConvocatoria);
            para[5] = new Parametro("PCONV_FECH_PUBL_JURA", FechapublicacionjuradosConvocatoria);
            para[6] = new Parametro("PCONV_FECH_ELEC_PRES", FechaeleccionespresencialesConvocatoria);
            para[7] = new Parametro("PCONV_FECH_ELEC_DIST", FechaeleccionesdistanciaConvocatoria);
            para[8] = new Parametro("PCONV_FECH_PUBL_RESU", FechapublicacionresultadosConvocatoria);

            return para;


        }


        public Parametro[] ConsultaConParametros()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONV_FECH_INIC_INSC", FechainicioinscripcionConvocatoria);
            para[1] = new Parametro("PCONV_FECH_FIN_INSC", FechafininscripcionConvocatoria);

            return para;

        }



        public DataTable ConsultaPorId()
        {
            para = new Parametro[1];
            para[0] = new Parametro("PCONV_ID", IdConvocatoria);


            return conx.realizarConsulta("PR_CONSULINSTCONVO", "CR_CONINS", para);

        }





        //public Parametro[] Agregar(Convocatoria conv)
        //{
        //    para = new Parametro[8];
        //    para[0] = new Parametro("PCONV_NUMERO", NumeroConvocatoria);
        //    para[1] = new Parametro("PCONV_FECH_INIC_INSC", conv.FechainicioinscripcionConvocatoria);
        //    para[2] = new Parametro("PCONV_FECH_FIN_INSC", conv.FechafininscripcionConvocatoria);
        //    para[3] = new Parametro("PCONV_FECH_PUBL_HABI", conv.FechapublicacionhabilitadoConvocatoria);
        //    para[4] = new Parametro("PCONV_FECH_PUBL_JURA", conv.FechapublicacionjuradosConvocatoria);
        //    para[5] = new Parametro("PCONV_FECH_ELEC_PRES", conv.FechaeleccionespresencialesConvocatoria);
        //    para[6] = new Parametro("PCONV_FECH_ELEC_DIST", conv.FechaeleccionesdistanciaConvocatoria);
        //    para[7] = new Parametro("PCONV_FECH_PUBL_RESU", conv.FechapublicacionresultadosConvocatoria);

        //    return para;


        //}




    }
}
