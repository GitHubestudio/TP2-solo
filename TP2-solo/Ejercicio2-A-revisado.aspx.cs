using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_solo
{
    public partial class Ejercicio2_A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem gralPacheco = new ListItem();
                gralPacheco.Text = "Gral. Pacheco";
                gralPacheco.Value = "Norte";

                ListItem sanMartin = new ListItem();
                sanMartin.Text = "San Miguel";
                sanMartin.Value = "Oeste";

                ListItem boedo = new ListItem();
                boedo.Text = "Boedo";
                boedo.Value = "Sur";

                ddlCiudad.Items.Add(gralPacheco);
                ddlCiudad.Items.Add(sanMartin);
                ddlCiudad.Items.Add(boedo);

                cblTemas.Items.Add("Ciencias");
                cblTemas.Items.Add("Literatura");
                cblTemas.Items.Add("Historia");
            }
        }

        private bool NoEsLetra(char c)
        {
            //se valida que solo sean letras mayusculas o minusculas
            return !char.IsLetter(c);
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            //se valida que los campos no esten vacios
            if ((tbNombre.Text.Trim() == ""
              || tbApellido.Text.Trim() == ""))
            {
                lblError.Text = "Los campos 'Nombre' y 'Apellido' son obligatorios.";
                return;
            }

            //se valida que los campos contengan solo letras
            if (tbNombre.Text.Any(NoEsLetra) || tbApellido.Text.Any(NoEsLetra))
            {
                lblError.Text = "Los campos deben contener solo letras.";
                return;
            }

            //si todo esta ok se mandan los datos al B
            Server.Transfer("Ejercicio2-B-revisado.aspx");
            
        }
    }
}