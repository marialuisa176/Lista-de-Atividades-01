// See https://aka.ms/new-console-template for more information

int num1, num2;

Console.WriteLine("Digite um número: ");
num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número (ele deve ser diferente do primeiro): ");
num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("O maior número é o número 1");
}
else
{
    Console.WriteLine("O maior número é o número 2");
}