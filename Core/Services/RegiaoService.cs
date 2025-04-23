using Core.Interfaces.Repositories;
using Core.Interfaces.Services;

namespace Core.Services
{
    public class RegiaoService : IRegiaoService
    {

        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

            public void Delete(int id)
            {
                _regiaoRepository.Delete(id);
            }

        }
    }
