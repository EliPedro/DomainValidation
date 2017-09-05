using DomainValidation.Domain.Produto.Services.Interfaces;

namespace DomainValidation.Domain.Produto.Services.Service
{
    public class VerificadorPrecoProdutoService : IVerificadorPrecoProdutoService
    {
        public string VerificaPrecoProduto(Produto p)
        {
            if (p.Preco > 100)
                return "Produto caro!";
            else if (p.Preco <= 100 && p.Preco > 40)
                return "Produto na média de preço!";
            else
                return "Produto barato!";
        }
    }
}
