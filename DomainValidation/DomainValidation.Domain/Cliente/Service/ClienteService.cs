using DomainValidation.Domain.Cliente.Interface.Repository;
using DomainValidation.Domain.Cliente.Interface.Service;

namespace DomainValidation.Domain.Cliente.Service
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _IClienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _IClienteRepository = clienteRepository;
        }
    }
}
