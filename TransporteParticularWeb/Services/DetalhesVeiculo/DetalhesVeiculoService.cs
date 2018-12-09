using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TransporteParticularWeb.Services.DetalhesVeiculo
{
    public class DetalhesVeiculoService : Generic.GenericService<Models.TransporteModels.DetalhesVeiculo>
    {
        public DetalhesVeiculoService(Data.ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<IEnumerable<Models.TransporteModels.DetalhesVeiculo>> GetAllAsync()
        {
            var query = DbSet;
            return await query.ToListAsync();
        }
    }
}
