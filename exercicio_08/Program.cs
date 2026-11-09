namespace exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa para calcular a média final de quatro notas. A média é calculada através de
            //uma média aritmética simples (todas têm o mesmo peso).

            //Definir variaveis
            double nota1, nota2, nota3, nota4, media;


            //Entrada de dados
            Console.Write("Primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quarta nota: ");
            nota4 = Convert.ToDouble(Console.ReadLine());


            //Limpar consola
            Console.Clear();

            //processamento
            media = nota1 + nota2 + nota3 + nota4 / 4;

            //Saída de dados
            Console.WriteLine($"Média final: {media}");
        }
    }
}
