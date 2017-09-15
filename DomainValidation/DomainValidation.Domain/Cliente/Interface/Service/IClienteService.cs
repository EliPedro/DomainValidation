using System;

namespace DomainValidation.Domain.Cliente.Interface.Service
{
    public interface IClienteService
    {
        void Registar(Cliente cliente);
        Cliente ObterCliente(Guid id);
    }
}
