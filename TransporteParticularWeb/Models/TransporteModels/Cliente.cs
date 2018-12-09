using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TransporteParticularWeb.Models.TransporteModels
{
    //Model Cliente

    public class Cliente
    {
        public int Id { get; set; }

        public string NomeCliente { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Sexo { get; set; }

        public string Cpf { get; set; }

        public string NumeroCelular { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Deficiencia { get; set; }

        public DateTime DataCadastro = DateTime.Now;

        public virtual System.Collections.Generic.ICollection<Cartao> Cartoes { get; set; }

        public virtual System.Collections.Generic.ICollection<Viagem> Viagems { get; set; }

    }
}
