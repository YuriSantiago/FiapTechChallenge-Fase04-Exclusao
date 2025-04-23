using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace Core.Services
{
    public class ContatoService : IContatoService
    {

        private readonly IContatoRepository _contatoRepository;
        private readonly IRegiaoRepository _regiaoRepository;

        public ContatoService(IContatoRepository contatoRepository, IRegiaoRepository regiaoRepository)
        {
            _contatoRepository = contatoRepository;
            _regiaoRepository = regiaoRepository;
        }

        public void Delete(int id)
        {
            _contatoRepository.Delete(id);
        }


    }
}
