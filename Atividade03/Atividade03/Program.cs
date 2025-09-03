// See https://aka.ms/new-console-template for more information

int numba;
int numalt;

Console.WriteLine("Digite a base do retângulo: ");
numba = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do retângulo: ");
numalt = int.Parse(Console.ReadLine());
Console.WriteLine($"A área do retângulo é: {numba * numalt}");