namespace exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A condição física de uma pessoa pode ser medida com base no cálculo do índice de Massa
            //Corporal (IMC). O mesmo é calculado dividindo-se o peso desta pessoa pelo quadrado da altura
            //em metros. Escreva um programa que leia o peso em kg e a altura de uma pessoa em metros,
            //calcule e mostre o IMC.

            //Definir variaveis
            double peso, altura, imc;


            //Entrada de dados
            Console.Write("Insira o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira a altura: ");
            altura = Convert.ToDouble(Console.ReadLine());


            //processamento
            imc = peso / Math.Pow(altura, 2);


            //Saída de dados
            Console.WriteLine($"O seu IMC é de {Math.Round(imc, 2)}");
        }
    }
}
