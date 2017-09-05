namespace DomainValidation.Domain.Produto.Validation
{
    public class ValidationProduto
    {
        public string Messagem { get; private set; }
        public ValidationProduto(string messagem)
        {
            Messagem = messagem;
        }
    }
}
