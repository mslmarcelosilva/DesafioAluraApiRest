using DesafioAluraApiRest.Models;
using System.Threading.Tasks;

namespace DesafioAluraApiRest.Servicos.Interfaces
{
    public interface IVideoServico
    {
        Task<Video> Create(Video video);
        Task<Video> GetById(int id);
        Task<List<Video>> GetAll();
        Task<Video> UpdateById(Video video);
        Task<bool> Delete(int id);
    }
}
