using System.Runtime.Versioning;

namespace Project1;

class Program
{
    static void Main(string[] args)
    {
        //Programa que peça ao utilizador dois números e calcule a soma

        //Definir variaveis
        int numero1, numero2, resultado;

        //Entrada de dados
        Console.Write("Insira o primeiro número: ");
        numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Insira o segundo número: ");
        numero2 = Convert.ToInt32(Console.ReadLine());



        //Processamento
        resultado = numero1 + numero2;

        //Limpar a consola
        Console.Clear();

        //Saída de dados
        Console.WriteLine($"{numero1} + {numero2} = {resultado}");

    }
}
