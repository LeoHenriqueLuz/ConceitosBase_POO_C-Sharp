using System;

namespace _11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Instanciar Estagiário
            Imposto objA = new Estagiario();
            objA.valeAlimentacao(1000);
            objA.valeTransporte(1000);
            Console.WriteLine("============================");
           
            // Instanciar Gerente
            Imposto objB = new Gerente();
            objB.valeAlimentacao(5000);
            objB.valeTransporte(5000);
            Console.WriteLine("============================");

            // Instanciar Atendente
            Imposto objC = new Atendente();
            objC.valeAlimentacao(2000);
            objC.valeTransporte(2000);
            

            
           
        
        }
    }
}
