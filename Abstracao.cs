namespace exercicios_poo;

public abstract class Pagamento
{
    public decimal Valor;
    public abstract void Processar();

    public void MostrarValor()
    {
        Console.WriteLine($"Valor de Pagamento: {Valor}");
    }
}

///////////

public class Pix : Pagamento
{
    public override void Processar()
    {
        Console.WriteLine("Processando pagamento pix");
    }
}