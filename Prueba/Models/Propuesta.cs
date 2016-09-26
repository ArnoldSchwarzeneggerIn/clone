using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class Propuesta
    {
       
            Parametro[] para;
            private string Candidatura = string.Empty;
            private int IdPropuesta;
            private string descripcionPropuesta = string.Empty;

            public Propuesta(string v)
            {
                this.Candidatura1 = v;
            }
            public Propuesta(int Idpro)
            {
                this.IdPropuesta = Idpro;
            }

            public Propuesta()
            {
            }

            public string Candidatura1
            {
                get
                {
                    return Candidatura;
                }

                set
                {
                    Candidatura = value;
                }
            }

            public string DescripcionPropuesta
            {
                get
                {
                    return descripcionPropuesta;
                }

                set
                {
                    descripcionPropuesta = value;
                }
            }

            internal Parametro[] InsertarPropuesta()
            {
                para = new Parametro[2];
                para[0] = new Parametro("PROP_CAND", Candidatura1);
                para[1] = new Parametro("PROP_DESCRIPCION", DescripcionPropuesta);
                return para;
            }

            internal Parametro[] EliminarPropuesta()
            {
                para = new Parametro[1];
                para[0] = new Parametro("PPROP_ID", IdPropuesta.ToString());
                return para;
            }

            internal Parametro[] ModificarPropuesta()
            {
                para = new Parametro[2];
                para[0] = new Parametro("PPROP_ID", IdPropuesta.ToString());
                para[1] = new Parametro("PROP_DETALL", DescripcionPropuesta);
                return para;
            }

            public Parametro[] ConsultarPropuestas()
            {
                para = new Parametro[1];
                para[0] = new Parametro("CANDIDATO", Candidatura1);
                return para;
            }
        
    }
}