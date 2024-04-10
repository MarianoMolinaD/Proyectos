using Dapper;
using GestionEstudiantes.Models;
using Microsoft.Data.SqlClient;

namespace GestionEstudiantes.Servicios
{
    public interface IRepositorioEstudiantes
    {

    }
    public class RepositorioEstudiantes : IRepositorioEstudiantes
    {
        private readonly string connectionString;

        public RepositorioEstudiantes(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Estudiante>> Obtener()
        {
            using var connection = new SqlConnection(connectionString);

            return await connection.QueryAsync<Estudiante>("SELECT * FROM Datos");
        }
    }
}
