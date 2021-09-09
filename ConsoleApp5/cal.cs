//Daniel Hiroshi Fugikawa - 200209

namespace ConsoleApp5
{
    //Classe para os calculos 
    class Cal
    {
        //Declaração da variavel d Pi
          public static double Pi = 3.14;

          public static double Circuferencia(double r)
        {
            //Calculo da circunferencia
            return 2.0 * Pi * r;
        }

          public static double Volume(double r)
        {
            //Calculo do volume
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
