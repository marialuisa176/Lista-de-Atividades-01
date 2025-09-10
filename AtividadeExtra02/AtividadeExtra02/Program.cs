// See https://aka.ms/new-console-template for more information

using System;

decimal larg, alt, area;

Console.WriteLine("Infome a largura da parede: ");
larg = decimal.Parse(Console.ReadLine());

Console.WriteLine("Informe a altura da parede: ");
alt = decimal.Parse(Console.ReadLine());

Console.WriteLine($"A área da parede é: {alt * larg}");
area = larg * alt;

Console.WriteLine($"A quantidade de tinta necessária é: {(double)area / 2}L");

