using Service.Models;
using Service.Services;
using System.Threading.Tasks;

namespace TestAgora
{
    public class UnitTestGenericService
    {
        [Fact]
        public void TestGetAllInscripciones()
        {
            // Arrange
            var service = new GenericService<Inscripcion>();
            //Act
            var result = service.GetAllAsync(null).Result;
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
        [Fact]
        public void TestGetAllCapacitaciones()
        {
            // Arrange
            var service = new GenericService<Capacitacion>();
            //Act
            var result = service.GetAllAsync(null).Result;
            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<Capacitacion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
        }
        [Fact]
        public void TestGetAllUsuarios()
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
        [Fact]
        public async void TestGetAllTipoInscripciones()
        {
            // Arrange
            var service = new GenericService<TipoInscripcion>();
            //Act
            var result = await service.GetAllAsync(null);
            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<TipoInscripcion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
        }
        [Fact]
        public void TestGetAllTiposInscripcionesCapacitaciones()
        {
            // Arrange
            var service = new GenericService<TipoInscripcionCapacitacion>();
            //Act
            var result = service.GetAllAsync(null).Result;
            //Assert
            Assert.NotNull(result);
            Assert.IsType<List<TipoInscripcionCapacitacion>>(result);
            Assert.True(result.Count > 0);
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, CapacitacionId: {item.CapacitacionId}");
            }
        }
        [Fact]
        public async void TestGetByIdTipoInscripcion()
        {
            // Arrange
            var service = new GenericService<TipoInscripcion>();
            int idToTest = 1; // Id de la inscripcion a buscar
            //Act
            var result = await service.GetByIdAsync(idToTest);
            //Assert
            Assert.NotNull(result);
            Assert.IsType<TipoInscripcion>(result);
            Assert.Equal(idToTest, result.Id);
            Assert.Equal("Público en general", result.Nombre);
            //imprimimos la inscripcion
            Console.WriteLine($"Id: {result.Id}, Nombre: {result.Nombre}");
        }
        [Fact]
        public async void TestDeleteInscripcion()
        {
            // Arrange
            var service = new GenericService<Inscripcion>();
            int idToDelete = 3; // Id de la inscripcion a eliminar
            //Act
            var result = await service.DeleteAsync(idToDelete);
            //Assert
            Assert.True(result);
            Console.WriteLine($"Inscripcion con Id {idToDelete} eliminada: {result}");
        }
        [Fact]
        public async void TestAddTipoInscripcion() 
        {
            // Arrange
            var service = new GenericService<TipoInscripcion>();
            var newTipoInscripcion = new TipoInscripcion
            {
                Nombre = "Estudiante instituto"
            };
            //Act
            var result = await service.AddAsync(newTipoInscripcion);
            //Assert
            Assert.NotNull(result);
            Assert.IsType<TipoInscripcion>(result);
            Assert.Equal(newTipoInscripcion.Nombre, result.Nombre);
            //imprimimos la inscripcion
            Console.WriteLine($"Id: {result.Id}, Nombre: {result.Nombre}");
        }
        [Fact]
        public async void TestDeletedsCapacitaciones()
        {
            // Arrange
            var service = new GenericService<Capacitacion>();
            // Act
            var result = await service.GetAllDeletedsAsync();
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Capacitacion>>(result);
            Assert.True(result.Count == 1); // Asumiendo que siempre hay datos en la base de datos
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
        }
    }
}