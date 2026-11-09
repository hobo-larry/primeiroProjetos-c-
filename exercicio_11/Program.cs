namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Elabore um programa que calcule e apresente o valor do volume de uma lata de óleo, utilizando
            //fórmula: V = 3.14159 * R * R * A, em que as variáveis: V, R e A representam respectivamente o
            //volume, o raio e a altura.

            //Definir variaveis
            double volume, raio, altura;
            volume = 3.14159;


            //Entrada de dados
            Console.Write("Introduz o raio da lata: ");
            raio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduz a altura da lata ");
            altura = Convert.ToDouble(Console.ReadLine());

            //Limpar consola
            Console.Clear();



            //Saída de dados
            Console.WriteLine($"O valor do volume: {Math.Round(volume * raio * raio * altura, 2)} ");
        }
    }
}
