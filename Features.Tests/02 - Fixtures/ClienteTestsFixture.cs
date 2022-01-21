using System;
using Features.Clientes;
using Xunit;

namespace Features.Tests
{
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection : ICollectionFixture<ClienteTestsFixture>
    {}

    public class ClienteTestsFixture : IDisposable
    {
        public Cliente GerarClienteValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "Nome",
                "Completo",
                DateTime.Now.AddYears(-30),
                "nome@nome.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public Cliente GerarClienteInValido()
        {
            var cliente = new Cliente(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "nome2nome.com",
                true,
                DateTime.Now);

            return cliente;
        }

        public void Dispose()
        {
        }
    }
}