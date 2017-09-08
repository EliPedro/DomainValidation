using DomainValidation.Domain.Produto.Services.Interfaces;

namespace DomainValidation.Domain.Produto.Services.Service
{
    public class VerificadorPrecoProdutoService : IVerificadorPrecoProdutoService
    {
        private readonly Produto _produto;
        public VerificadorPrecoProdutoService(Produto produto)
        {
            _produto = produto;

        }
        public string VerificaPrecoProduto()
        {
            if (_produto.Preco > 100)
                return "Produto caro!";
            else if (_produto.Preco <= 100 && _produto.Preco > 40)
                return "Produto na média de preço!";
            else
                return "Produto barato!";
        }
    }
}
