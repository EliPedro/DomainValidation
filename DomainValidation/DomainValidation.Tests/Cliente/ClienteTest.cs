using Xunit;
using DomainValidation.Domain.Cliente;

namespace DomainValidation.Tests
{
    public class ClienteTest
    {
        [Fact]
        public void Cliente_EhValido_True()
        {
            var cliente = new Cliente("000.000.000.00","12345");

            Assert.True(cliente.EhValido());


        }
    }
}
