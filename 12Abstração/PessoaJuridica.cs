using System;

class PessoaJuridica:Padrao
{
    // Método Obrigatório
    public override void taxaEmprestimo(double valor)
    {
     Console.WriteLine("Taxa para Pessoa Jurídica é de: R$"+( valor * 0.2));
    }
}