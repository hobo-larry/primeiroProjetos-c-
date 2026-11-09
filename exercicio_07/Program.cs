namespace exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma aplicação que obtenha os valores de a, b, c e d dando de seguida os resultados das
            //seguintes expressões:

            //Definir variaveis
            double a, b, c, d, primeiroCalculo, segundoCalculo, terceiroCalculo, quartoCalculo;


            //Entrada de dados
            Console.Write("Insira o valor do A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o valor do B: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o valor do C: ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o valor do D: ");
            d = Convert.ToDouble(Console.ReadLine());


            //Limpar consola
            Console.Clear();

            //processamento
            primeiroCalculo = 2 * b;
            segundoCalculo = (2 * c + Math.Pow(b, 2)) / (3 * d);
            terceiroCalculo = 3 * Math.Pow(c, 2) * 4;
            quartoCalculo = 3 * a * c * (25 + 6);

            //Saída de dados
            Console.WriteLine($"Primeiro resultado: {primeiroCalculo}");
            Console.WriteLine($"Segundo resultado: {Math.Round(segundoCalculo, 2)}");
            Console.WriteLine($"Terceiro resultado: {terceiroCalculo}");
            Console.WriteLine($"Quarto resultado: {quartoCalculo}");

        }
    }
}
