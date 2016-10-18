using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Propuesta
    {
       
            Parametro[] para;
            public string prop_id{get; set;}
            public int prop_cand { get; set; }
            public string prop_detalle{get; set;}

            //private Parametro[] InsertarPropuesta()
            //{
            //    para = new Parametro[2];
            //    para[0] = new Parametro("PROP_CAND", Candidatura1);
            //    para[1] = new Parametro("PROP_DESCRIPCION", DescripcionPropuesta);
            //    return para;
            //}

            //private Parametro[] EliminarPropuesta()
            //{
            //    para = new Parametro[1];
            //    para[0] = new Parametro("PPROP_ID", IdPropuesta.ToString());
            //    return para;
            //}

            // private Parametro[] ModificarPropuesta()
            //{
            //    para = new Parametro[2];
            //    para[0] = new Parametro("PPROP_ID", IdPropuesta.ToString());
            //    para[1] = new Parametro("PROP_DETALL", DescripcionPropuesta);
            //    return para;
            //}

            //public Parametro[] ConsultarPropuestas()
            //{
            //    para = new Parametro[1];
            //    para[0] = new Parametro("CANDIDATO", Candidatura1);
            //    return para;
            //}
        
    }
}