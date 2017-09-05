using DomainValidation.Domain.Produto.Validation;

namespace DomainValidation.Domain.Produto
{
    public class Produto
    {
        private int Id { get; set; }
        private string Nome { get; set; }
        private string Descricao { get; set; }
        private decimal Preco { get; set; }

        public Produto(int id, string nome, string descricao, decimal preco)
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
