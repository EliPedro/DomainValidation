using DomainValidation.Domain.Cliente;
using DomainValidation.Infra.Common.Validation;
using System;

namespace DomainValidationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um novo
            var cliente = new Cliente("", 0);
            cliente.IsValid();

            if(DomainValidationManagement.HasErros)
            {
                foreach (var item in DomainValidationManagement.GetAll())
                    Console.WriteLine(item.Message);
            }

            Console.ReadKey();
        }
    }
}
