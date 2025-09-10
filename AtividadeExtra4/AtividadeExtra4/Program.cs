// See https://aka.ms/new-console-template for more information

double valorprod;

Console.WriteLine("Informe o valor do produto: ");
valorprod = double.Parse(Console.ReadLine());

Console.WriteLine($"O produto com desconto é: {valorprod * 0.95} ");
