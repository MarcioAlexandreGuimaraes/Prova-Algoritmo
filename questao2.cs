
using System;

class Program
{
    static void Main()
    {
     
        Console.WriteLine("Digite a primeira data (formato: yyyy-MM-dd):");
        DateTime data1 = DateTime.Parse(Console.ReadLine());

  
        Console.WriteLine("Digite a segunda data (formato: yyyy-MM-dd):");
        DateTime data2 = DateTime.Parse(Console.ReadLine());

      
        TimeSpan diferenca = data2 - data1;

        
        Console.WriteLine($"A quantidade de dias entre as duas datas é: {diferenca.Days}");
    }
}
