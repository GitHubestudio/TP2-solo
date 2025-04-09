using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_solo
{
    public partial class Ejercicio2_B : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //nombre
            string nombre;
            nombre = Request["tbNombre"].ToString();
            lblNombre.Text = nombre;

            //apellido
            string apellido;
            apellido = Request["tbApellido"].ToString();
            lblApellido.Text = apellido;

            //zona
            string zona;
            DropDownList ddlzona = (DropDownList)PreviousPage.FindControl("ddlCiudad");
            zona = ddlzona.SelectedValue;
            lblZona.Text = zona;

            //temas
            string temas = "";
            CheckBoxList cbltemas = (CheckBoxList)PreviousPage.FindControl("cblTemas");

            foreach (ListItem item in cbltemas.Items)
            {
                if (item.Selected)
                {
                    temas += item.Text + "<br>";
                }
            }
            
            if (temas.Length > 0)
            {
                lblTemas.Text = temas;
            }
            else
            {
                lblTemas.Text = "No se seleccionaron temas";
            }
        }
    }
}