using Prueba.Conexions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Prueba.Models
{
    public class InstanciaConformacion
    {
        Conexion conx = new Conexion();
        private Parametro[] para;
        private string idInstanciaConformacion = string.Empty;
        private string programaInstanciaConformacion = string.Empty;
        private string personaInstanciaConformacion = string.Empty;
        private string convocatoriaInstanciaConformacion = string.Empty;
        private string fechainicioInstanciaConformacion = string.Empty;
        private string fechafinInstanciaConformacion = string.Empty;
        private string fecharetiroInstanciaConformacion = string.Empty;
        private string causaretiroInstanciaConformacion = string.Empty;
        private string estadoInstanciaConformacion = string.Empty;

        public string IdInstaciaConformacion
        {
            get
            {
                return idInstanciaConformacion;
            }

            set
            {
                idInstanciaConformacion = value;
            }
        }

        public string ProgramaInstanciaConformacion
        {
            get
            {
                return programaInstanciaConformacion;
            }

            set
            {
                programaInstanciaConformacion = value;
            }
        }

        public string PersonaInstanciaConformacion
        {
            get
            {
                return personaInstanciaConformacion;
            }

            set
            {
                personaInstanciaConformacion = value;
            }
        }

        public string ConvocatoriaInstanciaConformacion
        {
            get
            {
                return convocatoriaInstanciaConformacion;
            }

            set
            {
                convocatoriaInstanciaConformacion = value;
            }
        }

        public string FechainicioInstanciaConformacion
        {
            get
            {
                return fechainicioInstanciaConformacion;
            }

            set
            {
                fechainicioInstanciaConformacion = value;
            }
        }

        public string FechafinInstanciaConformacion
        {
            get
            {
                return fechafinInstanciaConformacion;
            }

            set
            {
                fechafinInstanciaConformacion = value;
            }
        }

        public string FecharetiroInstanciaConformacion
        {
            get
            {
                return fecharetiroInstanciaConformacion;
            }

            set
            {
                fecharetiroInstanciaConformacion = value;
            }
        }

        public string CausaretiroInstanciaConformacion
        {
            get
            {
                return causaretiroInstanciaConformacion;
            }

            set
            {
                causaretiroInstanciaConformacion = value;
            }
        }

        public string EstadoInstanciaConformacion
        {
            get
            {
                return estadoInstanciaConformacion;
            }

            set
            {
                estadoInstanciaConformacion = value;
            }
        }

        public string Programa
        {
            get
            {
                return programa;
            }

            set
            {
                programa = value;
            }
        }

        public string Detalle
        {
            get
            {
                return detalle;
            }

            set
            {
                detalle = value;
            }
        }

        public string Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        public string Facultad
        {
            get
            {
                return facultad;
            }

            set
            {
                facultad = value;
            }
        }




        private string programa = string.Empty;
        private string detalle = string.Empty;
        private string rol = string.Empty;
        private string facultad = string.Empty;


        public DataTable ConsultarConformacion(string id)
        {
            Parametro[] para = new Parametro[1];
            para[0] = new Parametro(id,id);

            return conx.realizarConsulta("PR_CNST_INSC", "CR_CNST_INSC", para);
        }
        public Parametro[] Insertar()
        {
            para = new Parametro[11];
            para[0] = new Parametro("PINSC_PROGRAMA", Programa);
            para[1] = new Parametro("PINSC_PERSONA", PersonaInstanciaConformacion);
            para[2] = new Parametro("PINSC_CONVOCATORIA", ConvocatoriaInstanciaConformacion);
            para[3] = new Parametro("PINSC_FECHA_INICIO", FechainicioInstanciaConformacion);
            para[4] = new Parametro("PINSC_FECHA_FIN", FechafinInstanciaConformacion);
            para[5] = new Parametro("PINSC_FECHA_RETIRO", FecharetiroInstanciaConformacion);
            para[6] = new Parametro("PINSC_CAUSA_RETIRO", CausaretiroInstanciaConformacion);
            para[7] = new Parametro("PINSC_ESTADO", EstadoInstanciaConformacion);
            para[8] = new Parametro("PINSC_INSTANCIADETALLE", Detalle);
            para[9] = new Parametro("PINSC_ROL", Rol);
            para[10] = new Parametro("PINSC_FACULTAD", Facultad);

            return para;
        }

    
}
}