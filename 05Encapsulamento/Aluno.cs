using System;

class Aluno 
{

    // Atributos
     private double nota1, nota2;

     //Função
     private double media()
     {
         return (nota1 + nota2)/2;
     }
     // Mensagem 
     public void Mensagem()
     {
       Console.WriteLine("Digite a 1º nota:"); //  Readline recebe como padrão o tipo String, por isso usamos Convert.ToInt32 para converter para tipo inteiro
       nota1 = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Digite a 2º nota:");
       nota2 = Convert.ToInt32(Console.ReadLine());

       Console.WriteLine("Sua média aritmética é: "+ media());

     }
}