using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Models.TransporteModels
{
    //Model Cartao

    public class Cartao
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public string TipoCartao { get; set; }

        public int NumeroCartao { get; set; }

        public string BandeiraCartao { get; set; }
    }
}
