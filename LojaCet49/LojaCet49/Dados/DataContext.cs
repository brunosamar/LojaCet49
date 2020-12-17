using LojaCet49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaCet49.Dados
{
    public class DataContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}
