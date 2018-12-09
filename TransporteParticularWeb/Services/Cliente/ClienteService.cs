using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TransporteParticularWeb.Services.Cliente
{
    public class ClienteService : Generic.GenericService<Models.TransporteModels.Cliente>, IClienteService
    {
        public ClienteService(Data.ApplicationDbContext context) : base(context)
        {
        }
    }
}
