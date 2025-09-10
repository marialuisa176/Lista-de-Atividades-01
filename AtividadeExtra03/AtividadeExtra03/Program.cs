// See https://aka.ms/new-console-template for more information

decimal numA, numB, numC;

Console.WriteLine("Digite um valor para A: ");
numA = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor para B: ");
numB = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite um valor para C: ");
numC = decimal.Parse(Console.ReadLine());

Console.WriteLine($"O valor de delta é: {numB * numB - 4 * numA * numC}");

