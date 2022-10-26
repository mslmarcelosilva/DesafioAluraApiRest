using DesafioAluraApiRest.Data;
using DesafioAluraApiRest.Data.Repositorio;
using DesafioAluraApiRest.Data.Repositorio.Interfaces;
using DesafioAluraApiRest.Models;
using DesafioAluraApiRest.Servicos.Interfaces;

namespace DesafioAluraApiRest.Servicos
{
    public class VideoServico : IVideoServico
    {
        private readonly IVideoRepositorio _repositorio;
        public VideoServico(IVideoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public async Task<Video> Create(Video video)
        {
            return await _repositorio.Create(video);
        }

        public async Task<bool> Delete(int id)
        {
            return await _repositorio.Delete(id);
        }

        public async Task<List<Video>> GetAll()
        {
            return await _repositorio.GetAll();
        }

        public async Task<Video> GetById(int id)
        {
            return await _repositorio.GetById(id);
        }

        public async Task<Video> UpdateById(Video video)
        {
            return await _repositorio.UpdateById(video);
        }
    }
}