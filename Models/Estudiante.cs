namespace Cambio_Climático.Models
{
    public class Estudiante
    {
        public string carnet { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }

        public Estudiante(string carnet, string nombres, string apellidos, int edad)
        {
            this.carnet = carnet;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.edad = edad;
        }
    }
}
