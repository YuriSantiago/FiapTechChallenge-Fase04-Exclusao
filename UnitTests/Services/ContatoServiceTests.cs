using Core.Interfaces.Repositories;
using Core.Services;
using Moq;

namespace UnitTests.Services
{
    public class ContatoServiceTests
    {

        private readonly Mock<IContatoRepository> _contatoRepositoryMock;
        private readonly Mock<IRegiaoRepository> _regiaoRepositoryMock;
        private readonly ContatoService _contatoService;

        public ContatoServiceTests()
        {
            _contatoRepositoryMock = new Mock<IContatoRepository>();
            _regiaoRepositoryMock = new Mock<IRegiaoRepository>();
            _contatoService = new ContatoService(_contatoRepositoryMock.Object, _regiaoRepositoryMock.Object);
        }

        [Fact]
        public void Delete_ShouldCallRepositoryDeleteMethod()
        {
            // Arrange
            var id = 1;

            // Act
            _contatoService.Delete(id);

            // Assert
            _contatoRepositoryMock.Verify(repo => repo.Delete(1), Times.Once);
        }



    }
}
