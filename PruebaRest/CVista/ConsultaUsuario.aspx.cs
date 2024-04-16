using Newtonsoft.Json;
using PruebaRest.CDatos;
using RestSharp;
using System;

namespace PruebaRest.CVista
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://randomuser.me/api/");
            string Respuesta;

            RestRequest request = new RestRequest();
            var response = client.Get(request);

            Respuesta = response.Content;

            Resultados oResultado = JsonConvert.DeserializeObject<Resultados>(Respuesta);

            if (oResultado != null && oResultado.results != null && oResultado.results.Count > 0)
            {
                Usuario oUsuario = oResultado.results[0];

                // Asignar valores a los controles de la interfaz de usuario
                nombre.Text = oUsuario.name.first + " " + oUsuario.name.last;
                edad.Text = oUsuario.dob.age.ToString();
                pais.Text = oUsuario.location.country;
                imagen.ImageUrl = oUsuario.picture.Large;
            }
            else
            {
                // Manejar el caso en el que no se obtiene ningún resultado
                respuesta.Text = "No se pudo obtener información del usuario.";
            }
        }

    }
}
