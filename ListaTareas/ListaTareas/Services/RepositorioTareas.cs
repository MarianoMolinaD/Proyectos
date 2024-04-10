using Dapper;
using ListaTareas.Models;
using Microsoft.Data.SqlClient;

namespace ListaTareas.Services
{
    public interface IRepositorioTareas
    {
        Task Actualizar(Tareas tareas);
        Task Borrar(int id);
        Task Crear(Tareas tareas);
        Task<IEnumerable<Tareas>> Obtener();
        Task<Tareas> ObtenerPorId(int id);
    }
    public class RepositorioTareas : IRepositorioTareas
    {
        private readonly string connectionString;

        public RepositorioTareas(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<IEnumerable<Tareas>> Obtener()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<Tareas>(@"
                    SELECT * 
                    FROM Tareas");
        }
        public async Task Crear(Tareas tareas)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(
             @"INSERT INTO Tareas(Tarea,Persona,Precio)
               VALUES (@Tarea, @Persona, @Precio)",tareas
               );
        }

        public async Task Actualizar(Tareas tareas)
        {
            using var connection = new SqlConnection( connectionString);
            await connection.ExecuteAsync(@"UPDATE Tareas
                                            SET Tarea = @Tarea, Persona = @Persona, Precio = @Precio
                                            WHERE Id= @Id",tareas);
        }

        public async Task<Tareas> ObtenerPorId(int id)
        {
            using var connection = new SqlConnection(connectionString);

            return await connection.QueryFirstOrDefaultAsync<Tareas>(@"
                  SELECT * FROM Tareas WHERE Id = @Id", new {id});
        
        }

        public async Task Borrar(int id)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("DELETE Tareas WHERE Id = @Id", new {id});
        }

    }
}
