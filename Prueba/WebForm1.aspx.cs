using Prueba.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Prueba.Models;

namespace Prueba
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void boton_Click(object sender, EventArgs e)
        {

            Documento docum = new Documento();

            docum.Candidato = cand.Text;
            docum.Ruta = ruta.Text;
            docum.Observacion = obser.Text;

            HttpPostedFile archivo = docu.PostedFile;
            string ext = Path.GetExtension(archivo.FileName).ToLower();
            if ((ext == ".pdf") && archivo.ContentLength <= 5242880)
            {
                byte[] theimage = new byte[archivo.ContentLength];
                archivo.InputStream.Read(theimage, 0, archivo.ContentLength);//carga la data del archivo en el arreglo theimage
                //this.GuardarArchivo(archivo.FileName, theimage);
                docum.Document = theimage;
                docum.Nombre = archivo.FileName;

            }

            //docum.Insertar(docum);

        }
    }
}