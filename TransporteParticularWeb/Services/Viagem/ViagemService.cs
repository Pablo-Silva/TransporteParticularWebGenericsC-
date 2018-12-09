using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Services.Viagem
{
    public class ViagemService : Generic.GenericService<Models.TransporteModels.Viagem>, IViagemService
    {
        public ViagemService(Data.ApplicationDbContext context) : base(context)
        {
        }      
    }
}
