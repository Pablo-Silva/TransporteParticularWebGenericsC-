using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Models.TransporteModels
{
    //Model Veiculo

    public class Veiculo
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public DetalhesVeiculo DetalhesVeiculo { get; set; }

        public virtual System.Collections.Generic.ICollection<Motorista> Motoristas { get; set; }

    }
}
