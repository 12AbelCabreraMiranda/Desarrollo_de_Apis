using Apis.Models;
using System.Threading.Tasks;

namespace Apis.Repository.IRepository
{
    public interface IPokemonRepository : IRepository<PokemonFavorito>
    {
        Task<PokemonFavorito> GetAsync(string rutaPokemon, object p);
    }
}
