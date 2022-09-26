using System;

internal class NewBaseType
{
    private const string V = "Pole trojkata wynosi ";

    static void Main()
    {
        Console.WriteLine("Podaj a");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Podaj h");
        int h = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Pole = "+(a*h)/2);
    }
}
