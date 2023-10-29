using System;

class Program
{
    static void TablaMultiplicarRecursiva(int numero, int multiplicador, int limite)
    {
        if (multiplicador > limite)
        {
            return;
        }

        Console.WriteLine($"{numero} x {multiplicador} = {numero * multiplicador}");

        TablaMultiplicarRecursiva(numero, multiplicador + 1, limite);
    }

    static void Main()
    {
        Console.Write("Ingrese el número para la tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el límite para la tabla de multiplicar: ");
        int limite = int.Parse(Console.ReadLine());

        TablaMultiplicarRecursiva(numero, 1, limite);
    }
}