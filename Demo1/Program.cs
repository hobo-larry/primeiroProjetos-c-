using System.Runtime.Versioning;

namespace Project1;

class Program
{
    static void Main(string[] args)
    {
        //Definir variáveis
        string primeiroNome, apelido;

        //Entrada de dados
        Console.Write("Qual é o seu primeiro nome:");
        primeiroNome = Console.ReadLine();

        
        Console.WriteLine("Insira o seu apelido:");
        apelido = Console.ReadLine();

        Console.Clear();

        Console.WriteLine($"olá {primeiroNome} {apelido}.");


    }
}
