
using DesafioAluraApiRest.Models;

namespace DesafioAluraApiRest.Data.Repositorio.Interfaces
{
    public interface IVideoRepositorio
    {
        Task<Video> Create(Video video);
        Task<Video> GetById(int id);
        Task<List<Video>> GetAll();
        Task<Video> UpdateById(Video video);
        Task<bool> Delete(int id);
    }
}
