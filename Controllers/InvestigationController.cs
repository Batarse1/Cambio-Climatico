using Cambio_Climático.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cambio_Climático.Controllers
{
    public class InvestigationController
    {
        public static List<Investigacion> InvestigacionList()
        {
            var l = new List<Investigacion>();
            try
            {
                var dt = DatabaseConnection.ExecuteQuery("SELECT * FROM INVESTIGACION");
                foreach (DataRow element in dt.Rows)
                {
                    var investigacion = new Investigacion(Convert.ToInt32(element[0].ToString()), element[1].ToString(), element[2].ToString(), element[3].ToString(), element[4].ToString(), Convert.ToBoolean(element[5].ToString()));
                    l.Add(investigacion);
                }
            }
            catch (Exception)
            {
            }
            return l;
        }

        public static string UpdateInvestigation(bool tf, int id_tf)
        {
            try
            {
                DatabaseConnection.ExecuteNonQuery($"UPDATE INVESTIGACION SET visible = {tf} WHERE id_inv = {id_tf}");
                return "Actualizada con exito";
            }
            catch(Exception)
            {
                return "ha ocurrido un error, no se ha actualizado";
            }
        }

        public static string removeInvestigation(int id_investigation)
        {
            try
            {
                DatabaseConnection.ExecuteNonQuery($"DELETE FROM INVESTIGACION WHERE id_inv = {id_investigation}");
                return "Actualizada con exito";
            }
            catch (Exception)
            {
                return "ha ocurrido un error, no se ha actualizado";
            }
        }

        public static string AddInvestigation(string nombre, string agencia, bool visible,string correo, string url)
        {
            try
            {
                DatabaseConnection.ExecuteNonQuery($"INSERT INTO INVESTIGACION (i_nombre,agencia,visible,correo,pdf) VALUES ('{nombre}','{agencia}',{visible},'{correo}','{url}')");
                return "Agregada con exito";
            }
            catch
            {
                return "ha ocurrido un error, no se ha agregado";
            }
        }
    }
}
