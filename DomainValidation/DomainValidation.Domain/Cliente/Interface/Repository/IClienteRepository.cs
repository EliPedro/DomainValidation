using System;

namespace DomainValidation.Domain.Cliente.Interface.Repository
{
    public interface IClienteRepository
    {

        void Add(Cliente cliente);
        Cliente ObterCliente(Guid id);
    }
}
