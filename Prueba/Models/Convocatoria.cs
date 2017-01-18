using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Convocatoria
    {

       
        public string IdConvocatoria { get; set; }
        public string NUMEROCONVOCATORIA { get; set; }
        public string TituloConvocatoria { get; set; }
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
        public byte[] Documento { get; set; }
        public string DExtension { get; set; }
        public string DNombre { get; set; }

    }
}
