using DomainValidation.Domain.Produto.Validation;
using System;

namespace DomainValidation.Domain.Produto
{
    public class Produto
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }

        public Produto(Guid id, string nome, string descricao, decimal preco)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
        }

        public bool EhValido()
        {
            if (string.IsNullOrEmpty(Nome))
                ValidationProdutoManagement.AddErro(new ValidationProduto("O campo NOME obrigátorio..."));
                
            if(string.IsNullOrEmpty(Descricao))
                ValidationProdutoManagement.AddErro(new ValidationProduto("O campo DESCRIÇÃO é obrigátorio..."));

            if(Preco <= 0)
                ValidationProdutoManagement.AddErro(new ValidationProduto("O campo preço deve ser maior que ZERO..."));

            if (ValidationProdutoManagement.Erros != null) return false;
            
            return true;
        }
        
    }
}
