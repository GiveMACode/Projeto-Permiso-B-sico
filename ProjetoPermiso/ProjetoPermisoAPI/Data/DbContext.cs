namespace ProjetoPermisoAPI.Data;

using Microsoft.EntityFrameworkCore;
using ProjetoPermisoAPI.Models;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Representante> Representantes { get; set; }
    public DbSet<StatusPedido> StatusPedidos { get; set; }
    public DbSet<TipoPessoa> TipoPessoas { get; set; }
    public DbSet<Categoria> Categoria { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configurações adicionais, como chaves primárias compostas, índices, etc.
        modelBuilder.Entity<Empresa>()
            .HasKey(mp => new { mp.EmpresaId, mp.RepresentanteId, mp.TipoPessoaId, mp.EnderecoId, });

        // Configurações adicionais conforme necessário
    }
}
