using System.Collections.Generic;

namespace DomainValidation.Domain.Cliente.Validations
{
    public class ClienteValidationManagement
    {
        public static List<ClienteValidation> Erros { get; private set; }
    
        public static void Add(ClienteValidation newClienteValidation)
        {
            if (Erros == null)
            {
                Erros = new List<ClienteValidation>
                {
                   newClienteValidation
                };
                
                return;
            }

            Erros.Add(newClienteValidation);
        }

        public static List<ClienteValidation> GetAll()
        {
            return Erros;
        }

    }
}
