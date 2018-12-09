using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Models.TransporteModels
{
    //Model Motorista

    public class Motorista
    {
        public int Id { get; set; }

        public string NomeMotorista { get; set; }

        public DateTime DataNascimento { get; set; }

        public char Sexo { get; set; }

        public string Cpf { get; set; }

        public string NumeroCelular { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public bool Ativo { get; set; }

        public string CarteiraMotorista { get; set; }

        public DateTime DataCadastro = DateTime.Now;

        public virtual System.Collections.Generic.ICollection<Viagem> Viagems { get; set; }
    }
}
