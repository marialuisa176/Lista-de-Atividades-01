// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;

double nota1;
double nota2;

Console.WriteLine("Qual foi sua nota na primeira avaliação? ");
nota1 = double.Parse(Console.ReadLine());

Console.WriteLine("Qual foi sua nota na segunda avaliação? ");
nota2 = double.Parse(Console.ReadLine());

double media = nota1 + nota2 / 2;
if (media >= 6)
{
    Console.WriteLine("Você está APROVADO");
}
else
{
    Console.WriteLine("Você está REPROVADO");
}