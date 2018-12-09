using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Models.TransporteModels
{
    //Model Viagem

    public class Viagem
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }

        public int MotoristaId { get; set; }

        public Motorista Motorista { get; set; }

        public int VeiculoId { get; set; }

        public Veiculo Veiculo { get; set; }

        public string EnderecoSaida { get; set; }

        public DateTime DataSaida { get; set; } = DateTime.Now;

        public string EnderecoChegada { get; set; }

        public DateTime DataChegada { get; set; } = DateTime.Now;
    }
}
