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
    public class NAarticulo
    {
        public static DataTable listar() // creo el objeto y llamo al metedo listar de la capa datos
        {
            DArticulos Datos = new DArticulos();
            return Datos.listar();

        }

      
        public static string Insertar(int idCategoria, int idMarca, int idTalle, string Nombre,string Codigo, decimal PrecioCompra, decimal PrecioVenta,int stock ,string color)
        {
            DArticulos Datos = new DArticulos();
            // pregunto si existe la categoria
            string Existe = Datos.Existe(Nombre);
            if (Existe.Equals("1"))
            {
                return "el articulo ya existe";
            }
            else
            {
                Articulos obj = new Articulos();
                obj.IdCategoria = idCategoria;
                obj.IdMarca = idMarca;
                obj.IdTalle = idTalle;
                obj.Nombre = Nombre;
                obj.Codigo = Codigo;
                obj.PrecioCompra = PrecioCompra;
                obj.PrecioVenta = PrecioVenta;
                obj.Stock = stock;
                obj.Color=color;    
                
                return Datos.Insertar(obj);
            }

        }

        public static string Actualizar(int id, int idCategoria, int idMarca, int idTalle,string NombreAnterior, string Nombre, string Codigo, decimal PrecioCompra, decimal PrecioVenta, int stock, string color)
        {
            DArticulos Datos = new DArticulos();
            Articulos obj = new Articulos();
            if (NombreAnterior.Equals(Nombre)) // si el nombre anterior es igual al que ya esta escrito actualiza los datos
            {
                obj.IdArticulo = id;
                obj.IdCategoria = idCategoria;
                obj.IdMarca = idMarca;
                obj.IdTalle = idTalle;
                obj.Nombre = Nombre;
                obj.Codigo = Codigo;
                obj.PrecioCompra = PrecioCompra;
                obj.PrecioVenta = PrecioVenta;
                obj.Stock = stock;
                obj.Color = color;

                return Datos.Actualizar(obj);
            }
            else
            {
                string Existe = Datos.Existe(Nombre);
                if (Existe.Equals("1"))
                {
                    return " el articulo existe ya existe";
                }
                else
                {
                    obj.IdArticulo = id;
                    obj.IdCategoria = idCategoria;
                    obj.IdMarca = idMarca;
                    obj.IdTalle = idTalle;
                    obj.Nombre = Nombre;
                    obj.Codigo = Codigo;
                    obj.PrecioCompra = PrecioCompra;
                    obj.PrecioVenta = PrecioVenta;
                    obj.Stock = stock;
                    obj.Color = color;

                    return Datos.Actualizar(obj);
                }
            }
          


        }
        public static string Eliminar(int id)
        {
            DArticulos Datos = new DArticulos();
            return Datos.Eliminar(id);
        }

    }
}
