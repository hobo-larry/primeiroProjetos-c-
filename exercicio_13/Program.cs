namespace exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13. Crie um programa que leia dois valores inteiros para as variáveis A e B, e efectue a troca dos
            //valores de modo que a variável A passe a possuir o valor da variável B, e a variável B passe a
            //possuir o valor da variável A. Apresentar os valores trocados.

            //Definir variaveis
            int a, b, c;


            //Entrada de dados
            Console.Write("Introduz valor A: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduz valor B: ");
            b = Convert.ToInt32(Console.ReadLine());



            //Limpar consola
            Console.Clear();

            //processamento
            c = a;
            a = b;
            b = c;


            //Saída de dados
            Console.WriteLine($"A:{a}, B:{b}");
        }
    }
}
