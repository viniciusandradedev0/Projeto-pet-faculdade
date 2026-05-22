using Microsoft.EntityFrameworkCore;
using PawsPlace.Api.Models;
using PawsPlace.Api.Models.Enums;

namespace PawsPlace.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Animal> Animais => Set<Animal>();
    public DbSet<Pedido> Pedidos => Set<Pedido>();
    public DbSet<Favorito> Favoritos => Set<Favorito>();
    public DbSet<AnimalFoto> AnimaisFotos => Set<AnimalFoto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Email único por usuário
        modelBuilder.Entity<Usuario>()
            .HasIndex(u => u.Email)
            .IsUnique();

        // Slug único por animal
        modelBuilder.Entity<Animal>()
            .HasIndex(a => a.Slug)
            .IsUnique();

        // Um usuário não pode favoritar o mesmo animal duas vezes
        modelBuilder.Entity<Favorito>()
            .HasIndex(f => new { f.UsuarioId, f.AnimalId })
            .IsUnique();

        // Relacionamentos
        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Usuario)
            .WithMany(u => u.Pedidos)
            .HasForeignKey(p => p.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Pedido>()
            .HasOne(p => p.Animal)
            .WithMany(a => a.Pedidos)
            .HasForeignKey(p => p.AnimalId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Favorito>()
            .HasOne(f => f.Usuario)
            .WithMany(u => u.Favoritos)
            .HasForeignKey(f => f.UsuarioId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Favorito>()
            .HasOne(f => f.Animal)
            .WithMany(a => a.Favoritos)
            .HasForeignKey(f => f.AnimalId)
            .OnDelete(DeleteBehavior.Cascade);

        // Enums persistidos como string (legível em consultas SQL)
        modelBuilder.Entity<Animal>()
            .Property(a => a.Sexo)
            .HasConversion<string>();

        modelBuilder.Entity<Animal>()
            .Property(a => a.Porte)
            .HasConversion<string>();

        // Limites de tamanho nos campos de texto
        modelBuilder.Entity<Animal>()
            .Property(a => a.Cidade)
            .HasMaxLength(80);

        modelBuilder.Entity<Animal>()
            .Property(a => a.Estado)
            .HasMaxLength(2);

        modelBuilder.Entity<Animal>()
            .Property(a => a.Descricao)
            .HasMaxLength(600);

        // Índices para consultas de filtro (campos mais usados em WHERE)
        modelBuilder.Entity<Animal>()
            .HasIndex(a => a.Especie);

        modelBuilder.Entity<Animal>()
            .HasIndex(a => new { a.Cidade, a.Estado });

        // Relação 1:N entre Animal e AnimalFoto
        modelBuilder.Entity<AnimalFoto>()
            .HasOne(f => f.Animal)
            .WithMany(a => a.Fotos)
            .HasForeignKey(f => f.AnimalId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
