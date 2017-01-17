
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Instancia
    {


        public Parametro[] para;
        public string IdInstancia { get; set; }
        public string IdCobertura { get; set; }
        public string NombreInstancia { get; set; }
        public string EstadoInstancia { get; set; }

    }
}
