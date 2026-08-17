using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching
{
    internal class Estagiario:Funcionario
    {
        public int HorasSemanais { get; set; }
        public Estagiario(string nome, int idade, int horassemanais) : base(nome, idade)
        {
            this.HorasSemanais = horassemanais;
        }
    }
}
