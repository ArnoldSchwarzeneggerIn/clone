using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Candidatura
    {
       
        public string cand_id { get; set; }
        public string cand_convocatoriadetalle { get; set; }
        public string cand_cedula { get; set; }
        public string cand_plancha { get; set; }
        public string cand_observacion { get; set; }
        public string cand_fechainscripcion{ get; set; }
        public string cand_estado { get; set; }

     
    }
}