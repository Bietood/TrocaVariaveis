// See https://aka.ms/new-console-template for more information
string Nome1, Nome2, Auxiliar;

Console.WriteLine("--- Troca de Valores ---\n");

Console.Write("Nome 1..: ");
Nome1 = Console.ReadLine()!;

Console.Write("Nome 2..: ");
Nome2 = Console.ReadLine()!;

Auxiliar = Nome1;
Nome1 = Nome2;
Nome2 = Auxiliar;

Console.WriteLine("\nApós trocar os valores temos:\n");

Console.WriteLine($"Nome 1 = {Nome1}");
Console.WriteLine($"Nome 2 = {Nome2}");