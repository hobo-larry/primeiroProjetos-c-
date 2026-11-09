namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //12. Elabore um programa que leia uma temperatura em graus Fahrenheit e apresente convertida em
            //graus Celsius. A fórmula de conversão de temperatura a ser utilizada é C = (F – 32) * 5 / 9, em
            //que a variável F é a temperatura em graus Fahrenheit e a variável C é a temperatura em graus Celsius.

            //Definir variaveis
            double f, c;



            //Entrada de dados
            Console.Write("Introduz temperatura em Fahrenheit ");
            f = Convert.ToDouble(Console.ReadLine());



            //Limpar consola
            Console.Clear();

            //processamento
            c = (f - 32) * 5 / 9;


            //Saída de dados
            Console.WriteLine($"{f}Fahrenheit converte-se para : {Math.Ceiling(c)} Celsius "); //arredondei para cima para ficar mais bonito

        }
    }
}
