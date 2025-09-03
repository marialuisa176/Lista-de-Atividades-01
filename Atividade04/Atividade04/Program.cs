// See https://aka.ms/new-console-template for more information

int numanos;
int nummes;
int numdias;

Console.WriteLine("Informe quantos anos você tem: ");
numanos = int.Parse(Console.ReadLine());

Console.WriteLine("Informe quantos meses faltam para seu próximo aniversário: ");
nummes = int.Parse(Console.ReadLine());

Console.WriteLine("Informe quantos dias faltam para seu próximo aniversário (leve em consideração apenas dias, a cada trinta dias deve se considerar um mês): ");
numdias = int.Parse(Console.ReadLine());

Console.WriteLine($"Você tem {numanos * 365 + ((12 - nummes) * 30) + (30 - numdias)} dias");
