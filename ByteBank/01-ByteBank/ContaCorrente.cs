namespace _01_ByteBank
{
  public class ContaCorrente
  {
    public Cliente titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    public bool Sacar(double valor)
    {
      if (saldo < valor)
      {
        return false;
      }

      this.saldo -= valor;
      return true;
    }

    public void Depositar(double valor)
    {
      saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
      if (saldo < valor)
      {
        return false;
      }

      saldo -= valor;
      contaDestino.Depositar(valor);
      return true;
    }
  }
}