using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching
{
    internal class Funcionario
    {  
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Funcionario(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
}
