using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2_solo
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //aporte B
        private bool NoEsNumero(char c)
        {
            //valida que solo sean digitos del 0 al 9
            return !char.IsDigit(c);
        }
        private bool NoEsLetra(char c)
        {
            //valida que solo sean letras mayusculas o minusculas
            return !char.IsLetter(c);
        }

        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            //Aporte A
            //se valida si algun campo esta vacio
            //se muestra un mensaje y no se genera la tabla
            if ((tbProducto1.Text.Trim() == ""
              || tbProducto2.Text.Trim() == ""
              || tbCantidad1.Text.Trim() == ""
              || tbCantidad2.Text.Trim() == ""))
            {
                lblError.Text = "Todos los campos son obligatorios.";
                lblTabla.Text = "";
                return;
            }

            //Aporte C
            //con el metodo any validamos el campo(solo numeros)
            //se llama a la funcion "NoEsNumero"
            //validacion de los textbox cantidad1 y cantidad2
            if (tbCantidad1.Text.Any(NoEsNumero) || tbCantidad2.Text.Any(NoEsNumero))
            {
                lblError.Text = "Las cantidades deben contener solo números.";
                lblTabla.Text = "";
                return;
            }

            //Aporte D
            //con el metodo any validamos el campo(solo letras)
            //se llama a la funcion "NoEsLetra"
            //validacion de los textbox producto1 y producto2
            if (tbProducto1.Text.Any(NoEsLetra) || tbProducto2.Text.Any(NoEsLetra))
            {
                lblError.Text = "Los nombres deben contener solo letras.";
                lblTabla.Text = "";
                return;
            }

            //Aporte E
            //si todo esta ok
            //se crean variables con los valores ingresados
            int cant1 = int.Parse(tbCantidad1.Text);
            int cant2 = int.Parse(tbCantidad2.Text);
            string prod1 = tbProducto1.Text;
            string prod2 = tbProducto2.Text;
            int total = cant1 + cant2;

            //Aporte F
            //se genera la tabla con los valores
            //de las variables
            string tabla = "<table border='1'>";
            tabla += "<tr><th>Producto</th><th>Cantidad</th></tr>";
            tabla += "<tr><td>" + prod1 + "</td><td>" + cant1 + "</td></tr>";
            tabla += "<tr><td>" + prod2 + "</td><td>" + cant2 + "</td></tr>";
            tabla += "<tr><td>TOTAL</td><td>" + total + "</td></tr>";
            tabla += "</table>";

            lblTabla.Text = tabla;
            lblError.Text = "";
        }
        
        protected void tbProducto1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}