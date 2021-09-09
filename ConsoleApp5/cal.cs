//Daniel Hiroshi Fugikawa - 200209
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    //Classe para os calculos 
    class Cal
    {
        //Declaração da variavel d Pi
        public double Pi = 3.14;

        public double Circuferencia(double r)
        {
            //Calculo da circunferencia
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            //Calculo do volume
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
