using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PruebaRest.CDatos
{
    public class Resultados
    {
        public IList<Usuario> results { get; set; }

        public string Gender { get; set; }
        public Nombre Name { get; set; }
        public Localizacion Location { get; set; }
        public string Email { get; set; }
        public Login Login { get; set; }
        public FechaNacim Dob { get; set; }
        public Registro Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public Identificacion Id { get; set; }
        public Fotografia Picture { get; set; }
        public string Nat { get; set; }
    }
}