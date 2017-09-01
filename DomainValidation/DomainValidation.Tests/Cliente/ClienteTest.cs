using Xunit;
using DomainValidation.Domain.Cliente;

namespace DomainValidation.Tests
{
    public class ClienteTest
    {
        [Fact]
        public void Cliente_EhValido_True()
        {
            var cliente = new Cliente("000","000");

            Assert.True(cliente.EhValido());


        }
    }
}
