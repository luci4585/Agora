using Service.Models;
using Service.Services;

namespace TestAgora
{
    public class UnitTestGenericService
    {
        [Fact]
        public void TestGetAll()
        {
            // Arrange
            var service = new GenericService<Usuario>();
            //Act
            var result = service.GetAllAsync(null).Result;
            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<Usuario>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
        }
    }
}