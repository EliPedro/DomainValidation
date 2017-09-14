using System;

namespace DomainValidation.Domain.Produto.Services.Interfaces
{
    public interface IVerificaPrecoProdutoService
    {
        Produto VerificaPrecoProduto(Guid id);
    }
}
