using Cadastro_taxas.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Cadastro_taxas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base (options)
        {
        }
        public DbSet<Evento> Eventos { get; set; }
    }
}