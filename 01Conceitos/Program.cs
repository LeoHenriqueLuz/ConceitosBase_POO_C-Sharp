using System;

namespace _01Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
           // instanciar um objeto
           Pessoa obj = new Pessoa();
           
           obj.nome = "Leonardo";
           obj.idade = 36;
           obj.mensagem();
        }
    }
}
