namespace exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma aplicação que determine e visualize a soma e produto de 3 valores.

            //Definir variaveis
            double primeiroProduto, segundoProduto, terceiroProduto, somaTotalProdutos;


            //Entrada de dados
            Console.Write("Insira o valor do primeiro produto: ");
            primeiroProduto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o valor do segundo produto: ");
            segundoProduto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Insira o valor do terceiro produto: ");
            terceiroProduto = Convert.ToDouble(Console.ReadLine());

            //processamento
            somaTotalProdutos = primeiroProduto + segundoProduto + terceiroProduto;



            //Saída de dados
            Console.WriteLine($"A soma de {primeiroProduto} + {segundoProduto} + {terceiroProduto} = {somaTotalProdutos} ");
        }
    }
}
