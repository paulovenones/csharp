using System;

namespace _01_ByteBank
{
  class Program
  {
    static void Main(string[] args)
    {
      Cliente paulo = new Cliente();

      paulo.nome = "Paulo";
      paulo.profissao = "Desenvolvedor full stack";
      paulo.cpf = "524.643.123-99";

      ContaCorrente conta = new ContaCorrente();
      conta.titular = paulo;
      conta.saldo = 500;
      conta.agencia = 563;
      conta.numero = 5634572;

      Console.WriteLine(paulo.nome);
      Console.WriteLine(conta.titular.nome);
    }
  }
}
