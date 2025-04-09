using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_solo
{
    public partial class Ejercicio4_A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            //se valida si algun campo esta vacio y se muestra un mensaje
            if ((tbUsuario.Text.Trim() == ""
              || tbClave.Text.Trim() == ""))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                return;
            }

            //se valida el ingreso de datos
            if (tbUsuario.Text.ToLower() == "claudio" && tbClave.Text.ToLower() == "casas")
            {
                Server.Transfer("Ejercicio4-B-revisado.aspx");
            }
            else
            {
                Server.Transfer("Ejercicio4-C-revisado.aspx");
            }
        }
    }
}