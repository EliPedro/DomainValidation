using System.Collections.Generic;

namespace DomainValidation.Domain.Produto.Validation
{
    public class ValidationProdutoManagement
    {
        public static IList<ValidationProduto> Erros { get; private set; }
        
        public static void AddErro(ValidationProduto newValidationProduto)
        {
            if (Erros == null)
            {
                Erros = new List<ValidationProduto>
                {
                    newValidationProduto
                };

                return;
            }

            Erros.Add(newValidationProduto);
        }

        public static IList<ValidationProduto> GetAll()
        {
            if (Erros.Count == 0) return new List<ValidationProduto>();

            return Erros;
        }
    }
}
