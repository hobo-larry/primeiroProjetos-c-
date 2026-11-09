namespace exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie uma aplicação que peça o nome e apelido e responda com “Olá, nome e apelido. Como Vai ?”

            //Definir variaveis
            string nome, apelido;

            //Entrada de dados
            Console.Write("Insira o seu primeiro nome: ");
            nome = Console.ReadLine();

            Console.Write("Insira o seu apelido: ");
            apelido = Console.ReadLine();


            //Limpar a consola
            Console.Clear();

            //Saída de dados
            Console.WriteLine($"Olá, {nome} {apelido}. Como vai ?");
        }
    }
}
