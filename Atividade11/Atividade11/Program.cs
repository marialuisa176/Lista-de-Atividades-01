// See https://aka.ms/new-console-template for more information

int anodenasc, anoatual, idade;

Console.WriteLine("Informe em que ano estamos: ");
anoatual = int.Parse(Console.ReadLine());

Console.WriteLine("Informe em que ano você nasceu: ");
anodenasc = int.Parse(Console.ReadLine());

if (anoatual - anodenasc > 18 && anoatual - anodenasc < 60)
{
    Console.WriteLine("Você é obrigado a votar esse ano");
}
else
{
    Console.WriteLine("Você não é obrigado a votar esse ano");
}