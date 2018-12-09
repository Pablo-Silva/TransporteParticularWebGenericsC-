using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Services.Motorista
{
    public class MotoristaService : Generic.GenericService<Models.TransporteModels.Motorista>, IMotoristaService
    {
        public MotoristaService(Data.ApplicationDbContext context) : base(context)
        {
        }     
    }
}
