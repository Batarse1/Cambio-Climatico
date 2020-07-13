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
    }
}