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
        [Category("Produto")]
        public void Produto_EhValido_True()
        {
            var produto = new Produto(1, "Notebook", "Del", 1200);
            Assert.IsTrue(produto.EhValido());

        }

        [Test]
        [Category("Produto")]
        public void Produto_VerificaPrecoProduto_ProdutoComMenorPreco()
        {
            // arrange

            var produtoBarato = new Produto(2, "Televisor", "LG Tela Plana! Promoção..", 55);

            Mock<IVerificadorPrecoProdutoService> mock = new Mock<IVerificadorPrecoProdutoService>();
            mock.Setup(m => m.VerificaPrecoProduto(produtoBarato)).Returns("Produto barato!");
            VerificadorPrecoProdutoService verif = new VerificadorPrecoProdutoService();

            // act
            var resultadoEsperado = mock.Object.VerificaPrecoProduto(produtoBarato);
            var resultado = verif.VerificaPrecoProduto(produtoBarato);


            System.Console.WriteLine("Expected :" + resultado);
            System.Console.WriteLine("Reality: " + resultadoEsperado);


            // assert
            Assert.AreEqual(resultado,resultadoEsperado);
       }
    }

}
