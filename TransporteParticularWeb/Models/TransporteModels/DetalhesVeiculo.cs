using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Models.TransporteModels
{
    //Model Detalhes Veiculo

    public class DetalhesVeiculo
    {
        public int Id { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public int Acento { get; set; }

        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }
    }
}
