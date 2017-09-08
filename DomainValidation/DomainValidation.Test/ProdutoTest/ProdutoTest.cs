using DomainValidation.Domain.Produto;
using NUnit.Framework;
using Moq;
using DomainValidation.Domain.Produto.Services.Interfaces;
using DomainValidation.Domain.Produto.Services.Service;
using DomainValidation.Test.TestDataBuilder;
using System;

namespace DomainValidation.Test.ProdutoTest
{

    [TestFixture]
    public class ProdutoTest
    {
        private ProdutoBuilder ProdutoBuilder { get; set; }

        [SetUp]
        public void Inicialization()
        {
            this.ProdutoBuilder = new ProdutoBuilder();
        }
        
        [Test]
        [Category("Produto")]
        public void Produto_EhValido_True()
        {          
            Assert.IsTrue(ProdutoBuilder.CriarProduto().EhValido());
        }

        [Test]
        [Category("Produto")]
        public void Produto_VerificaPrecoProduto_ProdutoComMenorPreco()
        {
            // arrange
            var produto = ProdutoBuilder.CriarProduto();

            Mock<IVerificadorPrecoProdutoService> mock = new Mock<IVerificadorPrecoProdutoService>();
            mock.Setup(m => m.VerificaPrecoProduto()).Returns("Produto barato!");
            VerificadorPrecoProdutoService verif = new VerificadorPrecoProdutoService(produto);

            // act
            var resultadoEsperado = mock.Object.VerificaPrecoProduto();
            var resultado = verif.VerificaPrecoProduto();
            
            Console.WriteLine("Expected :" + resultado);
            Console.WriteLine("Reality: " + resultadoEsperado);

            // assert
            Assert.AreEqual(resultado,resultadoEsperado);
       }
    }
}
