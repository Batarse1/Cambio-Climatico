using Cambio_Climático.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cambio_Climático.Controllers
{
    public static class EstudianteController
    {
        public static List<Estudiante> GetEstudiante()
        {
            var Estudiantes = new List<Estudiante>();
            DataTable dt = null;
            try
            {
                dt = DatabaseConnection.ExecuteQuery("SELECT * FROM ESTUDIANTE");
            }
            catch (Exception)
            {

            }
            foreach (DataRow row in dt.Rows)
            {
                Estudiantes.Add(new Estudiante(row[0].ToString(), row[1].ToString(), row[2].ToString(), Convert.ToInt32(row[3].ToString())));
            }
            return Estudiantes;
        }
    }
}
