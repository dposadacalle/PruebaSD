using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaSD.Models.Entities;

namespace PruebaSD.Data.DataContext;

public partial class DataContextDB : DbContext
{
    public DataContextDB()
    {
    }

    public DataContextDB(DbContextOptions<DataContextDB> options)
        : base(options)
    {
    }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7SMJ1SR\\SQLEXPRESS; DataBase=PruebaSD;Integrated Security=True;TrustServerCertificate=True");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuId);

            entity.ToTable("Usuario");

            entity.Property(e => e.UsuId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("UsuID");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");

            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });
    }
}
