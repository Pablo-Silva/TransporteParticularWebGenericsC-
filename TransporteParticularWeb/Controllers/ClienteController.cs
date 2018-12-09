using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporteParticularWeb.Models.TransporteModels;

namespace TransporteParticularWeb.Controllers
{
    public class ClienteController : GenericController<Cliente>
    {
        public ClienteController(Services.Generic.IGenericService<Cliente> service)
            : base(service)
        {
        }
    }
}
