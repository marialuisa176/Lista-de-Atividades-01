// See https://aka.ms/new-console-template for more information

int numTotalEleitores;
int numVotosBrancos;
int numVotosNulos;
int numVotosValidos;

Console.WriteLine("Digite o número total de eleitores: ");
numTotalEleitores = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de votos brancos: ");
numVotosBrancos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de votos nulos: ");
numVotosNulos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o número de votos válidos: ");
numVotosValidos = int.Parse(Console.ReadLine());

Console.WriteLine($"Percentuais em relação ao total de eleitores: Votos Brancos - {(double)numVotosBrancos/numTotalEleitores * 100}%, Votos Nulos - {(double)numVotosNulos/numTotalEleitores * 100}%, Votos Válidos: {(double)numVotosValidos/numTotalEleitores * 100}%");

