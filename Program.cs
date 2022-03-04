
public class Conta
{
    private double saldo;

    public Conta()
    {
        saldo = 0.00;
    }

    public void GetSaldo()
    {
        Console.WriteLine("Seu Saldo é {0}", saldo);
    }


    public void Depositar(double valor)
    {
        saldo += valor;
        Console.WriteLine("Seu novo saldo é {0}", saldo);
    }

    public void Sacar(double valor)
    {
        if (saldo > 0 && saldo >= valor)
        {
            saldo -= valor;
            Console.WriteLine("Saque feito com sucesso no valor de {0}", valor);
        }
        else
        {
            Console.WriteLine("Saldo inválido");
        }
    }

}

class Program
{
    static void Main()
    {
        Conta conta = new();

        int parada = 0;

        while (parada == 0)
        {
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - VER SALDO");
            Console.WriteLine("2 - DEPOSITAR");
            Console.WriteLine("3 - SACAR");
            Console.WriteLine("4 - FINALIZAR PROGRAMA");


            int pos = int.Parse(Console.ReadLine());

            switch (pos)
            {
                case 1:
                    conta.GetSaldo();
                    break;

                case 2:
                    Console.WriteLine("Digite o valor do depósito");
                    double valorDeposito = double.Parse(Console.ReadLine());
                    conta.Depositar(valorDeposito);
                    break;

                case 3:
                    Console.WriteLine("Digite o valor do saque");
                    double valorSaque = double.Parse(Console.ReadLine());
                    conta.Sacar(valorSaque);
                    break;

                default:
                    parada = 1;
                    break;
            }
        }

    }

}





