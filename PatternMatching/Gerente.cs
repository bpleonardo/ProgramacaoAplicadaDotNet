using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching
{
    internal class Gerente:Funcionario
    {
        public int TamanhoEquipe { get; set; }
        public Gerente(string nome, int idade, int tamanhoEquipe) : base(nome, idade)
        {
            this.TamanhoEquipe = tamanhoEquipe;
        }
    }
}
