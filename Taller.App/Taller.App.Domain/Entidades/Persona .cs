using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.App.Domain
{
    public class Persona 
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string Contraseña { get; set; }
    }
}