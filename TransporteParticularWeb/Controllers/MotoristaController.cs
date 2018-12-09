using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TransporteParticularWeb.Models.TransporteModels;

namespace TransporteParticularWeb.Controllers
{
    public class MotoristaController : GenericController<Motorista>
    {
        public MotoristaController(Services.Generic.IGenericService<Motorista> service)
            :base(service)
        { }
    }
}