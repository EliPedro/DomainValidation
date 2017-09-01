using DomainValidation.Domain.Cliente.Validations;

namespace DomainValidation.Domain.Cliente
{
    public class Cliente
    {
        private string _PassWord { get; set; }
        private string _Cpf { get; set; }
        public Cliente(string password, string cpf)
        {
            _Cpf = cpf;
            _PassWord = password;
        }

        public bool EhValido()
        {

            if (_PassWord.Length < 6)
                ClienteValidationManagement.Add(new ClienteValidation("A Senha deve ter no mínimo 6 caracteres..."));

            if (_Cpf.Length > 10)
                ClienteValidationManagement.Add(new ClienteValidation("CPF Inválido..."));

            if (ClienteValidationManagement.Erros.Count == 0) return true;
            
            return false;
        }

    }
}
