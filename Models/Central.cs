namespace Cambio_Climático.Models
{
    public class Central
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public double anual { get; set; }
        public double mensual { get; set; }

        public double semanal { get; set; }

        public Central(int id, string nombre, string ubicacion, double anual, double mensual, double semanal)
        {
            this.id = id;
            this.nombre = nombre;
            this.ubicacion = ubicacion;
            this.anual = anual;
            this.mensual = mensual;
            this.semanal = semanal;
        }
    }
}
