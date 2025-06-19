using System;
using Ex_Pessoa;

class Program
{
    static void Main(string[] args)
    {
        Pessoa p = new Pessoa("Pedro", 26, 1.68);
        p.Apresentar();
    }
}