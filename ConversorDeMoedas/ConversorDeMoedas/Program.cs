using Estudos;

string moedaDeOrigem;
decimal valor;

Console.Write("Digite a moeda desejada: ");
moedaDeOrigem = Convert.ToString(Console.ReadLine());

if (moedaDeOrigem == "USD" || moedaDeOrigem == "EUR" || moedaDeOrigem == "GBP")
{

    Console.Write("Digite o valor desejado: ");
    valor = Convert.ToDecimal(Console.ReadLine());

    decimal calculo = conversorDeMoedas.converterParaReal(valor, moedaDeOrigem);
    Console.WriteLine($"O valor para a conversão em {moedaDeOrigem} é de: R${calculo}");

}
else
{
    Console.WriteLine("Moeda inválida,tente novamente");
}

Console.ReadKey();



