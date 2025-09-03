// See https://aka.ms/new-console-template for more information

decimal salario;
int reajuste;

Console.WriteLine("Digite o valor do seu salário: ");
salario = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite a porcentagem de reajuste: ");
reajuste = int.Parse(Console.ReadLine());

Console.WriteLine($"O valor do seu novo salário é de: R$ {(salario * reajuste / 100) + salario}");
