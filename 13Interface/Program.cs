using System;

namespace _14Interface
{
    class Program
    {
        static void Main(string[] args)
        {
           Calculo soma = new Calculo();
           soma.somar(20,20);

           Calculo subtrair = new Calculo();
           subtrair.subtracao(40,20);
        }
    }
}
