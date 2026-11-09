namespace exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que, a partir da leitura das medidas dos lados de um rectângulo (comprimento
            //e largura), lidos do teclado, calcule e imprima a área e o perímetro do rectângulo.
            //A fórmula da área do rectângulo é A = C * L e do perímetro P = 2 * C + 2 * L.~

            //Definir variaveis
            double comprimento, largura, area, perimetro;


            //Entrada de dados
            Console.Write("Insira o comprimento: ");
            comprimento = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a largura: ");
            largura = Convert.ToDouble(Console.ReadLine());


            //processamento
            area = comprimento * largura;
            perimetro = Math.Pow(comprimento, 2) + Math.Pow(largura, 2);


            //Saída de dados
            Console.WriteLine($"Área = {area}");
            Console.WriteLine($"Perimetro = {perimetro}");
        }
    }
}
