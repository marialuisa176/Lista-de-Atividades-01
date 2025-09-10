// See https://aka.ms/new-console-template for more information

decimal valoremreal;

Console.WriteLine("Digite quantos reais você tem na cateira: ");
valoremreal = decimal.Parse(Console.ReadLine());

Console.WriteLine($"O valor que você pode comprar em dólar é: $ {(double)valoremreal / 3.45}");