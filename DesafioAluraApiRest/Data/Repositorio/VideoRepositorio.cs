using DesafioAluraApiRest.Data.Repositorio.Interfaces;
using DesafioAluraApiRest.Models;
using Microsoft.EntityFrameworkCore;

namespace DesafioAluraApiRest.Data.Repositorio
{
    public class VideoRepositorio : IVideoRepositorio
    {
        private readonly DesafioBackendAluraContext _contexto;
        public VideoRepositorio(DesafioBackendAluraContext contexto)
        {
            _contexto = contexto;
        }
        public async Task<Video> Create(Video video)
        {
            await _contexto.AddAsync(video);
            await _contexto.SaveChangesAsync();
            return video;
        }

        public async Task<bool> Delete(int id)
        {
            var video = await _contexto.Videos.FirstOrDefaultAsync(x => x.Id == id);
            if (video == default)
            {
                return false;
            }
            _contexto.Remove(video);
            await _contexto.SaveChangesAsync();
            return true;
        }

        public async Task<List<Video>> GetAll()
        {
            return await _contexto.Videos.ToListAsync();
        }

        public async Task<Video> GetById(int id)
        {
            return await _contexto.Videos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Video> UpdateById(Video video)
        {
            _contexto.Update(video);
            await _contexto.SaveChangesAsync();
            return video;
        }
    }
}
