using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching
{
    internal class Desenvolvedor:Funcionario
    {
        public string Linguagem { get; set; }
        public int AnosExperiencia { get; set; }
        public Desenvolvedor(string nome, int idade,string linguagem, int anosexperiencia)
        : base(nome, idade)
        {
            this.Linguagem = linguagem;
            this.AnosExperiencia = anosexperiencia;
        }
    }
}
