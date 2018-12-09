using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TransporteParticularWeb.Services.Cartao
{
    public class CartaoService : Generic.GenericService<Models.TransporteModels.Cartao>
    {
        public CartaoService(Data.ApplicationDbContext context) : base(context)
        {
        }

        public async override Task<IEnumerable<Models.TransporteModels.Cartao>> GetAllAsync()
        {
            var query = DbSet
            .Include(p => p.Cliente);
            return await query.ToListAsync();
        }
    }
}
