using System;

class Pessoa // Molde
{
    // Atributos
    public string nome;
    public int idade;

    //Métodos
    public void mensagem()
    {
        Console.WriteLine(" olá " +nome+ " você tem " +idade+ " anos");
    }

}