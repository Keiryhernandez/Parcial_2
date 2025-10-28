using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaNotas.Clases;
using RepoDb;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;


namespace SistemaNotas.Repositorios
{
    internal class EstudianteRepositorio
    {
        private readonly string _conexion = ConfigurationManager.ConnectionStrings["conexionBD"].ConnectionString;

        public IEnumerable<Estudiante> ObtenerTodos()
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                return conexion.QueryAll<Estudiante>();
            }
        }

        public void Insertar(Estudiante estudiante)
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Insert(estudiante);
            }
        }

        public void Actualizar(Estudiante estudiante)
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Update(estudiante);
            }
        }

        public void Eliminar(int id)
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                conexion.Delete<Estudiante>(id);
            }
        }

        public Estudiante ObtenerPorId(int id)
        {
            using (var conexion = new SqlConnection(_conexion))
            {
                return conexion.QueryAll<Estudiante>().FirstOrDefault(e => e.Id == id);
            }
        }

    }
}
