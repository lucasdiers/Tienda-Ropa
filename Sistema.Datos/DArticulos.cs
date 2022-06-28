using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Sistema.Entidades;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class DArticulos
    {

        public DataTable listar() // metodo para listar la tabla Articulo
        {
            SqlDataReader Resultado; // permite leer secuncia de filas
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection(); // establece la conexion la bd
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_listar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader(); //ejecuta el comando
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); // cerramos la conexion
            }

        }

        public string Existe(string Valor)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_existe", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
                SqlParameter ParaExiste = new SqlParameter(); // creo un parametro
                ParaExiste.ParameterName = "@existe"; // le pongo el nombre del parametro
                ParaExiste.SqlDbType = SqlDbType.Int; // indico que es tipo entero
                ParaExiste.Direction = ParameterDirection.Output; // indico que es de tipo salida
                Comando.Parameters.Add(ParaExiste); // agrego el parametro al comando
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParaExiste.Value);
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Insertar(Articulos obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_insertar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                // agrego parametros al proc e indico el
                // nombre y el tipo y establezco el valor que sea igual a la prop de la capa entidad
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.IdCategoria; 
                Comando.Parameters.Add("@idmarca", SqlDbType.Int).Value = obj.IdMarca;
                Comando.Parameters.Add("@idtalle", SqlDbType.Int).Value = obj.IdTalle;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = obj.Codigo;
                Comando.Parameters.Add("@precio_compra", SqlDbType.Int).Value = obj.PrecioCompra;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Int).Value = obj.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = obj.Stock;
                Comando.Parameters.Add("@color", SqlDbType.VarChar).Value = obj.Color;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo ingresar el articulo";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Actualizar(Articulos obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_actualizar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo", SqlDbType.Int).Value = obj.IdArticulo;
                Comando.Parameters.Add("@idcategoria", SqlDbType.Int).Value = obj.IdCategoria;
                Comando.Parameters.Add("@idmarca", SqlDbType.Int).Value = obj.IdMarca;
                Comando.Parameters.Add("@idtalle", SqlDbType.Int).Value = obj.IdTalle;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj.Nombre;
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = obj.Codigo;
                Comando.Parameters.Add("@precio_compra", SqlDbType.Int).Value = obj.PrecioCompra;
                Comando.Parameters.Add("@precio_venta", SqlDbType.Int).Value = obj.PrecioVenta;
                Comando.Parameters.Add("@stock", SqlDbType.Int).Value = obj.Stock;
                Comando.Parameters.Add("@color", SqlDbType.VarChar).Value = obj.Color;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo actualizar el articulo";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        public string Eliminar(int id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("articulo_eliminar", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@idarticulo ", SqlDbType.Int).Value = id;

                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "NO se pudo Eliminar el articulo";
            }
            catch (Exception ex)
            {

                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }



     
    }
}













//public DataTable buscar(string Valor)
//{
//    SqlDataReader Resultado;
//    DataTable Tabla = new DataTable();
//    SqlConnection SqlCon = new SqlConnection(); // establece la conexion la bd
//    try
//    {
//        SqlCon = Conexion.getInstancia().CrearConexion();
//        SqlCommand Comando = new SqlCommand("articulo_buscar", SqlCon);
//        Comando.CommandType = CommandType.StoredProcedure;
//        Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
//        SqlCon.Open();
//        Resultado = Comando.ExecuteReader(); //ejecuta el comando
//        Tabla.Load(Resultado);
//        return Tabla;
//    }
//    catch (Exception ex)
//    {

//        throw ex;
//    }

//    finally
//    {
//        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
//    }


//}
//public DataTable BuscarCodigo(string Valor)
//{
//    SqlDataReader Resultado;
//    DataTable Tabla = new DataTable();
//    SqlConnection SqlCon = new SqlConnection();
//    try
//    {
//        SqlCon = Conexion.getInstancia().CrearConexion();
//        SqlCommand Comando = new SqlCommand("articulo_buscar_codigo", SqlCon);
//        Comando.CommandType = CommandType.StoredProcedure;
//        Comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = Valor;
//        SqlCon.Open();
//        Resultado = Comando.ExecuteReader();
//        Tabla.Load(Resultado);
//        return Tabla;
//    }
//    catch (Exception ex)
//    {
//        throw ex;
//    }
//    finally
//    {
//        if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
//    }








//}