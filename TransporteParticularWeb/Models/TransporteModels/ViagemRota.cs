using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Models.TransporteModels
{
    //Model Viagem Rota

    public class ViagemRota
    {
        public int Id { get; set; }

        public int ViagemId { get; set; }
        public Viagem Viagem { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
