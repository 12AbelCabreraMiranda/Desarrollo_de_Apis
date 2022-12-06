using System.Collections;
using System.Threading.Tasks;

namespace Apis.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable> GetAllAsync(string url);
        Task<T> GetAsync(string url, int Id);
        Task<bool> CrearAsync(string url, T itemCrear);
        Task<bool> ActualizarAsync(string url, T itemActualizar);
        Task<bool> EliminarAsync(string url, int Id);
    }
}
