using FIAP_MVC_PZ.Models;
using Microsoft.EntityFrameworkCore;

namespace FIAP_MVC_PZ.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
        }
        public DbSet<User> PZ_Users { get; set; }
        public DbSet<Avaliacao> PZ_Avaliacoes { get; set; }
    }
}
