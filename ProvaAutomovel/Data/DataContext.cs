using ProvaAutomovel.Models;
using Microsoft.EntityFrameworkCore;

namespace ProvaAutomovel.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Automovel> Automoveis { get; set; }
    }
}