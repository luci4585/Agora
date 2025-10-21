using Service.Models;
using Service.Services;
using System.Threading.Tasks;

namespace TestAgora
{
    public class UnitTestCapacitacionService
    {
        [Fact]
        public async void TestGetCapacitacionesAbiertasAsync()
        {
            // Arrange
            var service = new CapacitacionService();
            //Act
            var result = await service.GetCapacitacionesAbiertasAsync();
            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<Inscripcion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
        }
    }
}