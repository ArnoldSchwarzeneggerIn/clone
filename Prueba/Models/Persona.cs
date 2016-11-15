using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Persona
    {
        Conexion conx = new Conexion();
        Parametro[] para;
        Transacion[] tran;

        public string nombres { get; set; }
        public string apellidos { get; set; }
      
        public string Pers_id { get; set; }
        public string Identificacion { get; set; }
        public string tipousuario { get; set; }
        public string programa { get; set; }
        //public string departamento { get; set; }
        //public string municipio { get; set; }
        //public string estado { get; set; }
        //public string foto { get; set; }


        public DataTable ConsultarPersonaJurado()
        {
            return conx.realizarConsulta("PR_CNST_JURAPERSONA", "CR_CNST_JURAPERSONA", para);

        }
    }
}