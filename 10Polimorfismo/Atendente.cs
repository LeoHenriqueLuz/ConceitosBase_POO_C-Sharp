using System;

class Atendente:Imposto
{
   public override void valeAlimentacao(double salario)
   {
       Console.WriteLine("Desconto Atendente VA sob o Salário é de: R$"+(salario * 0.12));
   } 
  
}