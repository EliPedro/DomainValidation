using Xunit;

using DomainValidation.Domain.Cliente;

namespace DomainValidation.Tests
{
    public class ClienteTest
    {
        [Fact]
        public void Cliente_EhValido_True()
        {
            var cliente = new Cliente("00","00");

            Assert.True(cliente.EhValido());
            
        }
    }
}
