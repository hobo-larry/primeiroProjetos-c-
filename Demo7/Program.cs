using System.Runtime.Versioning;

namespace Project1;

class Program
{
    static void Main(string[] args)
    {
        //Exemplo com dados do tipo char (caracter)
        //Não esquecer que uma string é um conjunto de caracteres

        //Tipos principais de dados: string, int, double, char, bool

        char input;

        Console.Write("Insira um caracter: ");
        input = Console.ReadKey().KeyChar;

        Console.Clear();

        Console.WriteLine($"O caracter inserido foi o: {input}");
    }
}
