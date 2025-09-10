// See https://aka.ms/new-console-template for more information

int num1;

Console.WriteLine("Digite um número (não é permitido 0): ");
num1 = int.Parse(Console.ReadLine());

if (num1 > 0)
{
    Console.WriteLine("O número digitado é positivo");
}
else
{
    Console.WriteLine("O número digitado é negativo");
}
