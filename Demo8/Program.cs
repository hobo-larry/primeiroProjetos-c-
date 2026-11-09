using System.Runtime.Versioning;

namespace Project1;

class Program
{
    static void Main(string[] args)
    {
        //Definir e inicializar a variáveis
        double saldo = 550.55, valorADepositar;
        string nome = "João hdadhsdsdjsd dsjdsd fsjfsfjsf ";
        char tecla = 'k';

        Console.WriteLine("Como se chama ? ");
        nome = Console.ReadLine();

        Console.WriteLine($"Quanto quer depositar {nome} ?");
        valorADepositar = Convert.ToDouble(Console.ReadLine());

        //saldo = saldo + valorADepositar;
        saldo += valorADepositar;

        //Console.ReadKey();

        Console.Clear();

        //nome = "Maria";

        Console.WriteLine($"{nome}, o seu saldo é agora de {Math.Round(saldo, 2)}");

    }
}
