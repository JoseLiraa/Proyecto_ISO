using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SIMATIC
{
    /* La clase Mostrar cumple con el segundo principio solid "open/closed", su funcionalidad puede extenderse a través del
     * código sin necesidad de ser modificada*/ 
    class Mostrar
    {
        private SqlConnection conn;
        private string sCn;

        public DataTable Mostrar_Clientes()
        {

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pansándole como argumento la cadena
            conn = new SqlConnection(sCn);

            conn.Open();

            SqlCommand consulta = new SqlCommand(string.Format("select*from Clientes"), conn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Mostrar_Usuarios()
        {

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pansándole como argumento la cadena
            conn = new SqlConnection(sCn);

            conn.Open();

            SqlCommand consulta = new SqlCommand(string.Format("SELECT        dbo.Roles.NombreRol AS 'Roles', dbo.Usuarios.NombreUsuario, dbo.Usuarios.ClaveUsuario, dbo.Usuarios.Pregunta, dbo.Usuarios.Respuesta, dbo.Usuarios.Correo, dbo.Usuarios.Telefono " +
"FROM            dbo.Roles INNER JOIN "+
                         "dbo.UsuarioRoles ON dbo.Roles.IdRol = dbo.UsuarioRoles.IdRol INNER JOIN" +
                        " dbo.Usuarios ON dbo.UsuarioRoles.IdUsuario = dbo.Usuarios.NombreUsuario"), conn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Mostrar_Proveedores()
        {

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pansándole como argumento la cadena
            conn = new SqlConnection(sCn);

            conn.Open();

            SqlCommand consulta = new SqlCommand(string.Format("select*from Proveedores"), conn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Mostrar_Productos()
        {

            conexion.conec();

            //agrego la variable scn a la cadena conexión
            sCn = conexion.cadena;
            //creo la conexión pansándole como argumento la cadena
            conn = new SqlConnection(sCn);

            conn.Open();

            SqlCommand consulta = new SqlCommand(string.Format("select*from Productos"), conn);
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
