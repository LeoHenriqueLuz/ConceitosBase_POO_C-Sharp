using System;

class Pessoa 
{
    // Atributos protegidos
    protected string nome;
    protected int idade;

    // Função 

    protected void mensagemPessoa()
    {
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade "+idade);
    }

   
}