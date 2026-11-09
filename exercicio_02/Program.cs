namespace exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa que receba um valor em euros e converta-o em dólares. Use o câmbio do dia de hoje.

            //Definir variaveis
            double valor;

            //Entrada de dados
            Console.Write("Insira o valor em euros: ");
            valor = Convert.ToDouble(Console.ReadLine());


            //Processamento
            Console.WriteLine("A converter para dollar...");
            valor *= 1.12;


            //Saída de dados
            Console.WriteLine($"Ficam {valor}$ ");
        }
    }
}
