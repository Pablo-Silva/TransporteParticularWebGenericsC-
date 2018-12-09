using TransporteParticularWeb.Models.TransporteModels;
using Microsoft.EntityFrameworkCore;

namespace TransporteParticularWeb.Data
{
    public partial class ApplicationDbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cartao> Cartoes { get; set; }
        public DbSet<DetalhesVeiculo> DetalhesVeiculos { get; set; }
        public DbSet<Motorista> Motoristas { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
        public DbSet<ViagemRota> ViagemRotas { get; set; }

                
    }
}