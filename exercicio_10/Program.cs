namespace exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Numa determinada região, o imposto sobre propriedade é calculado a partir de duas informações
            //- área total do terreno (m2).
            //- área construída do terreno (m2).
            //O imposto é cobrado da seguinte maneira:
            //- 50,00 Euros para cada metro quadrado construído.
            //- 5,80 Euros para cada metro quadrado não construído.
            //Faça um programa que leia a área total do terreno, a área construída do terreno, calcule e indique
            //o valor total a ser pago.

            //Definir variaveis
            double areaTotalTerreno, areaConstruida, impostoNaoConstruido, impostoConstruido, impostoAPagar;


            //Entrada de dados
            Console.Write("Introduz a área total do terreno : ");
            areaTotalTerreno = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduz a área contruída do terreno ");
            areaConstruida = Convert.ToDouble(Console.ReadLine());

            //Limpar consola
            Console.Clear();

            //processamento
            impostoNaoConstruido = (areaTotalTerreno - areaConstruida) * 5.80;
            impostoConstruido = areaConstruida * 50.00;
            impostoAPagar = impostoConstruido + impostoNaoConstruido;

            //Saída de dados
            Console.WriteLine($"O total de imposto a pagar é de {impostoAPagar}€ ");
        }
    }
}
