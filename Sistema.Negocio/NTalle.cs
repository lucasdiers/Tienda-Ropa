using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Datos;
using Sistema.Entidades;

namespace Sistema.Negocio
{
    public class NTalle
    {
        public static DataTable listar()
        {
            DTalle Datos = new DTalle();
            return Datos.listar();

        }
        public static DataTable Seleccionar()
        {
            DTalle Datos = new DTalle();
            return Datos.Seleccionar();

        }

        public static string Insertar(string Nombre)
        {

            DTalle Datos = new DTalle();
            // pregunto si existe la categoria
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "la marca ya existe";
            }
            else
            {
                Talle obj = new Talle();
                obj.Nombre = Nombre;
                return Datos.Insertar(obj);
            }

        }

        public static string Actualizar(int id, string Nombre)
        {
            DTalle Datos = new DTalle();
            Talle obj = new Talle();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "la categoria ya existe";
            }
            else
            {

                obj.IdTalle = id;
                obj.Nombre = Nombre;
                return Datos.Actualizar(obj);
            }


        }

        public static string Eliminar(int id)
        {
            DTalle Datos = new DTalle();
            return Datos.Eliminar(id); 
        }
    }
}
