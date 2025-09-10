// See https://aka.ms/new-console-template for more information

int nummacas;

Console.WriteLine("Quantas maçãs você comprou? ");
nummacas = int.Parse(Console.ReadLine());

if (nummacas >= 12)
    {
    System.Console.WriteLine($"O valor total é: R$ {nummacas * 1}");
    }
else
    {
    System.Console.WriteLine($"O valor total é: R$ {nummacas * 1.30}");
    }