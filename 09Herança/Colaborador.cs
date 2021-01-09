using System;

class Colaborador:Pessoa //  A class Colaborador herdou os atributos Protcted e public de class Pessoa.

{
    // Atributos
    private double salario;
    
    // Constructor
    public Colaborador( string nome, int idade, double salario)
    {
      this.nome=nome;   
      this.idade=idade;
      this.salario=salario;

      mensagemPessoa();
      mensagemColaborador();
    
    }
    
    
    
    // Função
    private void mensagemColaborador()
    {
        Console.WriteLine("Salário: R$ "+ salario);
    }
  


}