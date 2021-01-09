using System;

class PessoaFisica:Padrao
{
    // Método Obrigatório
    public override void taxaEmprestimo(double valor)
    {
     Console.WriteLine("Taxa para Pessoa Física é de: R$"+( valor * 0.1));
    }

}