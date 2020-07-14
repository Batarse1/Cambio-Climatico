using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cambio_Climático.Models
{
    public class Investigacion
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string agencia { get; set; }
        public string correo { get; set; }
        public string  link { get; set; }
        public bool visible { get; set; }

        public Investigacion(int id, string nombre, string agencia, string correo, string link, bool visible)
        {
            this.id = id;
            this.nombre = nombre;
            this.agencia = agencia;
            this.correo = correo;
            this.link = link;
            this.visible = visible;
        }
    }
}
