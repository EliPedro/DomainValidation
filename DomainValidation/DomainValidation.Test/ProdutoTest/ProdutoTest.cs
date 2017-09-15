using DomainValidation.Domain.Produto;
using Moq;
using DomainValidation.Domain.Produto.Services.Interfaces;
using DomainValidation.Test.TestDataBuilder;
using System;
using Xunit;
using Bogus;
using static Bogus.DataSets.Name;
using FluentAssertions;

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
            preco.Setup(p => p.VerificaPrecoProduto(produto.Id)).Returns(produto);

            // act
            var resultado = preco.Object.VerificaPrecoProduto(produto.Id);
            
            // assert
            Assert.Equal(resultado, resultado);

            // assert Fluent Assertions

            resultado.Should().BeNull();

            preco.Verify(x => x.VerificaPrecoProduto(It.IsAny<Guid>()),Times.Once);
        }

        [Fact]
        public void Produto_Bogus_Lista()
        {
            // Bogus é um gerador de dados aleatórios
            var produtoTest = new Faker<Produto>("pt-Br")
                .CustomInstantiator(p => new Produto(Guid.NewGuid(),
                p.Commerce.Product(),
                p.Commerce.ProductName(),
                p.Random.Decimal())).Generate(10);

            // assert Fluent Assertions
            produtoTest.Should().HaveCount(c => c > 10);
        }
    }
}
