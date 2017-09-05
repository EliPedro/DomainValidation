using DomainValidation.Domain.Produto;
using NUnit.Framework;
using Moq;
using DomainValidation.Domain.Produto.Services.Interfaces;
using DomainValidation.Domain.Produto.Services.Service;

namespace DomainValidation.Test.ProdutoTest
{

    [TestFixture]
    public class ProdutoTest
    {

        [Test]
        public void Produto_EhValido_True()
        {
            var produto = new Produto(1, "Notebook", "Del", 1200);
            Assert.IsTrue(produto.EhValido());

        }

        [Test]
        public void Produto_()
        {
            // arrange

            var produtoBarato = new Produto(2, "Televisor", "LG", 3000);

            Mock<IVerificadorPrecoProdutoService> mock = new Mock<IVerificadorPrecoProdutoService>();
            mock.Setup(m => m.VerificaPrecoProduto(produtoBarato)).Returns("Produto barato!");
            VerificadorPrecoProdutoService verif = new VerificadorPrecoProdutoService();

            // act

            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produtoBarato);
            var resultado = verif.VerificaPrecoProduto(produtoBarato);

            // assert
            Assert.AreEqual(resultado, resultadoEsperado);
        }
    }

}
