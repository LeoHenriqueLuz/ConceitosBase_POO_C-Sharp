using System;

// Quando criamos uma classe abstrata, estamos criando um padrão p/ o projeto
// Podemos ter métodos obrigatórios ou opcionais
abstract class Padrao
{
  
  // Método Obrigatório pode ser public ou protected
    public abstract void taxaEmprestimo(double valor);
    
 // Método Opcional
    public void calcPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Valor obtido na poupança é de: R$"+(valor*taxa));
    }
}