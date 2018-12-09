using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Services.Veiculo
{
    public class VeiculoService : Generic.GenericService<Models.TransporteModels.Veiculo>
    {
        public VeiculoService(Data.ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<IEnumerable<Models.TransporteModels.Veiculo>> GetAllAsync()
        {
            var query = DbSet;
            return await query.ToListAsync();
        }
    }
}
