using System;

class Calculo:IPadrao 
{

    public void somar(int n1, int n2)
    {
        Console.WriteLine("A soma entre os numeros é:"+(n1+n2));
    }
    public void subtracao(int n1, int n2)
    {
        Console.WriteLine("A subtração entre os numeros é:"+(n1-n2));
    }


}