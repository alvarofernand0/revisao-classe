using System;
using System.Collections.Generic;

namespace Ex_Pessoa
{
    public class Pessoa
    {
        string Nome { get; set; }
        int Idade { get; set; }
        double Altura { get; set; }

        public Pessoa(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e {Altura}m de altura");
        }
    }
}