
using DomainValidation.Infra.Common.Validation;

namespace DomainValidation.Domain.Cliente
{
    public class Cliente
    {
        private string Nome { get; set; }
        private byte Idade { get; set; }

        public Cliente(string nome, byte idade)
        {
            Nome = nome;
            Idade = idade;
        }
        
        public void IsValid()
        {

            if (string.IsNullOrEmpty(Nome))
                DomainValidationManagement.Add(new Infra.Common.Validation.DomainValidation("O nome não pode ser vazio"));

            if(Idade < 18)
                DomainValidationManagement.Add(new Infra.Common.Validation.DomainValidation("A idade deve ser maior que 18"));
        }        
    }
}
