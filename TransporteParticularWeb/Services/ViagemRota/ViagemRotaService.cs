using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Services.ViagemRota
{
    public class ViagemRotaService : Generic.GenericService<Models.TransporteModels.ViagemRota>
    {
        public ViagemRotaService(Data.ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<IEnumerable<Models.TransporteModels.ViagemRota>> GetAllAsync()
        {
            var query = DbSet
            .Include(p => p.Viagem);
            return await query.ToListAsync();
        }
    }
}
