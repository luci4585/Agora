using Microsoft.EntityFrameworkCore;
using Service.Enums;
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
            //cargamos los datos iniciales de usuarios
            var fechaNula = new DateTime(1900, 1, 1);

            // ---------- USUARIOS ----------
            var usuarios = new[]
            {
            new Usuario { Id = 1, Apellido = "Ramírez", Nombre = "Tadeo", Dni = "43111222", Email = "tadeo@isp20.edu.ar", TipoUsuario = TipoUsuarioEnum.Estudiante, DeleteDate = fechaNula, IsDeleted = false },
            new Usuario { Id = 2, Apellido = "Gómez",   Nombre = "Lucía", Dni = "40222333", Email = "lucia.gomez@isp20.edu.ar", TipoUsuario = TipoUsuarioEnum.Estudiante, DeleteDate = fechaNula, IsDeleted = false },
            new Usuario { Id = 3, Apellido = "Pérez",   Nombre = "Martín",Dni = "39555111", Email = "martin.perez@isp20.edu.ar", TipoUsuario = TipoUsuarioEnum.Estudiante, DeleteDate = fechaNula, IsDeleted = false },
            new Usuario { Id = 4, Apellido = "Sosa",    Nombre = "Carla", Dni = "38888999", Email = "carla.sosa@isp20.edu.ar",  TipoUsuario = TipoUsuarioEnum.Estudiante, DeleteDate = fechaNula, IsDeleted = false },
            new Usuario { Id = 5, Apellido = "López",   Nombre = "Diego", Dni = "37777666", Email = "diego.lopez@isp20.edu.ar", TipoUsuario = TipoUsuarioEnum.Docente,    DeleteDate = fechaNula, IsDeleted = false },
            // Cobrador/Admin
            new Usuario { Id = 6, Apellido = "Admin",   Nombre = "Soporte", Dni = "00000000", Email = "soporte@agora.isp20.edu.ar", TipoUsuario = TipoUsuarioEnum.Administrador, DeleteDate = fechaNula, IsDeleted = false }
            };
                    modelBuilder.Entity<Usuario>().HasData(usuarios);

            //cargamos datos semilla de capacitaciones 
            modelBuilder.Entity<Capacitacion>().HasData(
                new Capacitacion { Id = 1, Nombre = "Introducción a la Programación", Detalle = "Aprende los conceptos básicos de programación.", Ponente = "Carlos Gómez", FechaHora = DateTime.Now.AddDays(10), Cupo = 30, InscripcionAbierta = true },
                new Capacitacion { Id = 2, Nombre = "Desarrollo Web con ASP.NET Core", Detalle = "Crea webapps modernas con ASP.NET Core.", Ponente = "Ana Martínez", FechaHora = DateTime.Now.AddDays(20), Cupo = 25, InscripcionAbierta = true }
                , new Capacitacion { Id = 3, Nombre = "Curso SQL", Detalle = "Aprende a manejar bases de datos con SQL.", Ponente = "Luis Pérez", FechaHora = DateTime.Now.AddDays(15), Cupo = 20, InscripcionAbierta = true }
                , new Capacitacion { Id = 4, Nombre = "Taller de JavaScript", Detalle = "Domina JavaScript para desarrollo web.", Ponente = "Marta López", FechaHora = DateTime.Now.AddDays(25), Cupo = 30, InscripcionAbierta = true }
            );

            //cargamos datos semilla de TipoInscripcionCapacitacion
            modelBuilder.Entity<TipoInscripcionCapacitacion>().HasData(
                new TipoInscripcionCapacitacion { Id = 1, CapacitacionId = 1, TipoInscripcionId = 1, Costo = 10000 },
                new TipoInscripcionCapacitacion { Id = 2, CapacitacionId = 1, TipoInscripcionId = 2, Costo = 8000 },
                new TipoInscripcionCapacitacion { Id = 3, CapacitacionId = 2, TipoInscripcionId = 3, Costo = 5000 },
                new TipoInscripcionCapacitacion { Id = 4, CapacitacionId = 2, TipoInscripcionId = 4, Costo = 3000 }
            );

            //cargamos datos semilla de Inscripciones
            var inscripciones = new[]
{
                 // Históricas (acreditadas)
                 new Inscripcion { Id = 1,  UsuarioId = 1, TipoInscripcionId = 1, CapacitacionId = 1, Acreditado = true,  Importe = 0m,     Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                 new Inscripcion { Id = 2,  UsuarioId = 2, TipoInscripcionId = 1, CapacitacionId = 1, Acreditado = true,  Importe = 12000m, Pagado = false,  UsuarioCobroId = null,    IsDeleted = false },
                 new Inscripcion { Id = 3,  UsuarioId = 3, TipoInscripcionId = 3, CapacitacionId = 1, Acreditado = true,  Importe = 0m,     Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                 new Inscripcion { Id = 4,  UsuarioId = 5, TipoInscripcionId = 2, CapacitacionId = 2, Acreditado = true,  Importe = 8000m,  Pagado = false,  UsuarioCobroId = null,    IsDeleted = false },
                 new Inscripcion { Id = 5,  UsuarioId = 4, TipoInscripcionId = 1, CapacitacionId = 2, Acreditado = true,  Importe = 12000m, Pagado = false,  UsuarioCobroId = null,    IsDeleted = false },

                 // Vigente (no acreditadas aún)
                 new Inscripcion { Id = 6,  UsuarioId = 1, TipoInscripcionId = 1, CapacitacionId = 3, Acreditado = false, Importe = 15000m, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                 new Inscripcion { Id = 7,  UsuarioId = 2, TipoInscripcionId = 3, CapacitacionId = 3, Acreditado = false, Importe = 0m,     Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                 new Inscripcion { Id = 8,  UsuarioId = 3, TipoInscripcionId = 1, CapacitacionId = 3, Acreditado = false, Importe = 15000m, Pagado = false,  UsuarioCobroId = null,    IsDeleted = false },
                 new Inscripcion { Id = 9,  UsuarioId = 4, TipoInscripcionId = 1, CapacitacionId = 3, Acreditado = false, Importe = 15000m, Pagado = false, UsuarioCobroId = null, IsDeleted = false },
                 new Inscripcion { Id = 10, UsuarioId = 5, TipoInscripcionId = 2, CapacitacionId = 3, Acreditado = false, Importe = 10000m, Pagado = false,  UsuarioCobroId = null,    IsDeleted = false }
                 };
                            modelBuilder.Entity<Inscripcion>().HasData(inscripciones);


            modelBuilder.Entity<TipoInscripcion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Usuario>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Capacitacion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<TipoInscripcionCapacitacion>().HasQueryFilter(p => !p.IsDeleted);
            modelBuilder.Entity<Inscripcion>().HasQueryFilter(p => !p.IsDeleted);
        }
    }
}
