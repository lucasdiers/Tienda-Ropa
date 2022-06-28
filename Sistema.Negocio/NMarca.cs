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
    public class NMarca
    {
        public static DataTable listar()
        {
           DMarca Datos = new DMarca();
            return  Datos.listar();
        }
        public static DataTable Seleccionar()
        {
            DMarca Datos = new DMarca();
            return Datos.Seleccionar();

        }
      
        public static string Insertar(string Nombre)
        {
            DMarca Datos = new DMarca();
            // pregunto si existe la categoria
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "la marca ya existe";
            }
            else
            {
                Marca obj = new Marca();
                obj.Nombre = Nombre;
                return Datos.Insertar(obj);
            }

        }

        public static string Actualizar(int id, string Nombre)
        {
            DMarca Datos = new DMarca();
            Marca obj = new Marca();
          
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "la categoria ya existe";
            }
            else
            {

                obj.Idmarca = id;
                obj.Nombre = Nombre;
                return Datos.Actualizar(obj);
            }
        }

        public static string Eliminar(int id)
        {
            DMarca Datos = new DMarca();
            return Datos.Eliminar(id);
        }
    }
}
