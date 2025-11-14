namespace exercicios_poo;

public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("SOM ");
    }
}

public class Gato : Animal   
{
    public override void EmitirSom()
    {
        Console.WriteLine("EU SOU GATINHO QUE FAZ MIAU");
}
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("EU SOU UM CACHORRO QUE FAZ AU AU ");
    }
}

// DEMOSTRAÇÃO !!POR BOAS PRATICAS É BOM SEPARAR EM ARQUIVOS .