using System.Collections.Generic;

namespace DomainValidation.Domain.Cliente.Validations
{
    public class ClienteValidationManagement
    {
        public static IList<ClienteValidation> Erros { get; private set; }
    
        public static void Add(ClienteValidation newClienteValidation)
        {
            if (Erros == null)
            {
                Erros = new List<ClienteValidation>();
                Erros.Add(newClienteValidation);

                return;
            }

            Erros.Add(newClienteValidation);
        }

    }
}
