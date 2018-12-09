using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransporteParticularWeb.Models.TransporteModels;

namespace TransporteParticularWeb.Controllers
{
    public class ViagemController : GenericController<Viagem>
    {
        public ViagemController(Services.Generic.IGenericService<Viagem> service)
            :base(service)
        { }
    }
}