using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Persona
    {
       
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string identificacion { get; set; }
        public byte []foto { get; set; }
        public string idmenu { get; set; }
        public string menunombre { get; set; }

        public string submenumenu { get; set; }

        public string submenu { get; set; }
        public string ruta { get; set; }
        //public string Pers_id { get; set; }
        //public string Identificacion { get; set; }
        //public string tipousuario { get; set; }
        //public string programa { get; set; }
        //public string departamento { get; set; }
        //public string municipio { get; set; }
        //public string estado { get; set; }
        //public string foto { get; set; }

    }
}