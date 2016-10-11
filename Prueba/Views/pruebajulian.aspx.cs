using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba.Views
{
    public partial class pruebajulian : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    Session["Token"] = Request.QueryString["Token"].ToString();
                    Token.Text = Session["Token"].ToString();
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", " $(function Alet() {new PNotify({ title: 'Algo va mal', text: Token asignado '"+Token.Text+"',icon: 'icon-checkmark3', type: 'warning'});}); ", true);
                }
                catch (Exception ex)
                {
                    Token.Text = "Token no valido";
                }
            }
        }
    }
}