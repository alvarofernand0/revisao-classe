
using System.Security.Cryptography.X509Certificates;

namespace Ex_Retangulo;
public class Retangulo(double largura, double altura)
{
    public double Largura { get; set; } = largura;
    public double Altura { get; set; } = altura;

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
