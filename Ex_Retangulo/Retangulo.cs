
using System.Security.Cryptography.X509Certificates;

namespace Ex_Retangulo;
public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }

    public void CalcularArea()
    {
        double largura = 80.70;
        Console.WriteLine($"A largura é: {Largura}");

        double altura = 50.60;
        Console.WriteLine($"\nA altura é: {Altura}");

        double area = largura * altura;
        Console.WriteLine($"\nA Area é: {area}");
    }
    
    public void CalcularPerimetro()
    {
        
    }
}
