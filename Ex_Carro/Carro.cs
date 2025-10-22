
using System.Linq.Expressions;

namespace Ex_Carro
{
    public class Carro
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double VelocidadeAtual { get; set; } = 0;

        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }
        public void Acelerar()
        {
            Console.WriteLine($"\nA Velocidade atual é: {VelocidadeAtual}km/h\n");
            Console.Write($"Digite um número maior que 0 para aumentar a velocidade: ");
            double adicionar = 0;

            if (!double.TryParse(Console.ReadLine(), out adicionar) || adicionar <= 0)
                Console.WriteLine("\n\nPrecisa ser um número maior que zero!");
            VelocidadeAtual += adicionar;
        }
        public void Frear()
        {
            Console.WriteLine($"A Velocidade atual é: {VelocidadeAtual}km/h\n");
            Console.Write($"\nDigite um número maior que zero para diminuir a velocidade: ");
            double diminuir = 0;

            if (!double.TryParse(Console.ReadLine(), out diminuir) || diminuir <= 0)
                Console.WriteLine("Precisa ser um número Maior que zero!");
            VelocidadeAtual -= diminuir;
        }

        public void ExibirStatus()
        {
            Console.WriteLine($"\nVeiculo de Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}, Com Velocidade Atual: {VelocidadeAtual}km/h\n");
            
        }
    }
}