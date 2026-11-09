using System.Runtime.Versioning;

namespace Project1;

class Program
{
    static void Main(string[] args)
    {
        //Programa para pedir dois números com casas decimais e calcular a sua média
        //com menos uma variável

        //Definir variáveis
        double n1, n2, media;

        //Entrada de dados
        Console.Write("Insira o primeiro valor: ");
        n1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Insira o segundo valor: ");
        n2 = Convert.ToDouble(Console.ReadLine());

        //Processamento
        //media = (n1 + n2) / 2;

        //Saída de dados
        Console.WriteLine($"A média dos valores introduzidos é de {Math.Round((n1 + n2) / 2, 2)}");

    }
}
