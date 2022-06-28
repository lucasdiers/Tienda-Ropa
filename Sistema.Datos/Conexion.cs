using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema.Datos
{
    public class Conexion
    { 
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null; // crea un objeto de tipo conexion

        private Conexion()
        {
            this.Base = "dbsistema";
            this.Servidor = "DESKTOP-5Q753GK\\SQLEXPRESS";
            this.Usuario = "";
            this.Clave = "";
            this.Seguridad = true;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {           // crea la cadena conexion
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (this.Seguridad) // valida el tipo de seguridad
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia() // metodo que genera una instancia al constructor
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }


    }
}
