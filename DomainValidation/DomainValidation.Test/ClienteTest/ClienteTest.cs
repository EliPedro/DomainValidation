using DomainValidation.Domain.Cliente;
using DomainValidation.Domain.Cliente.Interface.Repository;
using DomainValidation.Domain.Cliente.Service;
using Moq;
using System;
using Xunit;

namespace DomainValidation.Test.ClienteTest
{
    // Apresentando o AutoMoq
    public class ClienteTest
    {

        [Fact]
        public void Cliente_RegistrarNovoCliente_DeverarRegistrarComSucesso()
        {
            // arrange
            var newcliente = new Cliente(Guid.NewGuid(),"xxxxxxxxxxxx");            
            var clienteRepository = new Mock<IClienteRepository>();
            var clienteService = new ClienteService(clienteRepository.Object);

            // act
            clienteService.Registar(newcliente);

            // assert
            clienteRepository.Verify(c => c.Add(It.IsAny<Cliente>()), Times.Once, "Erro");

        }
    }
}
