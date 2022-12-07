using Apis.Models;
using System.Collections;
using System.Threading.Tasks;

namespace Apis.Repository.IRepository
{
    public interface IPokemonRepository
    {
        Task<IEnumerable> ObtenerTodoAsync(string url);
        Task<PokemonFavorito> ObtenerAsync(string url, int PokemonId);
        Task<bool> CrearAsync(string url, PokemonFavorito model);
        Task<bool> ActualizarAsync(string url, PokemonFavorito model);
        Task<bool> EliminarAsync(string url, int PokemonId);
    }
}
