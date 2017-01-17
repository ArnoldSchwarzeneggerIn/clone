using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class TipoElector
    {
        public string IdTipoElector {get;set;}
        public string NombreTipoElector {get;set;}
        public string EstadoTipoElector {get;set;}
        public string IdConvocatoria {get;set;}
        //public Parametro[] para;


        //public Parametro[] Insertar()
        //{
        //    para = new Parametro[1];
        //    para[0] = new Parametro("PTIPE_NOMBRE", NombreTipoElector);

        //    return para;
        //}

        //public Parametro[] Modificar()
        //{
        //    para = new Parametro[3];
        //    para[0] = new Parametro("PTIPE_ID", IdTipoElector);

        //    para[1] = new Parametro("PTIPE_NOMBRE", NombreTipoElector);
        //    para[2] = new Parametro("PTIPE_ESTADO", EstadoTipoElector);

        //    return para;
        //}

        //public Parametro[] ConsultarInstancia()
        //{
        //    para = new Parametro[2];
        //    para[0] = new Parametro("PCONV_ID", IdConvocatoria);
        //    para[1] = new Parametro("ROL", IdTipoElector);
        //    return para;
        //}
    }
}