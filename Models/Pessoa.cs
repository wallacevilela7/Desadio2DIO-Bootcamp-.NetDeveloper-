using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desadio2DIO.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();


        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome) : this(nome)
        {
            Sobrenome = sobrenome;
        }
    }
}
