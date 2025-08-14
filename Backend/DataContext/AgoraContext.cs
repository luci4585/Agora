namespace Backend.DataContext
{
    public class AgoraContext: DbContext
    {
        public AgoraContext(){ }
        public AgoraContext(DbContextOptions<AgoraContext> options) : base(options) 
        { 
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoInscripcion>().HasData(
                new TipoInscripcion { Id = 1, Nombre = "Público en general" },
                new TipoInscripcion { Id = 2, Nombre = "Docentes" },
                new TipoInscripcion { Id = 3, Nombre = "Estudiantes" },
                new TipoInscripcion { Id = 4, Nombre = "Jubilados" }
            );

            modelBuilder.Entity<TipoInscripcion>().HasQueryFilter("Actividades");
            modelBuilder.Entity<Service.Models.Entrega>().ToTable("Entregas");
        }
    }
}
