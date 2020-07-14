using Cambio_Climático.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Cambio_Climático.Controllers
{
    public static class UserController
    {
        public static void AddUser(string correo, string nombre, string contrasena, bool tipo)
        {
            try
            {
                DatabaseConnection.ExecuteNonQuery($"INSERT INTO USUARIO (correo,u_nombre,contrasena,tipo) VALUES ('{correo}','{nombre}','{contrasena}',{tipo})");
            }
            catch
            {

            }
        }
        public static List<Usuario> UserList()
        {
            var l = new List<Usuario>();
            try
            {
                var dt = DatabaseConnection.ExecuteQuery("SELECT * FROM USUARIO");
                foreach (DataRow element in dt.Rows)
                {
                    var usuario = new Usuario(element[0].ToString(), element[1].ToString(), element[2].ToString(), Convert.ToBoolean(element[3]));
                    l.Add(usuario);
                }
            }
            catch (Exception)
            {
            }
            return l;
        }
        public static string removeUser(string correo)
        {
            try
            {
                DatabaseConnection.ExecuteNonQuery($"DELETE FROM USUARIO WHERE correo='{correo}'");
                return "Eliminado con exito";
            }
            catch(Exception)
            {
                return "Ha ocurrido un error, usuario no eliminado";
            }
        }

        public static int login(string correo, string contrasena)
        {
            foreach(var element in UserList())
            {
                if (element.correo.Equals(correo))
                {
                    if (element.contrasena.Equals(contrasena))
                    {
                        GlobalAtributtes.usuario = new Usuario(element.correo,element.nombre, element.contrasena, element.tipo);
                        if (element.tipo)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
            return -1;
        }
    }
}
