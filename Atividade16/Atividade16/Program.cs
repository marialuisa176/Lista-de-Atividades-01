// See https://aka.ms/new-console-template for more information

int num;
int fatorial = 1;

Console.WriteLine("Digite um número");
num = int.Parse(Console.ReadLine());

// Calculando o fatorial de n
for (int i = 1; i <= num; i++)
{
    fatorial *= i;  // Multiplica o valor de fatorial pelo valor de i
}
Console.WriteLine($"O fatorial de {num} é: {fatorial}");

