using System;

class Imposto
{
    // Função para cálculo de desconto de imposto sobre os beneficios da empresa.
    // O Virtual permite que possamos alterar sob escrever  o método em outras classes na qual tiver herança.
public virtual void valeAlimentacao(double salario)
{
    Console.WriteLine("Desconto padrão VA sob o Salário é de: R$"+(salario * 0.1));
}

public void valeTransporte(double salario)
{
    Console.WriteLine("Desconto padrão VT sob o Salário é de: R$"+(salario * 0.06));
}


}