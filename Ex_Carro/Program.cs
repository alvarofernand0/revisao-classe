using System;
using Ex_Carro;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a Marca: ");
        string marca = Console.ReadLine();

        Console.Write("\n\nDigite o Modelo: ");
        string modelo = Console.ReadLine();

        Console.Write("\n\nDigite o ano: ");
        if (!int.TryParse(Console.ReadLine(), out int ano) || ano <= 0)
            Console.WriteLine("Precisa ser um numero inteiro positivo!");
        
        Carro carro = new Carro(marca, modelo, ano );
        carro.Acelerar();
        carro.ExibirStatus();
    }
}