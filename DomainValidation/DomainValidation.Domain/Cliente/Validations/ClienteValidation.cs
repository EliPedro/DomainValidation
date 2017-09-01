namespace DomainValidation.Domain.Cliente.Validations
{
    public class ClienteValidation
    {
        public string _Message { get; private set; }
        public ClienteValidation(string message)
        {
            _Message = message;
        }
    }
}
