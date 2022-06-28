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
    public class NCategoria
    {
        
        public static DataTable listar()
        {
            DCategora Datos = new DCategora();
            return Datos.listar();  

        }
    
     

        public static DataTable Seleccionar()
        {
            DCategora Datos = new DCategora();
            return Datos.Seleccionar();

        }

        public static string Insertar(string Nombre)
        {
            DCategora Datos = new DCategora();
            // pregunto si existe la categoria
           string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "la categoria ya existe";
            }
            else
            {
                Categoria obj = new Categoria();
                obj.Nombre = Nombre;
                return Datos.Insertar(obj);
            }

        }

        public static string Actualizar(int id , string Nombre)
        {
            DCategora Datos = new DCategora();
            Categoria obj = new Categoria();
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "la categoria ya existe";
            }
            else
            {

                obj.IdCategoria = id;
                obj.Nombre = Nombre;
                return Datos.Actualizar(obj);
            }
           

        }

        public static string Eliminar(int id)
        {
            DCategora Datos = new DCategora();
            return Datos.Eliminar(id);
        }

       


    }
}
