using Cambio_Climático.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cambio_Climático.Controllers
{
    public static class CentralController
    {
        public static List<Central> CentralList()
        {
            var l = new List<Central>();
            try
            {
                var dt = DatabaseConnection.ExecuteQuery("SELECT * FROM CENTRAL");
                foreach (DataRow element in dt.Rows)
                {
                    var central = new Central(Convert.ToInt32(element[0]), element[1].ToString(), element[2].ToString(), Convert.ToDouble(element[3]), Convert.ToDouble(element[4]), Convert.ToDouble(element[5]));
                    l.Add(central);
                }
            }
            catch (Exception)
            {
            }
            return l;
        }

        public static List<string> PeriodoList()
        {
            string[] inputPeriodoList = { "Anual", "Mensual", "Semanal" };
            List<string> periodoList = new List<string>(inputPeriodoList);
            return periodoList;
        }

       public static string UpdateEnergy(int id_central,string periodo, float nuevoValor)
        {
            try
            {
                DatabaseConnection.ExecuteNonQuery($"UPDATE CENTRAL SET {periodo} = {nuevoValor} WHERE id_central = {id_central}");
                return "Actualizada con exito";
            }
            catch(Exception)
            {
                return "Ha ocurrido un error, no se ha actualizado";
            }
        }
        public static string UpdateCentral(int id_central, string nombre, string ubicacion)
        {
            try
            {
                DatabaseConnection.ExecuteNonQuery($"UPDATE CENTRAL SET c_nombre = '{nombre}', ubicacion = '{ubicacion}' WHERE id_central = {id_central}");
                return "Actualizada con exito";
            }
            catch (Exception)
            {
                return "Ha ocurrido un error, no se ha actualizado";
            }
        }
    }
}