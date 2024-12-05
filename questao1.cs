using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um valor inteiro:");
        int valor = int.Parse(Console.ReadLine());

        int[] notas = { 100, 50, 20, 10, 5, 2, 1 };
        int[] quantidadeNotas = new int[notas.Length];

        for (int i = 0; i < notas.Length; i++)
        {
            quantidadeNotas[i] = valor / notas[i];
            valor %= notas[i];
        }

        Console.WriteLine("Menor número de notas possíveis:");
        for (int i = 0; i < notas.Length; i++)
        {
            if (quantidadeNotas[i] > 0)
            {
                Console.WriteLine($"{quantidadeNotas[i]} nota(s) de {notas[i]}");
            }
        }
    }
}
