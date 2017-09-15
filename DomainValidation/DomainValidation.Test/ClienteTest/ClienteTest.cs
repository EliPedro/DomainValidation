using Automoqer;
using DomainValidation.Domain.Cliente;
using DomainValidation.Domain.Cliente.Service;
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
            var cliente = new Cliente(Guid.NewGuid(),"Eli Pedro dos Santos");
            //var mocker = new AutoMoqer();
            

        }
    }
}
