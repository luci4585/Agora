using Microsoft.EntityFrameworkCore;
using Service.Models;

namespace Backend.DataContext
{
    public class AgoraContext: DbContext
    {
        public DbSet<TipoInscripcion> TipoInscripciones { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Capacitacion> Capacitaciones { get; set; }
        public DbSet<TipoInscripcionCapacitacion> TiposInscripcionesCapacitaciones { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }
        public AgoraContext(){ }
        public AgoraContext(DbContextOptions<AgoraContext> options) : base(options) 
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Cargamos los datos iniciales de TipoInscripcion (publico en general, Docentes, Estudiantes, Jubilados.)
            modelBuilder.Entity<TipoInscripcion>().HasData(
                new TipoInscripcion { Id = 1, Nombre = "Público en general" },
                new TipoInscripcion { Id = 2, Nombre = "Docentes" },
                new TipoInscripcion { Id = 3, Nombre = "Estudiantes" },
                new TipoInscripcion { Id = 4, Nombre = "Jubilados" }
            );

            //Cargamos los datos iniciales de Usuario (admin, user)
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nombre = "Administrador", Email = "admin@gmail.com", Password = "admin123",
                    TipoUsuario = Service.Enums.TipoUsuarioEnum.Administrador },
                new Usuario { Id = 2, Nombre = "Usuario", Email = "", Password = "user123",
                    TipoUsuario = Service.Enums.TipoUsuarioEnum.Estudiante });

            //cargamos datos semilla de capacitaciones 
            modelBuilder.Entity<Capacitacion>().HasData(
                new Capacitacion { Id = 1, Nombre = "Introducción a la Programación", Detalle = "Aprende los conceptos básicos de programación.", Ponente = "Carlos Gómez", FechaHora = DateTime.Now.AddDays(10), Cupo = 30, InscripcionAbierta = true },
                new Capacitacion { Id = 2, Nombre = "Desarrollo Web con ASP.NET Core", Detalle = "Crea aplicaciones web modernas con ASP.NET Core.", Ponente = "Ana Martínez", FechaHora = DateTime.Now.AddDays(20), Cupo = 25, InscripcionAbierta = true }
            );

            //cargamos datos semilla de TipoInscripcionCapacitacion
            modelBuilder.Entity<TipoInscripcionCapacitacion>().HasData(
                new TipoInscripcionCapacitacion { Id = 1, CapacitacionId = 1, TipoInscripcionId = 1, Costo = 10000 },
                new TipoInscripcionCapacitacion { Id = 2, CapacitacionId = 1, TipoInscripcionId = 2, Costo = 8000 },
                new TipoInscripcionCapacitacion { Id = 3, CapacitacionId = 2, TipoInscripcionId = 3, Costo = 5000 },
                new TipoInscripcionCapacitacion { Id = 4, CapacitacionId = 2, TipoInscripcionId = 4, Costo = 3000 }
            );

            //cargamos datos semilla de Inscripciones
            modelBuilder.Entity<Inscripcion>().HasData(
                new Inscripcion { Id = 1, Apellido = "Pérez", Nombre = "Juan", Dni = "12345678", Email="perezjuan@gmail.com", TipoInscripcionId = 1, CapacitacionId = 1, Acreditado = false, Importe = 10000, Pagado = false },
                new Inscripcion { Id = 2, Apellido = "Gómez", Nombre = "Ana", Dni = "87654321", Email="gomezana@gmail.com", TipoInscripcionId = 2, CapacitacionId = 2, Acreditado = false, Importe = 8000, Pagado = false },
                new Inscripcion { Id = 3, Apellido = "Lopez", Nombre = "Maria", Dni = "12345678", Email="lopezmaria@gmail.com", TipoInscripcionId = 3, CapacitacionId = 1, Acreditado = false, Importe = 5000, Pagado = false }
            );

            modelBuilder.Entity<TipoInscripcion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Usuario>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Capacitacion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<TipoInscripcionCapacitacion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Inscripcion>().HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
