using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cambio_Climático.Models
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
        public bool tipo { get; set; }

        public Usuario(string nombre, string correo, string contrasena, bool tipo)
        {
            this.nombre = nombre;
            this.correo = correo;
            this.contrasena = contrasena;
            this.tipo = tipo;
        }
    }
}