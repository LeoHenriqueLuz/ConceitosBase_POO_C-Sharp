using System;

class Gerente:Imposto
{
    // Função
    // override significa que estamos sobreescrevendo um método e desta forma que definimos o conceito de polimorfismo.
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto Gerente VA sob o Salário é de: R$"+(salario * 0.15));
    }
   
    
}
