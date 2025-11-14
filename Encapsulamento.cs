namespace exercicios_poo;

public class ContaBancaria
{
    private double saldo;    // privado

    public void Depositar(double valor)
    {
        if (valor > 0)
            saldo += valor;
    }

    public void Sacar(double valor)
    {
        if (valor > 0 && valor <= saldo)
        {
            saldo -= valor;

        }


        else
            Console.WriteLine("Saldo Insuficiente");


    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo atual: {saldo}");
    }


    //  classe filha - HERANÇA 

    public class ContaEspecial : ContaBancaria
    {
        public void Debitar(double valor)
        {
            // saldo -= valor NAO PODE FAZER PQ O SALDO É PRIVADO , MAS POSSO USAR O METODO !!!
            Sacar(valor);
        }
    }
}


// DEMOSTRAÇÃO !!POR BOAS PRATICAS É BOM SEPARAR EM ARQUIVOS .