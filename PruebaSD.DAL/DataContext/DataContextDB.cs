namespace PruebaSD.Data.DataContext
{
    using Microsoft.EntityFrameworkCore;
    using PruebaSD.Entities.Entities;

    public class DataContextDB : DbContext
    {
        public DataContextDB(DbContextOptions<DataContextDB> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuID);

                entity.ToTable("Usuario");

                entity.Property(e => e.UsuID)
                    .ValueGeneratedOnAdd()            
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("UsuID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(100)
                    .HasColumnName("apellido")
                    .IsRequired(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("nombre")
                    .IsRequired(false);
            });
        }
    }
}


