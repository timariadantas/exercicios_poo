
using exercicios_poo;

Console.WriteLine("Resultados dos Exercicios ...");


ContaBancaria.ContaEspecial conta = new ContaBancaria.ContaEspecial();
conta.Depositar(300);
conta.Debitar(150);
conta.MostrarSaldo();

Animal bichano = new Gato();
bichano.EmitirSom();

Animal dog = new Cachorro();
dog.EmitirSom();

Pagamento pagamento = new Pix();
pagamento.Valor = 100;
pagamento.MostrarValor();
pagamento.Processar();
