//Daniel Hiroshi Fugikawa - 200209
using System;
using System.Globalization;


namespace ConsoleApp5
{
    class Program
    {
      
        static void Main(string[] args)
        {
            //Declaração da classe cal
            //Cal calc = new Cal();

            //Solicitando o valor do raio ao usuario
            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Criando variaveis para carregar o valor das funções
            double circ = Cal.Circuferencia(raio);
            double volume = Cal.Volume(raio);

            //Impressa dos resultados 
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Cal.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

    }
}
