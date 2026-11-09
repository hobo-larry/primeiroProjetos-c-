namespace exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uma parede em formato rectangular, cuja altura é hp (altura da parede) e a largura lp (largura
            //da parede) precisa ser coberta por azulejos também rectangulares. O azulejo rectangular tem
            //dimensões ha (altura do azulejo) e la (largura do azulejo).
            //Escreva um programa que leia as quatro medidas hp, lp, ha e la, calcule e imprima quantos
            //azulejos com as medidas dadas são necessários para cobrir a parede dada

            //Definir variaveis
            double hp, lp, ha, la, areaParede, areaAzulejo, azulejosNecessarios;


            //Entrada de dados
            Console.Write("Introduz a altura da parede: ");
            hp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduz a largura da parede: ");
            lp = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduz a altura do azulejo: ");
            ha = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduz a largura do azulejo: ");
            la = Convert.ToDouble(Console.ReadLine());


            //Limpar consola
            Console.Clear();

            //processamento
            areaParede = hp * lp;
            areaAzulejo = ha * la;
            // usei Math.ceiling para arredondar para a cima porque não se compra fraçoes de azulejos
            azulejosNecessarios = Math.Ceiling(areaParede / areaAzulejo);

            //Saída de dados
            Console.WriteLine($"São precisos {azulejosNecessarios} azulejos para cobrir a parede");

        
    
}
    }
}
