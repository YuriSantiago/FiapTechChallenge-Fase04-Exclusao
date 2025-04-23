using Core.Interfaces.Repositories;
using Core.Services;
using Moq;

namespace ServiceTests.Services
{
    public class RegiaoServiceTests
    {

        private readonly Mock<IRegiaoRepository> _regiaoRepositoryMock;
        private readonly RegiaoService _regiaoService;

        public RegiaoServiceTests()
        {
            _regiaoRepositoryMock = new Mock<IRegiaoRepository>();
            _regiaoService = new RegiaoService(_regiaoRepositoryMock.Object);
        }

        [Fact]
        public void Delete_ShouldCallRepositoryDelete_WhenIdExists()
        {
            // Arrange
            var id = 1;

            // Act
            _regiaoService.Delete(id);

            // Assert
            _regiaoRepositoryMock.Verify(repo => repo.Delete(id), Times.Once);
        }
    }
}

