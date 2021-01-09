using System;

class Pessoa
{

    //Atributos
public double peso, altura;

    // Função Calculo IMC
public double calcIMC()
{
 return peso / (altura * altura);
}
  
  // Função de retorno do IMc
   public string retornoIMC( double imc)
   {
       string retorno;

       if( imc < 18.5)
       {
           retorno = "Abaixo do peso.";
       } else if(imc < 25)
       {
           retorno = "Peso normal!";
       } else if( imc < 30)
       {
           retorno = "Acima do peso!";
       } else if( imc < 35)
       {
           retorno = "Obesidade 1";
       } else if (imc < 40)
       {
           retorno = "Obesidade 2";
       } else if(imc >= 40)
       {
           retorno = "Obesidade 3";
       } else{
           retorno = "Vixxxiii ";
       }
       return retorno;
   }
   public void mensagem()
   {
       double obterCalculo = calcIMC();
       string obterSituacao = retornoIMC(obterCalculo);
       Console.WriteLine( obterCalculo);
       Console.WriteLine(obterSituacao);
   }
   

}