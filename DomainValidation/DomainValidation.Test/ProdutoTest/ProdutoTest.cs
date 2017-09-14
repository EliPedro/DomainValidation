using DomainValidation.Domain.Produto;
using Moq;
using DomainValidation.Domain.Produto.Services.Interfaces;
using DomainValidation.Test.TestDataBuilder;
using System;
using Xunit;
using Bogus;
using static Bogus.DataSets.Name;

namespace DomainValidation.Test.ProdutoTest
{

    public class ProdutoTest
    {
        private ProdutoBuilder ProdutoBuilder = new ProdutoBuilder();

        [Fact]
        public void Produto_EhValido_True()
        {
            Assert.True(ProdutoBuilder.CriarProduto().EhValido());
        }

        [Fact]
        public void Produto_VerificaPrecoProduto_ProdutoComMenorPreco()
        {
            // arrange
            var produto = ProdutoBuilder.CriarProduto();

            var preco = new Mock<IVerificaPrecoProdutoService>();
            preco.Setup(m => m.VerificaPrecoProduto(produto.Id)).Returns(produto);
            
            // act
            var resultado = preco.Object.VerificaPrecoProduto(produto.Id);
            

            Console.WriteLine("Expected :" + produto);
            Console.WriteLine("Reality: " + resultado);

            // assert
            Assert.Equal(resultado, resultado);

            preco.Verify(x => x.VerificaPrecoProduto(It.IsAny<Guid>()),Times.Once);
        }

        [Fact]
        public void Produto_Lista_Teste()
        {
            // Bogus é um gerador de dados aleatórios
            var produtoTest = new Faker<Produto>("pt-Br")
                .CustomInstantiator(p => new Produto(Guid.NewGuid(),
                p.Name.FirstName(Gender.Female),
                p.Name.LastName(Gender.Female),
                p.Random.Decimal())).Generate(10);
        }
    }
}
