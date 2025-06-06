﻿using System.Net;

namespace IntegrationTests.Cadastro
{
    public class ExclusaoProdutorRegiaoTests : IClassFixture<CustomWebApplicationFactory<ExclusaoProdutor.Program>>
    {
        private readonly HttpClient _client;

        public ExclusaoProdutorRegiaoTests(CustomWebApplicationFactory<ExclusaoProdutor.Program> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task Delete_ShouldReturnOk_WhenIdExists()
        {
            // Arrange
            int regiaoId = 2;

            // Act
            var response = await _client.DeleteAsync($"/Regiao/{regiaoId}");

            // Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

    }
}
