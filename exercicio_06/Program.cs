namespace exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Crie uma aplicação que mediante a introdução pelo utilizador dos valores da base e altura de um
            //triângulo, apresente a área.
            //Formula : Base x Altura/2

            //Definir variaveis
            double baseTriangulo, altura, area;


            //Entrada de dados
            Console.Write("Insira a base: ");
            baseTriangulo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());


            //processamento
            area = baseTriangulo * altura / 2;

            //Saída de dados
            Console.WriteLine($"Área do triângulo = {area}");
        }
    }
}
