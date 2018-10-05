using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Lab_Interfaces;
namespace Lab4_BD
{
    public class Estudiante
    {
        AccesoBaseDatos bd;

        /// <summary>
        /// Constructor de la clase estudiante
        /// </summary>
        public Estudiante()
        {
            // Se inicializa el objeto que realiza la conexión con la base de datos
            bd = new AccesoBaseDatos();
        }

        public int AgregarEstudiante(string Cedula, string Email, string Nombre,
                string Apellido1, string Apellido2, char sexo, string FechaNac, string Direccion,       
                string Telefono, string Carné, string Estado)
        {
            String insertar = "INSERT INTO Estudiante (Cedula, Email, Nombre," +
                              " Apellido1, Apellido2, sexo, FechaNac, Direccion, Telefono, Carné," +
                            " Estado) VALUES(" + Cedula + ", '" + Email + "', '" + Nombre + "', '" +
                              Apellido1 + "','" + Apellido2 + "', '" + sexo + "', '" + FechaNac + "', '" +
                                Direccion + "', '" + Telefono + "', '" + Carné + "', '" + Estado + "')";
            return bd.ActualizarDatos(insertar);
        }

        public SqlDataReader ObtenerListaNombresEstudiantes()
        {
            SqlDataReader datos = null;
            try
            {
                datos = bd.EjecutarConsulta("SELECT DISTINCT Nombre FROM Estudiante");
            }
            catch (SqlException ex)
            {
            }
            return datos;
        }

        public DataTable ObtenerEstudiantes(string filtroNombre, string filtroGeneral)
        {
            DataTable tabla = null;
            try
            {
                //Si los filtros son nulos se cargan todos los estudiantes de la base de datos
            if (filtroGeneral == null && filtroNombre == null)
                {
                    tabla = bd.EjecutarConsultaTabla("SELECT * FROM Estudiante" );
            }
                //Si el filtro de nombre no es nulo carga los estudiantes cuyo nombre sea el que
                //tiene el filtro
            else if (filtroGeneral != null)
                {
                    tabla = bd.EjecutarConsultaTabla("SELECT * FROM Estudiante WHERE Nombre = '" 
                        + filtroGeneral + "'" );
                    }
                //Si el filtro general no es nulo cargan los estudiantes con
                //atributos que contengan ese filtro como parte del atributo(like)
                else if (filtroNombre != null)
                {
                    tabla = bd.EjecutarConsultaTabla("SELECT * FROM Estudiante WHERE Nombre LIKE '%"
                        + filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral 
                        + "%' OR Apellido2 LIKE '%" + filtroGeneral + "%' OR Cedula LIKE '%" + 
                        filtroGeneral + "%' OR Carné LIKE '%" + filtroGeneral + "%'");
                }
                //Si ninguno de los filtros es nulo carga los estudiantes que
                //coincidan con ambos filtros
                else if (filtroGeneral != null && filtroNombre != null)
                {
                    tabla = bd.EjecutarConsultaTabla("Select * from estudiante where Nombre = '" + filtroNombre + "' && Nombre like '%" +
                    filtroGeneral + "%' OR Apellido1 like '%" + filtroGeneral +
                    "%' OR apellido2 like '%" + filtroGeneral + "%' OR Cedula like '%" 
                    + filtroGeneral + "%' OR Carné like '%" + filtroGeneral + "%'");
                }
            }
            catch (SqlException ex)
            {
            }
            return tabla;
        }

    }

}
