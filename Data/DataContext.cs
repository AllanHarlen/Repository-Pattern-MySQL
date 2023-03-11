using Microsoft.EntityFrameworkCore;
using Repository_Pattern.Models;

namespace Repository_Pattern.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {       
        
        }
        public DbSet<ClienteDTO> ClienteDTO { get; set; }
        public DbSet<PedidoDTO> PedidoDTO { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ServerVersion.AutoDetect("Server=localhost;Database=loja;uid=root;pwd=root;Port=3306;charset=utf8;"));
        }
    }
}
