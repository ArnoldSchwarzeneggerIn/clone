using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class TipoElector
    {
        private string idTipoElector = string.Empty;
        private string nombreTipoElector = string.Empty;
        private string estadoTipoElector = string.Empty;
        private string IdConvocatoria = string.Empty;
        public Parametro[] para;

        public string IdTipoElector
        {
            get
            {
                return idTipoElector;
            }

            set
            {
                idTipoElector = value;
            }
        }

        public string NombreTipoElector
        {
            get
            {
                return nombreTipoElector;
            }

            set
            {
                nombreTipoElector = value;
            }
        }

        public string EstadoTipoElector
        {
            get
            {
                return estadoTipoElector;
            }

            set
            {
                estadoTipoElector = value;
            }
        }

        public string IdConvocatoria1
        {
            get
            {
                return IdConvocatoria;
            }

            set
            {
                IdConvocatoria = value;
            }
        }

        public Parametro[] Insertar()
        {
            para = new Parametro[1];
            para[0] = new Parametro("PTIPE_NOMBRE", NombreTipoElector);

            return para;
        }

        public Parametro[] Modificar()
        {
            para = new Parametro[3];
            para[0] = new Parametro("PTIPE_ID", IdTipoElector);

            para[1] = new Parametro("PTIPE_NOMBRE", NombreTipoElector);
            para[2] = new Parametro("PTIPE_ESTADO", EstadoTipoElector);

            return para;
        }

        public Parametro[] ConsultarInstanci()
        {
            para = new Parametro[2];
            para[0] = new Parametro("PCONV_ID", IdConvocatoria1);
            para[1] = new Parametro("ROL", IdTipoElector);
            return para;
        }
    }
}