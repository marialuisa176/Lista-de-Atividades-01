// See https://aka.ms/new-console-template for more information

int num1, num2, num3;

Console.WriteLine("Digite um número: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número (diferente do primeiro): ");
num2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número (diferente dos dois anteriores: ");
num3 = int.Parse(Console.ReadLine());

int[] valores = { num1, num2, num3 };
//O método Array.Sort() serve para ordenar os elementos do array
//em ordem crescente (do menor para o maior) automaticamente.
Array.Sort(valores);

Console.WriteLine("Valores em ordem crescente:");
//O foreach é um laço de repetição (loop) em C# que permite percorrer todos os elementos de uma coleção,
//como um array, uma lista ou qualquer outro tipo de coleção que implementa a interface
foreach (int valor in valores)
{
    Console.WriteLine(valor);
}