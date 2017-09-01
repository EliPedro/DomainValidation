using DomainValidation.Domain.Cliente;
using DomainValidation.Domain.Cliente.Validations;

namespace DomainValidation.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("000", "000");

            if(!cliente.EhValido())
            {
                foreach(var error in ClienteValidationManagement.GetAll())
                {
                    System.Console.WriteLine($"Error: {error._Message}");

                }
            }
            

            System.Console.ReadKey();

        }
    }
}