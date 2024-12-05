using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> ddds = new Dictionary<int, string>
        {
            { 61, "Brasília" },
            { 71, "Salvador" },
            { 11, "São Paulo" },
            { 21, "Rio de Janeiro" },
            { 32, "Juiz de Fora" },
            { 19, "Campinas" },
            { 27, "Vitória" },
            { 31, "Belo Horizonte" }
        };

        Console.WriteLine("Digite um código DDD:");
        int ddd = int.Parse(Console.ReadLine());

        if (ddds.ContainsKey(ddd))
        {
            Console.WriteLine($"O DDD {ddd} corresponde a {ddds[ddd]}.");
        }
        else
        {
            Console.WriteLine("DDD não cadastrado.");
        }
    }
}
