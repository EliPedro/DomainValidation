using System;

namespace DomainValidation.Domain.Cliente
{
    public class Cliente
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }

        public Cliente(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
